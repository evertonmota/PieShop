﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopping.Models
{
    public interface IPieRepository
    {
        IEnumerable <Pie> Pies { get;}
        IEnumerable<Pie> PiesOfTheWeek { get;}

        Pie GetById(int pieId);
    }
}
