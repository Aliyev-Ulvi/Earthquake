﻿using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserDal(EarthquakeContext context) : BaseRepository<User, EarthquakeContext>(context), IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            var context = new EarthquakeContext();
            var result = from operationClaim in context.OperationClaims
                         join o in context.UserOperationClaims
                         on operationClaim.Id equals o.OperationClaimId
                         where o.UserId == user.Id
                         select
                         new OperationClaim
                         {
                             Id = operationClaim.Id,
                             Name = operationClaim.Name
                         };
            return result.ToList();

        }
    }
}