﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData.Interfaces
{
    public interface IUnitOfWorkFactory
    {
        void SaveChanges();
    }
}