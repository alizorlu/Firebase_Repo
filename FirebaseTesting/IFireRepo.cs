﻿using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseTesting
{
    public interface IFireRepo<T>
    {
        Task  Add(T Model,Guid id);
        Task Delete(Guid id);
        Task<List<T>> GetList();
        Task<List<T>> GetList(int counter = 100);
        Task<T[]> GetListSeries(int counter = 100);
        Task<T> Find(Guid id);
        Task<T> Update(Guid id,T Model);
    }
}
