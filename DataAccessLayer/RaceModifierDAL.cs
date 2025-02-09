﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RaceModifierDAL
    {
        // the region tags arent needed but they were used as a learning tool to help visualize the shape of the code
        #region Direct Properties
        public int RaceModifierID { get; set; }
        public int RaceID { get; set; }
        public int StatID { get; set; }
        public int Modifier { get; set; }
        #endregion

        #region Indirect Properties
        public string RaceName { get; set; }
        #endregion 

        public override string ToString()
        {
            return $"RaceModifierID: {RaceModifierID} RaceID: {RaceID} StatID: {StatID} Modifier: {Modifier} RaceName: {RaceName}";
        }

    }
}
