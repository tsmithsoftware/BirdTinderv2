using System;
using System.Collections.Generic;
using System.Text;

namespace BirdTinderv2.DAL.Repositories
{
    public class BirdUserRepo : GenericRepository<BirdUser>
    {
        public BirdUserRepo(ModelContext context) : base(context)
        {
        }
    }
}
