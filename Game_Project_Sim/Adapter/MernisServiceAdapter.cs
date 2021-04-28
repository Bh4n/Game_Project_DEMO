using Game_Project_Sim.Abstract;
using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using Game_Project_Sim.Entities;
namespace Game_Project_Sim.Adapter
{
    class MernisServiceAdapter : IUserValidateService
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(user.NationalityId, user.FirstName.ToUpper(),
                user.LastName.ToUpper(), user.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
