﻿using System;

namespace R.Scheduler.Ftp
{
    public interface IFtpLibrary :IDisposable
    {
        /// <summary>
        /// Binds the library to the specified host and port
        /// </summary>
        /// <param name="host">The address of the target ftp site</param>
        /// <param name="serverPort">port</param>
        /// <param name="userName">The username</param>
        /// <param name="password">The password</param>
        void Connect(string host, int serverPort, string userName, string password, string remoteDirectoryPath = null);

        /// <summary>
        /// Downloads the files with specified extension into the local directory
        /// </summary>
        /// <param name="localDir"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cutOff"></param>
        void GetFiles(string localDir, string fileExtension, TimeSpan cutOff);
    }
}