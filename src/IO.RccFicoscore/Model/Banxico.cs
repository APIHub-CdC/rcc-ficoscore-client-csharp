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
    [DataContract]
    public partial class Banxico :  IEquatable<Banxico>, IValidatableObject
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TarjetaDeCreditoEnum
        {
            [EnumMember(Value = "V")]
            V = 1,
            [EnumMember(Value = "F")]
            F = 2
        }
        [DataMember(Name="tarjetaDeCredito", EmitDefaultValue=false)]
        public TarjetaDeCreditoEnum? TarjetaDeCredito { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreditoHipotecarioEnum
        {
            [EnumMember(Value = "V")]
            V = 1,
            [EnumMember(Value = "F")]
            F = 2
        }
        [DataMember(Name="creditoHipotecario", EmitDefaultValue=false)]
        public CreditoHipotecarioEnum? CreditoHipotecario { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreditoAutomotrizEnum
        {
            [EnumMember(Value = "V")]
            V = 1,
            [EnumMember(Value = "F")]
            F = 2
        }
        [DataMember(Name="creditoAutomotriz", EmitDefaultValue=false)]
        public CreditoAutomotrizEnum? CreditoAutomotriz { get; set; }
        public Banxico(string numeroFirma = default(string), string numeroSolicitud = default(string), TarjetaDeCreditoEnum? tarjetaDeCredito = default(TarjetaDeCreditoEnum?), string numeroCuenta = default(string), CreditoHipotecarioEnum? creditoHipotecario = default(CreditoHipotecarioEnum?), CreditoAutomotrizEnum? creditoAutomotriz = default(CreditoAutomotrizEnum?))
        {
            this.NumeroFirma = numeroFirma;
            this.NumeroSolicitud = numeroSolicitud;
            this.TarjetaDeCredito = tarjetaDeCredito;
            this.NumeroCuenta = numeroCuenta;
            this.CreditoHipotecario = creditoHipotecario;
            this.CreditoAutomotriz = creditoAutomotriz;
        }
        [DataMember(Name="numeroFirma", EmitDefaultValue=false)]
        public string NumeroFirma { get; set; }
        [DataMember(Name="numeroSolicitud", EmitDefaultValue=false)]
        public string NumeroSolicitud { get; set; }
        [DataMember(Name="numeroCuenta", EmitDefaultValue=false)]
        public string NumeroCuenta { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Banxico {\n");
            sb.Append("  NumeroFirma: ").Append(NumeroFirma).Append("\n");
            sb.Append("  NumeroSolicitud: ").Append(NumeroSolicitud).Append("\n");
            sb.Append("  TarjetaDeCredito: ").Append(TarjetaDeCredito).Append("\n");
            sb.Append("  NumeroCuenta: ").Append(NumeroCuenta).Append("\n");
            sb.Append("  CreditoHipotecario: ").Append(CreditoHipotecario).Append("\n");
            sb.Append("  CreditoAutomotriz: ").Append(CreditoAutomotriz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Banxico);
        }
        public bool Equals(Banxico input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NumeroFirma == input.NumeroFirma ||
                    (this.NumeroFirma != null &&
                    this.NumeroFirma.Equals(input.NumeroFirma))
                ) && 
                (
                    this.NumeroSolicitud == input.NumeroSolicitud ||
                    (this.NumeroSolicitud != null &&
                    this.NumeroSolicitud.Equals(input.NumeroSolicitud))
                ) && 
                (
                    this.TarjetaDeCredito == input.TarjetaDeCredito ||
                    (this.TarjetaDeCredito != null &&
                    this.TarjetaDeCredito.Equals(input.TarjetaDeCredito))
                ) && 
                (
                    this.NumeroCuenta == input.NumeroCuenta ||
                    (this.NumeroCuenta != null &&
                    this.NumeroCuenta.Equals(input.NumeroCuenta))
                ) && 
                (
                    this.CreditoHipotecario == input.CreditoHipotecario ||
                    (this.CreditoHipotecario != null &&
                    this.CreditoHipotecario.Equals(input.CreditoHipotecario))
                ) && 
                (
                    this.CreditoAutomotriz == input.CreditoAutomotriz ||
                    (this.CreditoAutomotriz != null &&
                    this.CreditoAutomotriz.Equals(input.CreditoAutomotriz))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NumeroFirma != null)
                    hashCode = hashCode * 59 + this.NumeroFirma.GetHashCode();
                if (this.NumeroSolicitud != null)
                    hashCode = hashCode * 59 + this.NumeroSolicitud.GetHashCode();
                if (this.TarjetaDeCredito != null)
                    hashCode = hashCode * 59 + this.TarjetaDeCredito.GetHashCode();
                if (this.NumeroCuenta != null)
                    hashCode = hashCode * 59 + this.NumeroCuenta.GetHashCode();
                if (this.CreditoHipotecario != null)
                    hashCode = hashCode * 59 + this.CreditoHipotecario.GetHashCode();
                if (this.CreditoAutomotriz != null)
                    hashCode = hashCode * 59 + this.CreditoAutomotriz.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
           
            yield break;
        }
    }
}
