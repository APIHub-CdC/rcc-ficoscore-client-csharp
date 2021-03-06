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
    
    public enum CatalogoRazones
    {
        [EnumMember(Value = "A0")]
        A0 = 1,
        [EnumMember(Value = "A1")]
        A1 = 2,
        [EnumMember(Value = "A2")]
        A2 = 3,
        [EnumMember(Value = "A3")]
        A3 = 4,
        [EnumMember(Value = "A4")]
        A4 = 5,
        [EnumMember(Value = "A5")]
        A5 = 6,
        [EnumMember(Value = "A6")]
        A6 = 7,
        [EnumMember(Value = "A7")]
        A7 = 8,
        [EnumMember(Value = "A8")]
        A8 = 9,
        [EnumMember(Value = "A9")]
        A9 = 10,
        [EnumMember(Value = "B0")]
        B0 = 11,
        [EnumMember(Value = "B1")]
        B1 = 12,
        [EnumMember(Value = "B2")]
        B2 = 13,
        [EnumMember(Value = "B3")]
        B3 = 14,
        [EnumMember(Value = "B4")]
        B4 = 15,
        [EnumMember(Value = "B5")]
        B5 = 16,
        [EnumMember(Value = "B6")]
        B6 = 17,
        [EnumMember(Value = "D0")]
        D0 = 18,
        [EnumMember(Value = "D1")]
        D1 = 19,
        [EnumMember(Value = "D2")]
        D2 = 20,
        [EnumMember(Value = "D3")]
        D3 = 21,
        [EnumMember(Value = "D4")]
        D4 = 22,
        [EnumMember(Value = "D5")]
        D5 = 23,
        [EnumMember(Value = "D6")]
        D6 = 24,
        [EnumMember(Value = "D7")]
        D7 = 25,
        [EnumMember(Value = "D8")]
        D8 = 26,
        [EnumMember(Value = "D9")]
        D9 = 27,
        [EnumMember(Value = "E0")]
        E0 = 28,
        [EnumMember(Value = "E1")]
        E1 = 29,
        [EnumMember(Value = "E2")]
        E2 = 30,
        [EnumMember(Value = "E3")]
        E3 = 31,
        [EnumMember(Value = "E4")]
        E4 = 32,
        [EnumMember(Value = "E5")]
        E5 = 33,
        [EnumMember(Value = "E6")]
        E6 = 34,
        [EnumMember(Value = "F0")]
        F0 = 35,
        [EnumMember(Value = "F1")]
        F1 = 36,
        [EnumMember(Value = "F2")]
        F2 = 37,
        [EnumMember(Value = "F3")]
        F3 = 38,
        [EnumMember(Value = "F4")]
        F4 = 39,
        [EnumMember(Value = "F5")]
        F5 = 40,
        [EnumMember(Value = "F6")]
        F6 = 41,
        [EnumMember(Value = "F7")]
        F7 = 42,
        [EnumMember(Value = "F8")]
        F8 = 43,
        [EnumMember(Value = "F9")]
        F9 = 44,
        [EnumMember(Value = "G0")]
        G0 = 45,
        [EnumMember(Value = "G1")]
        G1 = 46,
        [EnumMember(Value = "G2")]
        G2 = 47,
        [EnumMember(Value = "G3")]
        G3 = 48,
        [EnumMember(Value = "G4")]
        G4 = 49,
        [EnumMember(Value = "G5")]
        G5 = 50,
        [EnumMember(Value = "G6")]
        G6 = 51,
        [EnumMember(Value = "J0")]
        J0 = 52,
        [EnumMember(Value = "J1")]
        J1 = 53,
        [EnumMember(Value = "J2")]
        J2 = 54,
        [EnumMember(Value = "J3")]
        J3 = 55,
        [EnumMember(Value = "J4")]
        J4 = 56,
        [EnumMember(Value = "J5")]
        J5 = 57,
        [EnumMember(Value = "J6")]
        J6 = 58,
        [EnumMember(Value = "J7")]
        J7 = 59,
        [EnumMember(Value = "J8")]
        J8 = 60,
        [EnumMember(Value = "J9")]
        J9 = 61,
        [EnumMember(Value = "K0")]
        K0 = 62,
        [EnumMember(Value = "K1")]
        K1 = 63,
        [EnumMember(Value = "K2")]
        K2 = 64,
        [EnumMember(Value = "K3")]
        K3 = 65,
        [EnumMember(Value = "K4")]
        K4 = 66,
        [EnumMember(Value = "K5")]
        K5 = 67,
        [EnumMember(Value = "K6")]
        K6 = 68,
        [EnumMember(Value = "K7")]
        K7 = 69,
        [EnumMember(Value = "K8")]
        K8 = 70,
        [EnumMember(Value = "K9")]
        K9 = 71,
        [EnumMember(Value = "M0")]
        M0 = 72,
        [EnumMember(Value = "M1")]
        M1 = 73,
        [EnumMember(Value = "M2")]
        M2 = 74,
        [EnumMember(Value = "M3")]
        M3 = 75,
        [EnumMember(Value = "M4")]
        M4 = 76,
        [EnumMember(Value = "M5")]
        M5 = 77,
        [EnumMember(Value = "M6")]
        M6 = 78,
        [EnumMember(Value = "M7")]
        M7 = 79,
        [EnumMember(Value = "M8")]
        M8 = 80,
        [EnumMember(Value = "M9")]
        M9 = 81,
        [EnumMember(Value = "N0")]
        N0 = 82,
        [EnumMember(Value = "N1")]
        N1 = 83,
        [EnumMember(Value = "N2")]
        N2 = 84,
        [EnumMember(Value = "N3")]
        N3 = 85,
        [EnumMember(Value = "N4")]
        N4 = 86,
        [EnumMember(Value = "N5")]
        N5 = 87,
        [EnumMember(Value = "N6")]
        N6 = 88,
        [EnumMember(Value = "N7")]
        N7 = 89,
        [EnumMember(Value = "N8")]
        N8 = 90,
        [EnumMember(Value = "P0")]
        P0 = 91,
        [EnumMember(Value = "P1")]
        P1 = 92,
        [EnumMember(Value = "P2")]
        P2 = 93,
        [EnumMember(Value = "P3")]
        P3 = 94,
        [EnumMember(Value = "P5")]
        P5 = 95,
        [EnumMember(Value = "P6")]
        P6 = 96,
        [EnumMember(Value = "P7")]
        P7 = 97,
        [EnumMember(Value = "P8")]
        P8 = 98,
        [EnumMember(Value = "P9")]
        P9 = 99,
        [EnumMember(Value = "Q0")]
        Q0 = 100,
        [EnumMember(Value = "Q1")]
        Q1 = 101,
        [EnumMember(Value = "R0")]
        R0 = 102,
        [EnumMember(Value = "R1")]
        R1 = 103,
        [EnumMember(Value = "R2")]
        R2 = 104,
        [EnumMember(Value = "R3")]
        R3 = 105,
        [EnumMember(Value = "R4")]
        R4 = 106,
        [EnumMember(Value = "R5")]
        R5 = 107,
        [EnumMember(Value = "R6")]
        R6 = 108,
        [EnumMember(Value = "R7")]
        R7 = 109,
        [EnumMember(Value = "R9")]
        R9 = 110,
        [EnumMember(Value = "S0")]
        S0 = 111,
        [EnumMember(Value = "S1")]
        S1 = 112,
        [EnumMember(Value = "S2")]
        S2 = 113,
        [EnumMember(Value = "T0")]
        T0 = 114,
        [EnumMember(Value = "T1")]
        T1 = 115,
        [EnumMember(Value = "T2")]
        T2 = 116,
        [EnumMember(Value = "T3")]
        T3 = 117,
        [EnumMember(Value = "T4")]
        T4 = 118,
        [EnumMember(Value = "T5")]
        T5 = 119,
        [EnumMember(Value = "T6")]
        T6 = 120,
        [EnumMember(Value = "T7")]
        T7 = 121,
        [EnumMember(Value = "T8")]
        T8 = 122,
        [EnumMember(Value = "T9")]
        T9 = 123,
        [EnumMember(Value = "U0")]
        U0 = 124,
        [EnumMember(Value = "U1")]
        U1 = 125,
        [EnumMember(Value = "U2")]
        U2 = 126,
        [EnumMember(Value = "U4")]
        U4 = 127,
        [EnumMember(Value = "U5")]
        U5 = 128,
        [EnumMember(Value = "U6")]
        U6 = 129,
        [EnumMember(Value = "U7")]
        U7 = 130,
        [EnumMember(Value = "U8")]
        U8 = 131,
        [EnumMember(Value = "U9")]
        U9 = 132,
        [EnumMember(Value = "V0")]
        V0 = 133,
        [EnumMember(Value = "V1")]
        V1 = 134,
        [EnumMember(Value = "V3")]
        V3 = 135,
        [EnumMember(Value = "V4")]
        V4 = 136,
        [EnumMember(Value = "W3")]
        W3 = 137,
        [EnumMember(Value = "W4")]
        W4 = 138,
        [EnumMember(Value = "W5")]
        W5 = 139,
        [EnumMember(Value = "W6")]
        W6 = 140,
        [EnumMember(Value = "W7")]
        W7 = 141,
        [EnumMember(Value = "W9")]
        W9 = 142,
        [EnumMember(Value = "X0")]
        X0 = 143,
        [EnumMember(Value = "C1")]
        C1 = 144,
        [EnumMember(Value = "C2")]
        C2 = 145,
        [EnumMember(Value = "C3")]
        C3 = 146,
        [EnumMember(Value = "C4")]
        C4 = 147,
        [EnumMember(Value = "C5")]
        C5 = 148,
        [EnumMember(Value = "SC")]
        SC = 149
    }
}
