using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MTGCatalog.Services
{
    internal class CompareAndTypes
    {
        public class Cores
        {
            public Cores(string corUrl, string corDisplay)
            {
                this.corUrl = corUrl;
                this.corDisplay = corDisplay;
            }

            public string corUrl { get; set; }
            public string corDisplay { get; set; }
        }
        public List<Cores> ShowColors()
        {
            List<Cores> colors = new List<Cores>
        {
            new Cores ("w","Branco"),
            new Cores ("u","Azul"),
            new Cores ("b","Preto"),
            new Cores ("r","Vermelho"),
            new Cores ("g","Verde"),
            new Cores ("c","Incolor")

        };
            return colors;
        }

        public class Compare
        {
            public Compare(string compareUrl, string compareDisplay)
            {
                this.compareUrl = compareUrl;
                this.compareDisplay = compareDisplay;
            }

            public string compareUrl { get; set; }
            public string compareDisplay { get; set; }
        }
        public List<Compare> ShowCompare()
        {
            List<Compare> compare = new List<Compare>
        {
            new Compare ("=","Igual a"),
            new Compare ("!=","Diferente de"),
            new Compare (">=","Maior/igual a"),
            new Compare (">", "Maior que"),
            new Compare ("<=","Menor/igual a"),
            new Compare ("<", "Menor que")
        };
            return compare;

        }

        public class ColorIndic
        {
            public ColorIndic(string colorIndicUrl, string colorIndicDisplay)
            {
                this.colorIndicUrl = colorIndicUrl;
                this.colorIndicDisplay = colorIndicDisplay;
            }

            public string colorIndicUrl { get; set; }
            public string colorIndicDisplay { get; set; }
        }
        public List<ColorIndic> ShowColorIndic()
        {
            List<ColorIndic> indic = new List<ColorIndic>
        {
            new ColorIndic ("=","Só essas cores"),
            new ColorIndic (":","Com essas cores"),
            new ColorIndic ("<=","Em sua maioria")
        };
            return indic;
        }

        public class Types
        {
            public Types(string typeUrl, string typeDisplay)
            {
                this.typeUrl = typeUrl;
                this.typeDisplay = typeDisplay;
            }

            public string typeUrl { get; set; }
            public string typeDisplay { get; set; }
        }
        public List<Types> ShowTypes()
        {
            List<Types> types = new List<Types>
        {
            new Types("",""),
        };
            return types;
        }

    }
}