﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes
{
   public class ServerData : EventArgs
    {

        public string IPofServer
        { get; set; }

        public int PortofServer
        { get; set; }

    }
}
