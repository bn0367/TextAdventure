﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Wall : Entity
    {
        public Wall(int x, int y, Room room) : base(x, y, "Wall", room, false, '█') { }
    }
}
