﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class Rocky : Player
    {
        public Rocky() 
        {
            Name = "Rocky";
        }

        

        public override RPSEnum GenerateRPS()
        {
            return RPSEnum.Rock;
        }
    }
}
