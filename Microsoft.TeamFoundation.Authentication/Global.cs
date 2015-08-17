﻿using System;

namespace Microsoft.TeamFoundation.Authentication
{
    internal static class Global
    {
        /// <summary>
        /// Creates the correct user-agent string for HTTP calls.
        /// </summary>
        /// <returns>The `user-agent` string for "git-tools".</returns>
        public static string GetUserAgent()
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            return String.Format("git-credential-manager ({0}; {1}; {2}) CLR/{3} git-tools/{4}",
                                 Environment.OSVersion.VersionString,
                                 Environment.OSVersion.Platform,
                                 Environment.Is64BitOperatingSystem ? "x64" : "x86",
                                 Environment.Version.ToString(3),
                                 version.ToString(3));
        }
    }
}
