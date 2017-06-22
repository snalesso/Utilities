﻿namespace Digimezzo.Utilities.IO
{
    public class Actions
    {
        public static void TryOpenLink(string url)
        {
            try
            {
                // Try to open the link in the Default Browser
                System.Diagnostics.Process.Start(url);
            }
            catch (System.Exception)
            {
                // If that didn't work, try to open it in Internet Explorer
                try
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("IExplore.exe", url);
                    System.Diagnostics.Process.Start(startInfo);
                    startInfo = null;
                }
                catch (System.Exception)
                {
                    // If opening in Internet Explorer didn't work, throw an exception which should be caught and logged.
                    throw;
                }
            }
        }

        public static void TryOpenMail(string emailAddress)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto://" + emailAddress);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static void TryOpenPath(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static void TryViewInExplorer(string path)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + path + "\"");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}