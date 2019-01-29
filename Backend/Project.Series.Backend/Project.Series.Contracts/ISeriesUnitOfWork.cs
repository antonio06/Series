﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Series.Contracts
{
    public interface ISeriesUnitOfWork
    {
        ISeriesRepository SeriesRepository { get; }
    }
}
