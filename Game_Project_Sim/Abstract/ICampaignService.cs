using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Abstract
{
   public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
