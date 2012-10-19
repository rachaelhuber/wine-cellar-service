namespace WineCellerService
{
    using ServiceStack.ServiceInterface;

    public class WineHandler : RestServiceBase<Wine>
    {
        private readonly IWineProvider provider;

        public WineHandler(IWineProvider provider)
        {
            // TODO check for not null here
            this.provider = provider;
        }

        public override object OnGet(string id)
        {
            return this.provider.FindById(id);
        }
    }
}
