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
        public CardModel.Datum GetCard (string nome)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/named?fuzzy={nome.ToLower()}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return new JsonDeserializer().Deserialize<CardModel.Datum>(response);
        }

        public CardModel.Root GetByEffect (string text)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q=o:{text.ToLower()}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }

        public CardModel.Root GetByColor (string parametro)
        {
            var client = new RestClient($"https://api.scryfall.com/cards/search?order=rarity&q={parametro.ToLower()}");
            var request = new RestRequest (Method.GET);
            IRestResponse response = client.Execute(request);
            return new JsonDeserializer().Deserialize<CardModel.Root>(response);
        }
    }
}
