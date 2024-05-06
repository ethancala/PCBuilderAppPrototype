using System;

namespace PCBuilderPrototype1.Models
{
    public class PCBuild
    {
        public int ID { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string MOBO { get; set; }
    }
}
