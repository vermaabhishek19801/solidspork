using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace solid_spork.Models
{
    public static class Utility
    {

        internal static void wrriteException(string message, string exception)
        {
            var fileName = "error.txt";
            var FolderPath = HttpContext.Current.Server.MapPath("~/Upload");
            var path = Path.Combine(FolderPath, fileName);
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            }
            System.IO.File.AppendAllText(path, Environment.NewLine);
            System.IO.File.AppendAllText(path, "====" + System.DateTime.Now.ToString() + "====");
            System.IO.File.AppendAllText(path, Environment.NewLine);
            System.IO.File.AppendAllText(path, message);
            System.IO.File.AppendAllText(path, exception);
            System.IO.File.AppendAllText(path, Environment.NewLine);
        }
    }
}