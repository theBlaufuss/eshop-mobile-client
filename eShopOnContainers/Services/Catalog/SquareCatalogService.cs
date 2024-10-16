using eShopOnContainers.Models.Catalog;
using Square;
using Square.Apis;
using Square.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Services.Catalog
{
    class SquareCatalogService : ICatalogService
    {
        SquareClient client;
        public SquareCatalogService(SquareClient _client)
        {
            client = _client;
        }

        public Task<IEnumerable<CatalogItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogItem>> GetCatalogAsync()
        {

           

            ICatalogApi catalogapi = client.CatalogApi;

            return null;
        }

        public Task<IEnumerable<CatalogBrand>> GetCatalogBrandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CatalogType>> GetCatalogTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
