using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameBoardDice.Infrastructure
{
    public static class UrlHelpers
    {
        public static string BoxImagePath(this UrlHelper helper, string imageFileName)
        {
            var boxImageFolder = AppConfig.GameBoxesFolderRelative;
            var path = Path.Combine(boxImageFolder, imageFileName);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
    }
}