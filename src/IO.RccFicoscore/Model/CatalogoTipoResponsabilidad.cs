using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using ApihubDateConverter = IO.RccFicoscore.Client.ApihubDateConverter;

namespace IO.RccFicoscore.Model
{
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CatalogoTipoResponsabilidad
    {
        [EnumMember(Value = "I")]
        I = 1,
        [EnumMember(Value = "M")]
        M = 2,
        [EnumMember(Value = "O")]
        O = 3,
        [EnumMember(Value = "A")]
        A = 4,
        [EnumMember(Value = "T")]
        T = 5
    }
}
