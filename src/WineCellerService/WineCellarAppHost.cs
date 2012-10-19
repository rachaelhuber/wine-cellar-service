namespace WineCellerService
{
    using System.Collections.Generic;
    using Funq;
    using ServiceStack.ServiceInterface.Cors;
    using ServiceStack.WebHost.Endpoints;

    public class WineCellarAppHost : AppHostHttpListenerBase
    {
        //Tell Service Stack the name of your application and where to find your web services
        public WineCellarAppHost() : base("Wine Cellar Service", typeof(WineCollectionHandler).Assembly)
        { }

        public override void Configure(Container container)
        {
            //register user-defined REST-ful urls
            Routes
              .Add<List<Wine>>("/wines")
              .Add<List<Wine>>("/wines/search/{query}")
              .Add<Wine>("/wines/{id}");

            container.Register<IWineProvider>(new WineProvider());

            Plugins.Add(new CorsFeature());
        }
    }
}
