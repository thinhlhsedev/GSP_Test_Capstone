﻿using DBApproach.Domain.Interfaces;
using DBApproach.Domain.Repository.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DBApproach.Infrastructure.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IQueryable<Role> GetAttendanceByAccount(Expression<Func<Role, bool>> expression)
        {
            return DbSet.Where(expression);
        }
    }
}