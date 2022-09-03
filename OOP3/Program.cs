using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            ICrediManager requirementCrediManager = new RequirementCrediManager();
            ICrediManager vehicleCrediManager = new VehicleCrediManager();
            ICrediManager houseCrediManager = new HouseCrediManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //buradaki kod Başvuru yaptaki ICrediManagera Hangi Crediyi Hesaplayacagını Soyluyor.
            //applicationManager.Application(requirementCrediManager);
            // Basvuru Manageri için bir list olusturduk buradaki bilgileri
            // Basvuru Managerine yolluyacaz.
            List<ICrediManager> crediler = new List<ICrediManager>()
            {
                requirementCrediManager,vehicleCrediManager
            };
            applicationManager.Crediİnformation(crediler);
        }
    }
}
