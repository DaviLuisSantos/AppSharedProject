using System;
using System.Collections.Generic;
using System.Text;

namespace AppSharedProject.DTO.ControlId
{
    class UserGoupAdd(int userId)
    {
        public int Group_id{ get; set; } = 1;
        public int User_id { get; set; } = userId;
    }
}
