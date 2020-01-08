using BirdTinderv2.DAL;
using BirdTinderv2.DAL.Repositories;
using System;

namespace DALTesting
{
    class Program
    {
        private static ModelContext modelContext = new ModelContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var repo = new SystemUserRepo(modelContext);
            var user = new SystemUser();
            user.FirstName = "John";
            user.LastName = "Mcclane";
            //user.Password = HashProvider.
            repo.Insert(user);
        }
    }
}
