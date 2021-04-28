using Game_Project_Sim.Abstract;
using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklendi.\nKampanya ismi: " + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyalardan çıkarıldı.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " başarıyla güncellendi.");
        }
    }
}
