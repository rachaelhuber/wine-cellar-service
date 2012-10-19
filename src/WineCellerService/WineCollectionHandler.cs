namespace WineCellerService
{
    using System.Collections.Generic;
    using ServiceStack.ServiceInterface;

    public class WineCollectionHandler : RestServiceBase<>
    {
        private readonly IWineProvider provider;

        public WineCollectionHandler(IWineProvider provider)
        {
            // TODO check for not null provider  here
            this.provider = provider;
        }

        public override object OnGet()
        {
            return this.provider.FindAll();
        }

        public override object OnGet(string query)
        {
            return this.provider.FindByName(query);
        }
    }
}
