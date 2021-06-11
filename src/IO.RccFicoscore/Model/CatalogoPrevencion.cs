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
    
    public enum CatalogoPrevencion
    {
        [EnumMember(Value = "AD")]
        AD = 1,
        [EnumMember(Value = "CA")]
        CA = 2,
        [EnumMember(Value = "CC")]
        CC = 3,
        [EnumMember(Value = "CD")]
        CD = 4,
        [EnumMember(Value = "CL")]
        CL = 5,
        [EnumMember(Value = "CO")]
        CO = 6,
        [EnumMember(Value = "CV")]
        CV = 7,
        [EnumMember(Value = "FD")]
        FD = 8,
        [EnumMember(Value = "FN")]
        FN = 9,
        [EnumMember(Value = "FP")]
        FP = 10,
        [EnumMember(Value = "FR")]
        FR = 11,
        [EnumMember(Value = "GP")]
        GP = 12,
        [EnumMember(Value = "IA")]
        IA = 13,
        [EnumMember(Value = "IM")]
        IM = 14,
        [EnumMember(Value = "IS")]
        IS = 15,
        [EnumMember(Value = "LC")]
        LC = 16,
        [EnumMember(Value = "LG")]
        LG = 17,
        [EnumMember(Value = "LO")]
        LO = 18,
        [EnumMember(Value = "LS")]
        LS = 19,
        [EnumMember(Value = "NA")]
        NA = 20,
        [EnumMember(Value = "NV")]
        NV = 21,
        [EnumMember(Value = "PC")]
        PC = 22,
        [EnumMember(Value = "PD")]
        PD = 23,
        [EnumMember(Value = "PE")]
        PE = 24,
        [EnumMember(Value = "PI")]
        PI = 25,
        [EnumMember(Value = "PR")]
        PR = 26,
        [EnumMember(Value = "RA")]
        RA = 27,
        [EnumMember(Value = "RI")]
        RI = 28,
        [EnumMember(Value = "RF")]
        RF = 29,
        [EnumMember(Value = "RN")]
        RN = 30,
        [EnumMember(Value = "RV")]
        RV = 31,
        [EnumMember(Value = "SG")]
        SG = 32,
        [EnumMember(Value = "UP")]
        UP = 33,
        [EnumMember(Value = "VR")]
        VR = 34
    }
}
