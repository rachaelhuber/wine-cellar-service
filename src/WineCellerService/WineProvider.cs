using System;
namespace WineCellerService
{
    using System.Collections.Generic;
    using System.Linq;

    public class WineProvider : IWineProvider
    {
        private List<Wine> collection;

        public WineProvider()
        {
            this.collection = new List<Wine>();
            this.collection.Add(
                new Wine
                {
                    Name = "Adam",
                    Id = 1,
                    Country = "Polski",
                    Description = "Polish flavours",
                    Grapes = 4,
                    Picture = "morizottes.jpg",
                    Region = 1,
                    Year = "1972"
                });
            this.collection.Add(
                new Wine
                {
                    Name = "Rachael",
                    Id = 2,
                    Country = "Polski",
                    Description = "Polish flavours",
                    Grapes = 4,
                    Picture = "bodega_lurton.jpg",
                    Region = 1,
                    Year = "1972"
                });
            this.collection.Add(
                new Wine
                {
                    Name = "Cameron",
                    Id = 3,
                    Country = "Polski",
                    Description = "Polish flavours",
                    Grapes = 4,
                    Picture = "bouscat.jpg",
                    Region = 1,
                    Year = "1972"
                });
            this.collection.Add(
                new Wine
                {
                    Name = "Ez",
                    Id= 4,
                    Country = "Polski",
                    Description = "Polish flavours",
                    Grapes = 4,
                    Picture = "lan_rioja.jpg",
                    Region = 1,
                    Year = "1972"
                });
        }

        public List<Wine> FindAll()
        {
            return this.collection;
        }

        public List<Wine> FindByName(string query)
        {
            return this.collection.Where(x => string.Equals(x.Name, query, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Wine FindById(string id)
        {
            return this.collection.FirstOrDefault(x => x.Id == int.Parse(id));
        }
    }
}
