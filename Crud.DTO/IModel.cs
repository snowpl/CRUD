﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DTO
{
    public interface IModel
    {
        int Id { get; set; }

        DateTime? CreateDate { get; set; }

    }
}
