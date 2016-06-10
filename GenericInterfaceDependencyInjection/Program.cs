using GenericInterfaceDataModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace GenericInterfaceDependencyInjection
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var container = new UnityContainer();
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //var containerName = Console.ReadLine();
            IUnityContainer container = new UnityContainer().LoadConfiguration(section);


            var vat = container.Resolve<ITaxRepository<StateRequest,StateResponse>>();
            //container.Res

            Console.WriteLine(vat.GetVat(new StateRequest{TaxRate=12}));
            Console.ReadLine();
        }
    }
}
