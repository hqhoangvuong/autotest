﻿using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IFunctionTesting
    {
        public IEnumerable<FunctionTesting> GetAllProject();
    }
}
