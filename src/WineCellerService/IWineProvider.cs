namespace WineCellerService
{
    using System.Collections.Generic;

    public interface IWineProvider
    {
        List<Wine> FindAll();

        List<Wine> FindByName(string query);

        Wine FindById(string id);
    }
}
