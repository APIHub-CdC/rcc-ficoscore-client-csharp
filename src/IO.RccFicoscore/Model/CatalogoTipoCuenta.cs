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
    
    public enum CatalogoTipoCuenta
    {
        [EnumMember(Value = "F")]
        F = 1,
        [EnumMember(Value = "H")]
        H = 2,
        [EnumMember(Value = "L")]
        L = 3,
        [EnumMember(Value = "R")]
        R = 4,
        [EnumMember(Value = "Q")]
        Q = 5,
        [EnumMember(Value = "A")]
        A = 6,
        [EnumMember(Value = "E")]
        E = 7,
        [EnumMember(Value = "P")]
        P = 8
    }
}
