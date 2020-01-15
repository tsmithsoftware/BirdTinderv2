using System;
using System.Collections.Generic;
using System.Text;

namespace BirdTinderv2.DAL.Repositories
{
    public class SystemUserRepo : GenericRepository<SystemUser>
    {
        public SystemUserRepo(ModelContext context) : base(context)
        {
        }
    }
}
