﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
   public class Thing
    {
        public object Data = default(object);
        public string Process(string input)
        {
            if (Data == input)
            {
                return Data.ToString() + Data.ToString();

            }
            else
            {
                return "test";//Data.ToString();
            }
        }

    }
}
