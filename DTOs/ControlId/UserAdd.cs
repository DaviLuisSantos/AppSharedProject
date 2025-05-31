using System;
using System.Collections.Generic;
using System.Text;

namespace AppSharedProject.DTO.ControlId
{
    class UserAdd(int id, string name, string registration, long begin_time, long end_time)
    {
        public int id { get; set; } = id;
        public string name { get; set; } = name;
        public string registration { get; set; } = registration;
        public long begin_time { get; set; } = begin_time;
        public long end_time { get; set; } = end_time;
    }
}
