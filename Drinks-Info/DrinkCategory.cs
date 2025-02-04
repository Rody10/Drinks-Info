using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Drinks_Info
{
    public record class DrinkCategory(
        [property: JsonPropertyName("strCategory")] string Name);
}
