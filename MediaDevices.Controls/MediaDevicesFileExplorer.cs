using CodeArtEng.Controls;
using CodeArtEng.RemoteScheduler.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MediaDevices.Controls
{
    /// <summary>
    /// Media Device File Explorer Implementation. 
    /// Only tested for Android Device.
    /// </summary>
    public class MediaDevicesFileExplorer : IFileExplorer
    {
        /// <summary>
        /// Device Connected event.
        /// </summary>
        public event EventHandler DeviceConnected;
        /// <summary>
        /// Device disconnected event.
        /// </summary>
        public event EventHandler DeviceDisconnected;

        private readonly MediaManager MediaManager;
        private MediaDevice Device;
        private MediaDeviceWatcher Watcher = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Construct object from Main Thread.</remarks>
        public MediaDevicesFileExplorer()
        {
            MediaManager = new MediaManager();
        }

        #region [ IFileExplorer Interface ]

        /// <summary>
        /// Device Description
        /// </summary>
        public string Name { get; private set; } = null;
        /// <summary>
        /// Root folder path.
        /// </summary>
        public string Root { get; private set; } = null;
        /// <summary>
        /// Not used 
        /// </summary>
        public FileExplorerType HostType { get; }
        /// <summary>
        /// Path separator.
        /// </summary>
        public char PathSeparator { get => '\\'; }
        /// <summary>
        /// Return device connection status
        /// </summary>
        public bool IsConnected { get; private set; } = false;
        /// <summary>
        /// Folder path prefix. Return 'This PC\\'
        /// </summary>
        public string FolderPathPrefix { get => "This PC\\" + Name; }

        /// <summary>
        /// Get sub-folders from selected path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FileExplorerItemInfo[] GetDirectories(string path)
        {
            try
            {
                string[] folders = Device.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly).ToArray();
                List<FileExplorerItemInfo> directories = new List<FileExplorerItemInfo>();

                FileExplorerItemInfo tItem;
                foreach (string f in folders)
                {
                    tItem = new FileExplorerItemInfo(Path.GetFileName(f), f, true);
                    tItem.Length = 0;
                    directories.Add(tItem);
                }
                return directories.ToArray();
            }
            catch { return null; }
        }

        /// <summary>
        /// Get files from selected path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FileExplorerItemInfo[] GetFiles(string path)
        {
            string[] folders = Device.EnumerateFiles(path, "*", SearchOption.TopDirectoryOnly).ToArray();
            List<FileExplorerItemInfo> files = new List<FileExplorerItemInfo>();

            FileExplorerItemInfo tItem;
            foreach (string f in folders)
            {
                tItem = new FileExplorerItemInfo(Path.GetFileName(f), f, false);
                tItem.Length = 0;
                files.Add(tItem);
            }
            return files.ToArray();
        }

        #endregion

        /// <summary>
        /// Connect device.
        /// </summary>
        /// <param name="deviceDescription">(Optional) Update device description. Leave blank to use current <see cref="Name"/>.</param>
        /// <returns>Connection status true / false. </returns>
        public bool ConnectDevice(string deviceDescription = null)
        {
            if (!string.IsNullOrEmpty(deviceDescription)) Name = deviceDescription;
            Reconnect();

            if (Watcher != null) Watcher.Stop();
            Watcher = new MediaDeviceWatcher(Name);
            Watcher.DeviceConnected += Watcher_DeviceConnected;
            Watcher.DeviceDisconnected += Watcher_DeviceDisconnected;
            Watcher.Start();

            return IsConnected;
        }

        private void Watcher_DeviceDisconnected(object sender, EventArgs e)
        {
            Disconnect();
            DeviceDisconnected?.Invoke(this, null);
        }

        private void Watcher_DeviceConnected(object sender, EventArgs e)
        {
            DeviceConnected?.Invoke(this, null);
        }

        /// <summary>
        /// Disconnect current device.
        /// </summary>
        public void Disconnect()
        {
            IsConnected = false;
            if (Device != null)
            {
                if (Device.IsConnected)
                {
                    Device.Disconnect();
                    Device.Dispose();
                    Device = null;
                }
            }
        }

        /// <summary>
        /// Reconnect current device.
        /// </summary>
        public void Reconnect()
        {
            Disconnect();

            //Loop max 2 seconds.
            for (int x = 0; x < 10; x++)
            {
                Device = MediaManager.GetDevice(Name);
                if (Device != null) break;
                System.Threading.Thread.Sleep(200);
            }

            if (Device != null)
            {
                Device.Connect();
                IsConnected = true;
                Root = Device.GetRootDirectory().Name;
            }
        }

        /// <summary>
        /// Return root folder of the current device.
        /// For android device, return device description if connected.
        /// </summary>
        /// <param name="inputPath"></param>
        /// <returns></returns>
        public string GetSelectedFolderRoot(string inputPath)
        {
            if (!IsConnected) return string.Empty;
            if (string.IsNullOrEmpty(Root)) return string.Empty;

            return Name;
        }
    }
}
