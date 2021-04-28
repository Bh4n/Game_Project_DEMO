using Game_Project_Sim.Abstract;
using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Concrete
{
    public class UserManager : IUserService
    {
        IUserValidateService _userValidateService;

        public UserManager(IUserValidateService userValidateService)
        {
            _userValidateService = userValidateService;
        }



        public void Add(User user)
        {
            if (_userValidateService.Validate(user))
            {
                Console.WriteLine(user.FirstName + " eklendi");
            }
            else
            {
                throw new Exception("Not invalid User: " + user.FirstName);
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Sistemden kayıt silindi: " + user.FirstName);
        }

        public void Update(User user)
        {
            Console.WriteLine("Sistemdeki bilgiler güncellendi :" + user.FirstName);
        }
    }
}
