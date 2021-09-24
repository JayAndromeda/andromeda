using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda
{
    class Items
    {
        [JsonProperty("Items")]
        public MagicItem[] magicItems {  get; set; }
    }
}
