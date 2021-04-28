using Game_Project_Sim.Abstract;
using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Concrete
{
    class OrderManager : IOrderService
    {
        public void CampWithoutSale(User user, Game game)
        {
            Console.WriteLine(user.FirstName + " adlı kişi  " + game.Name + " oyununu başarılı bir şekilde satınaldı.");
        }

        public void CampWithSale(User user, Game game, Campaign campaign)
        {
            Console.WriteLine(user.FirstName + " adlı kişi  " + game.Name + " oyununu "+campaign.Name+" ile beraber başarılı bir şekilde satın aldı.");
        }
    }
}
