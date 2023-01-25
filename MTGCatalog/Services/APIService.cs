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
        public async Task<CardModel.Root> GetCardAsync (string nome)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q={nome}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByEffectAsync (string text)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q=o:{text}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByColorAsync (string parametro)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q={parametro}");
            var request = new RestRequest (Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByTypeAsync (string tipo)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q=t:{tipo}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByStatusAsync (string parametro)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q={parametro}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public async Task<CardModel.Root> GetByAdvancedAsync (string parametro)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q={parametro}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }
    }
}
