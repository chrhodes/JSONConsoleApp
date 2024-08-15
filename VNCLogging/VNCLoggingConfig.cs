﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONConsoleApp.VNCLogging
{
    public class VNCLoggingConfig
    {
        public Boolean Enable { get; set; }

        public Boolean Info00 { get; set; }
        public Boolean Info01 { get; set; }
        public Boolean Info02 { get; set; }
        public Boolean Info03 { get; set; }
        public Boolean Info04 { get; set; }

        public Boolean Debug00 { get; set; }
        public Boolean Debug01 { get; set; }
        public Boolean Debug02 { get; set; }
        public Boolean Debug03 { get; set; }
        public Boolean Debug04 { get; set; }

        public Boolean ApplicationStart { get; set; }
        public Boolean ApplicationEnd { get; set; }
        public Boolean ApplicationInitialize { get; set; }

        public Boolean Application { get; set; }
        public Boolean ApplicationServices { get; set; }
        public Boolean Domain { get; set; }
        public Boolean DomainServices { get; set; }
        public Boolean Constructor { get; set; }
        public Boolean Core { get; set; }
        public Boolean Event { get; set; }
        public Boolean EventHandler { get; set; }
        public Boolean INPC { get; set; }
        public Boolean Module { get; set; }
        public Boolean ModuleInitialize { get; set; }
        public Boolean Persistence { get; set; }
        public Boolean PersistenceLow { get; set; }
        public Boolean Infrastructure { get; set; }
        public Boolean Presentation { get; set; }
        public Boolean View { get; set; }
        public Boolean ViewLow { get; set; }
        public Boolean ViewModel { get; set; }
        public Boolean ViewModelLow { get; set; }
    }
}
