﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10_16
{
    class PersistantGameData
    {
        public bool JustWon { get; set; }
        public LevelDescription CurrentLevel { get; set; }
        public PersistantGameData()
        {
            JustWon = false;
        }
    }

}