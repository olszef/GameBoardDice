using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GameBoardDice.Infrastructure
{
    public class AppConfig
    {
        private static string _gameBoxesFolerRelative = ConfigurationManager.AppSettings["GameBoxesFolder"];

        public static string GameBoxesFolderRelative
        {
            get
            {
                return _gameBoxesFolerRelative;
            }
        }
    }
}