using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MTGCatalog.Services
{
    internal class CardModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AllPart
        {
            public string @object { get; set; }
            public string id { get; set; }
            public string component { get; set; }
            public string name { get; set; }
            public string type_line { get; set; }
            public string uri { get; set; }
        }

        public class CardFace
        {
            public string @object { get; set; }
            public string name { get; set; }
            public string mana_cost { get; set; }
            public string type_line { get; set; }
            public string oracle_text { get; set; }
            public List<string> colors { get; set; }
            public string power { get; set; }
            public string toughness { get; set; }
            public string flavor_text { get; set; }
            public string artist { get; set; }
            public string artist_id { get; set; }
            public string illustration_id { get; set; }
            public ImageUris image_uris { get; set; }
            public string flavor_name { get; set; }
            public List<string> color_indicator { get; set; }
        }

        public class Datum
        {
            public string @object { get; set; }
            public string id { get; set; }
            public string oracle_id { get; set; }
            public List<int> multiverse_ids { get; set; }
            public int mtgo_id { get; set; }
            public int tcgplayer_id { get; set; }
            public int cardmarket_id { get; set; }
            public string name { get; set; }
            public string lang { get; set; }
            public string released_at { get; set; }
            public string uri { get; set; }
            public string scryfall_uri { get; set; }
            public string layout { get; set; }
            public bool highres_image { get; set; }
            public string image_status { get; set; }
            public ImageUris image_uris { get; set; }
            public string mana_cost { get; set; }
            public double cmc { get; set; }
            public string type_line { get; set; }
            public string oracle_text { get; set; }
            public string power { get; set; }
            public string toughness { get; set; }
            public List<string> colors { get; set; }
            public List<string> color_indicator { get; set; }
            public List<string> color_identity { get; set; }
            public List<string> keywords { get; set; }
            public List<AllPart> all_parts { get; set; }
            public Legalities legalities { get; set; }
            public List<string> games { get; set; }
            public bool reserved { get; set; }
            public bool foil { get; set; }
            public bool nonfoil { get; set; }
            public List<string> finishes { get; set; }
            public bool oversized { get; set; }
            public bool promo { get; set; }
            public bool reprint { get; set; }
            public bool variation { get; set; }

            [DeserializeAs(Name ="set_id")]
            public string set__id { get; set; }
            public string set { get; set; }
            [DeserializeAs(Name ="set_name")]
            public string set__name { get; set; }
            public string set_type { get; set; }
            [DeserializeAs(Name = "set_uri")]
            public string set__uri { get; set; }
            public string set_search_uri { get; set; }
            public string scryfall_set_uri { get; set; }
            public string rulings_uri { get; set; }
            public string prints_search_uri { get; set; }
            public string collector_number { get; set; }
            public bool digital { get; set; }
            public string rarity { get; set; }
            public string card_back_id { get; set; }
            public string artist { get; set; }
            public List<string> artist_ids { get; set; }
            public string illustration_id { get; set; }
            public string border_color { get; set; }
            public string frame { get; set; }
            public List<string> frame_effects { get; set; }
            public string security_stamp { get; set; }
            public bool full_art { get; set; }
            public bool textless { get; set; }
            public bool booster { get; set; }
            public bool story_spotlight { get; set; }
            public int edhrec_rank { get; set; }
            public Preview preview { get; set; }
            public Prices prices { get; set; }
            public RelatedUris related_uris { get; set; }
            public PurchaseUris purchase_uris { get; set; }
            public string flavor_text { get; set; }
            public int? penny_rank { get; set; }
            public int? mtgo_foil_id { get; set; }
            public List<CardFace> card_faces { get; set; }
            public int? arena_id { get; set; }
            public List<string> produced_mana { get; set; }
            public string watermark { get; set; }
        }

        public class ImageUris
        {
            public string small { get; set; }
            public string normal { get; set; }
            public string large { get; set; }
            public string png { get; set; }
            public string art_crop { get; set; }
            public string border_crop { get; set; }
        }

        public class Legalities
        {
            public string standard { get; set; }
            public string future { get; set; }
            public string historic { get; set; }
            public string gladiator { get; set; }
            public string pioneer { get; set; }
            public string explorer { get; set; }
            public string modern { get; set; }
            public string legacy { get; set; }
            public string pauper { get; set; }
            public string vintage { get; set; }
            public string penny { get; set; }
            public string commander { get; set; }
            public string brawl { get; set; }
            public string historicbrawl { get; set; }
            public string alchemy { get; set; }
            public string paupercommander { get; set; }
            public string duel { get; set; }
            public string oldschool { get; set; }
            public string premodern { get; set; }
        }

        public class Preview
        {
            public string source { get; set; }
            public string source_uri { get; set; }
            public string previewed_at { get; set; }
        }

        public class Prices
        {
            public string usd { get; set; }
            public string usd_foil { get; set; }
            public object usd_etched { get; set; }
            public string eur { get; set; }
            public string eur_foil { get; set; }
            public string tix { get; set; }
        }

        public class PurchaseUris
        {
            public string tcgplayer { get; set; }
            public string cardmarket { get; set; }
            public string cardhoarder { get; set; }
        }

        public class RelatedUris
        {
            public string gatherer { get; set; }
            public string tcgplayer_infinite_articles { get; set; }
            public string tcgplayer_infinite_decks { get; set; }
            public string edhrec { get; set; }
        }

        public class Root
        {
            public string @object { get; set; }
            public int total_cards { get; set; }
            public bool has_more { get; set; }
            public string next_page { get; set; }
            public List<Datum> data { get; set; }
        }
    }
}
