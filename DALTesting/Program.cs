using BirdTinder.API.Helpers;
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
            /** var repo = new SystemUserRepo(modelContext);
             var user = new SystemUser();
             user.Id = repo.GetSize();
             user.FirstName = "John";
             user.LastName = "Mcclane";
             user.Password = HashProvider.sha256("password");
             repo.Insert(user);

             var allUsers = repo.GetAll();
             var count = allUsers.Count; **/

            var repo = new BirdUserRepo(modelContext);
            var bird = new BirdUser();
            bird.UserName = "Bird";
            bird.UserId = repo.GetSize();
            bird.UserBio = "Some Great Crested Tit";
            bird.UserImageUri = "someuri";
            repo.Insert(bird);
        }
    }
}
