using CodeArtEng.Controls;
using CodeArtEng.RemoteScheduler.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MediaDevices.Controls
{
    public class MediaDevicesFileExplorer : IFileExplorer
    {
        public event EventHandler ConnectionStatusChanged;

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
        public string Root { get; private set; } = null;
        public FileExplorerType HostType { get; }
        public char PathSeparator { get => '/'; }
        public bool IsConnected { get; private set; } = false;
        public string FolderPathPrefix { get => "This PC\\" + Name; }

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

        public bool ConnectDevice(string deviceDescription)
        {
            Name = deviceDescription;
            Reconnect();

            if (Watcher != null) Watcher.Stop();
            Watcher = new MediaDeviceWatcher(deviceDescription);
            Watcher.DeviceConnected += Watcher_DeviceConnected;
            Watcher.DeviceDisconnected += Watcher_DeviceDisconnected;
            Watcher.Start();

            return IsConnected;
        }

        private void Watcher_DeviceDisconnected(object sender, EventArgs e)
        {
            IsConnected = false;
            ConnectionStatusChanged?.Invoke(this, null);
        }

        private void Watcher_DeviceConnected(object sender, EventArgs e)
        {
            IsConnected = true;
            Reconnect();
        }

        public void Reconnect()
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

            Device = MediaManager.GetDevice(Name);
            if (Device != null)
            {
                Device.Connect();
                IsConnected = true;
                Root = Device.GetRootDirectory().Name;
            }
            ConnectionStatusChanged?.Invoke(this, null);
        }

        public string GetSelectedFolderRoot(string inputPath)
        {
            if (!IsConnected) return string.Empty;
            if (string.IsNullOrEmpty(Root)) return string.Empty;

            return Name;
        }
    }
}
