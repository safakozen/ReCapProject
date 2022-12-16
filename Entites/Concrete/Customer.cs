﻿using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Customer : IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
