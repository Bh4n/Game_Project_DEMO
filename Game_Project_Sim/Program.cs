using System;
using Game_Project_Sim.Entities;
using Game_Project_Sim.Concrete;
using Game_Project_Sim.Abstract;
using Game_Project_Sim.Adapter;

namespace Game_Project_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                FirstName = "Sample Name",
                LastName = "Sample Last Name",
                DateOfBirth = new DateTime(1999, 12, 06),
                NationalityId = 121312312312
            };

            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user1);

            Console.WriteLine("------------");

            Game game1 = new Game() { Id = 1, Name = "Euro Truck Simulator 2",Price = 30 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("------------");

            Campaign campaign1 = new Campaign() {Id=1,Name = "Hoşgeldin Kampanyası",Discount =0.5};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Console.WriteLine("------------");

            OrderManager orderManager = new OrderManager();
            orderManager.CampWithSale(user1, game1, campaign1);
            orderManager.CampWithoutSale(user1, game1);

        }
    }
}
