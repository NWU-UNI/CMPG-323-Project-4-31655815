﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {


        //Task FindAsyncVal(Guid? id);
        //Task FindAsyncVal(Guid? id);
        Task<object> ToListAsync();
    }




}
