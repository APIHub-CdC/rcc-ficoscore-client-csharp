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
    
    public enum CatalogoFrecuenciaPago
    {
        [EnumMember(Value = "A")]
        A = 1,
        [EnumMember(Value = "B")]
        B = 2,
        [EnumMember(Value = "C")]
        C = 3,
        [EnumMember(Value = "D")]
        D = 4,
        [EnumMember(Value = "E")]
        E = 5,
        [EnumMember(Value = "M")]
        M = 6,
        [EnumMember(Value = "Q")]
        Q = 7,
        [EnumMember(Value = "R")]
        R = 8,
        [EnumMember(Value = "S")]
        S = 9,
        [EnumMember(Value = "T")]
        T = 10,
        [EnumMember(Value = "U")]
        U = 11
    }
}
