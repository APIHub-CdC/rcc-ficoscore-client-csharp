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
    
    public enum CatalogoMoneda
    {
        [EnumMember(Value = "MX")]
        MX = 1,
        [EnumMember(Value = "US")]
        US = 2,
        [EnumMember(Value = "UD")]
        UD = 3
    }
}
