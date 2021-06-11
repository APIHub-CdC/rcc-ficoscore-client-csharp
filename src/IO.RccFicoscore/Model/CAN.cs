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
    public partial class CAN :  IEquatable<CAN>, IValidatableObject
    {
        public CAN(string identificadorCAN = default(string), int? prelacionOrigen = default(int?), int? prelacionActual = default(int?), string fechaAperturaCAN = default(string), string fechaCancelacionCAN = default(string), string historicoCAN = default(string), string fechaMRCAN = default(string), string fechaMACAN = default(string))
        {
            this.IdentificadorCAN = identificadorCAN;
            this.PrelacionOrigen = prelacionOrigen;
            this.PrelacionActual = prelacionActual;
            this.FechaAperturaCAN = fechaAperturaCAN;
            this.FechaCancelacionCAN = fechaCancelacionCAN;
            this.HistoricoCAN = historicoCAN;
            this.FechaMRCAN = fechaMRCAN;
            this.FechaMACAN = fechaMACAN;
        }
        [DataMember(Name="identificadorCAN", EmitDefaultValue=false)]
        public string IdentificadorCAN { get; set; }
        [DataMember(Name="prelacionOrigen", EmitDefaultValue=false)]
        public int? PrelacionOrigen { get; set; }
        [DataMember(Name="prelacionActual", EmitDefaultValue=false)]
        public int? PrelacionActual { get; set; }
        [DataMember(Name="fechaAperturaCAN", EmitDefaultValue=false)]
        public string FechaAperturaCAN { get; set; }
        [DataMember(Name="fechaCancelacionCAN", EmitDefaultValue=false)]
        public string FechaCancelacionCAN { get; set; }
        [DataMember(Name="historicoCAN", EmitDefaultValue=false)]
        public string HistoricoCAN { get; set; }
        [DataMember(Name="fechaMRCAN", EmitDefaultValue=false)]
        public string FechaMRCAN { get; set; }
        [DataMember(Name="fechaMACAN", EmitDefaultValue=false)]
        public string FechaMACAN { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CAN {\n");
            sb.Append("  IdentificadorCAN: ").Append(IdentificadorCAN).Append("\n");
            sb.Append("  PrelacionOrigen: ").Append(PrelacionOrigen).Append("\n");
            sb.Append("  PrelacionActual: ").Append(PrelacionActual).Append("\n");
            sb.Append("  FechaAperturaCAN: ").Append(FechaAperturaCAN).Append("\n");
            sb.Append("  FechaCancelacionCAN: ").Append(FechaCancelacionCAN).Append("\n");
            sb.Append("  HistoricoCAN: ").Append(HistoricoCAN).Append("\n");
            sb.Append("  FechaMRCAN: ").Append(FechaMRCAN).Append("\n");
            sb.Append("  FechaMACAN: ").Append(FechaMACAN).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as CAN);
        }
        public bool Equals(CAN input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.IdentificadorCAN == input.IdentificadorCAN ||
                    (this.IdentificadorCAN != null &&
                    this.IdentificadorCAN.Equals(input.IdentificadorCAN))
                ) && 
                (
                    this.PrelacionOrigen == input.PrelacionOrigen ||
                    (this.PrelacionOrigen != null &&
                    this.PrelacionOrigen.Equals(input.PrelacionOrigen))
                ) && 
                (
                    this.PrelacionActual == input.PrelacionActual ||
                    (this.PrelacionActual != null &&
                    this.PrelacionActual.Equals(input.PrelacionActual))
                ) && 
                (
                    this.FechaAperturaCAN == input.FechaAperturaCAN ||
                    (this.FechaAperturaCAN != null &&
                    this.FechaAperturaCAN.Equals(input.FechaAperturaCAN))
                ) && 
                (
                    this.FechaCancelacionCAN == input.FechaCancelacionCAN ||
                    (this.FechaCancelacionCAN != null &&
                    this.FechaCancelacionCAN.Equals(input.FechaCancelacionCAN))
                ) && 
                (
                    this.HistoricoCAN == input.HistoricoCAN ||
                    (this.HistoricoCAN != null &&
                    this.HistoricoCAN.Equals(input.HistoricoCAN))
                ) && 
                (
                    this.FechaMRCAN == input.FechaMRCAN ||
                    (this.FechaMRCAN != null &&
                    this.FechaMRCAN.Equals(input.FechaMRCAN))
                ) && 
                (
                    this.FechaMACAN == input.FechaMACAN ||
                    (this.FechaMACAN != null &&
                    this.FechaMACAN.Equals(input.FechaMACAN))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.IdentificadorCAN != null)
                    hashCode = hashCode * 59 + this.IdentificadorCAN.GetHashCode();
                if (this.PrelacionOrigen != null)
                    hashCode = hashCode * 59 + this.PrelacionOrigen.GetHashCode();
                if (this.PrelacionActual != null)
                    hashCode = hashCode * 59 + this.PrelacionActual.GetHashCode();
                if (this.FechaAperturaCAN != null)
                    hashCode = hashCode * 59 + this.FechaAperturaCAN.GetHashCode();
                if (this.FechaCancelacionCAN != null)
                    hashCode = hashCode * 59 + this.FechaCancelacionCAN.GetHashCode();
                if (this.HistoricoCAN != null)
                    hashCode = hashCode * 59 + this.HistoricoCAN.GetHashCode();
                if (this.FechaMRCAN != null)
                    hashCode = hashCode * 59 + this.FechaMRCAN.GetHashCode();
                if (this.FechaMACAN != null)
                    hashCode = hashCode * 59 + this.FechaMACAN.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
