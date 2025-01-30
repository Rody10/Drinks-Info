using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Drinks_Info
{
    public record class Drinks(
       [property: JsonPropertyName("drinks")] List<Drink> DrinksList);
}
