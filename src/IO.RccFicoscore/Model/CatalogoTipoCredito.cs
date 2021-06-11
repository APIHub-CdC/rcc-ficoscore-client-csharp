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
    
    public enum CatalogoTipoCredito
    {
        [EnumMember(Value = "AA")]
        AA = 1,
        [EnumMember(Value = "AB")]
        AB = 2,
        [EnumMember(Value = "AE")]
        AE = 3,
        [EnumMember(Value = "AM")]
        AM = 4,
        [EnumMember(Value = "AR")]
        AR = 5,
        [EnumMember(Value = "AV")]
        AV = 6,
        [EnumMember(Value = "BC")]
        BC = 7,
        [EnumMember(Value = "BL")]
        BL = 8,
        [EnumMember(Value = "BR")]
        BR = 9,
        [EnumMember(Value = "CA")]
        CA = 10,
        [EnumMember(Value = "CC")]
        CC = 11,
        [EnumMember(Value = "CF")]
        CF = 12,
        [EnumMember(Value = "CO")]
        CO = 13,
        [EnumMember(Value = "CP")]
        CP = 14,
        [EnumMember(Value = "ED")]
        ED = 15,
        [EnumMember(Value = "EQ")]
        EQ = 16,
        [EnumMember(Value = "FF")]
        FF = 17,
        [EnumMember(Value = "FI")]
        FI = 18,
        [EnumMember(Value = "FT")]
        FT = 19,
        [EnumMember(Value = "GS")]
        GS = 20,
        [EnumMember(Value = "HB")]
        HB = 21,
        [EnumMember(Value = "HE")]
        HE = 22,
        [EnumMember(Value = "HV")]
        HV = 23,
        [EnumMember(Value = "LC")]
        LC = 24,
        [EnumMember(Value = "MC")]
        MC = 25,
        [EnumMember(Value = "NG")]
        NG = 26,
        [EnumMember(Value = "PB")]
        PB = 27,
        [EnumMember(Value = "PC")]
        PC = 28,
        [EnumMember(Value = "PE")]
        PE = 29,
        [EnumMember(Value = "PG")]
        PG = 30,
        [EnumMember(Value = "PQ")]
        PQ = 31,
        [EnumMember(Value = "PM")]
        PM = 32,
        [EnumMember(Value = "PN")]
        PN = 33,
        [EnumMember(Value = "PP")]
        PP = 34,
        [EnumMember(Value = "SH")]
        SH = 35,
        [EnumMember(Value = "TC")]
        TC = 36,
        [EnumMember(Value = "TD")]
        TD = 37,
        [EnumMember(Value = "TG")]
        TG = 38,
        [EnumMember(Value = "TS")]
        TS = 39,
        [EnumMember(Value = "VR")]
        VR = 40,
        [EnumMember(Value = "OT")]
        OT = 41,
        [EnumMember(Value = "NC")]
        NC = 42
    }
}
