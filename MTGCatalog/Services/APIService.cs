using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGCatalog.Services
{
    internal class APIService
    {
        public async Task<CardModel.Datum> GetCardAsync (string nome)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/named?fuzzy={nome.ToLower()}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Datum>(response);
        }

        public async Task<CardModel.Root> GetByEffectAsync (string text)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q=o:{text.ToLower()}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByColorAsync (string parametro)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q={parametro.ToLower()}");
            var request = new RestRequest (Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByTypeAsync (string tipo)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q=t:{tipo.ToLower()}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }
    }
}
