using System;
using System.Collections.Generic;
using System.Text;
using Game_Project_Sim.Entities;
namespace Game_Project_Sim.Abstract
{
  public  interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
