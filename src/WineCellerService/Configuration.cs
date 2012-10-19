namespace WineCellerService
{
    using System.Collections.Generic;
    using OpenRasta.Configuration;
    using OpenRasta.DI;

    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Uses.Resolver.AddDependencyInstance<IWineProvider>(new WineProvider());

                ResourceSpace.Has.ResourcesOfType<List<Wine>>()
                    .AtUri("/Wines").And
                    .AtUri("/Wines/search/{query}")
                    .HandledBy<WineCollectionHandler>()
                    .AsXmlDataContract()
                    .And
                    .AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<Wine>()
                    .AtUri("/Wines/{id}")
                    .HandledBy<WineHandler>()
                    .AsXmlDataContract()
                    .And
                    .AsJsonDataContract();
            }
        }
    }
}
