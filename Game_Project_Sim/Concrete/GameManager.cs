using System;
using System.Collections.Generic;
using System.Text;
using Game_Project_Sim.Abstract;
using Game_Project_Sim.Entities;

namespace Game_Project_Sim.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " güncellendi");
        }
    }
}
