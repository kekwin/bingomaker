﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BingoMaker.Web.Models
{
    public class BingoSettings
    {
        public string Font { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string FreeText { get; set; }

        [DataType(DataType.MultilineText)]
        public string WordListBlob { get; set; }

        public string[] WordList { get; set; }

        [Range(1, int.MaxValue)]
        public int CardCount { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> Fonts { get; set; }

        public BingoSettings()
        {
            this.Font = "Arial";
            this.FreeText = "BINGO";
            this.CardCount = 12;
        }
    }
}