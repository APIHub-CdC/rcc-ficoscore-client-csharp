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
    public partial class Autenticacion :  IEquatable<Autenticacion>, IValidatableObject
    {
        public Autenticacion(string numeroAutenticacion = default(string), string numeroSolicitud = default(string), bool? estatusAutenticacion = default(bool?))
        {
            this.NumeroAutenticacion = numeroAutenticacion;
            this.NumeroSolicitud = numeroSolicitud;
            this.EstatusAutenticacion = estatusAutenticacion;
        }
        [DataMember(Name="numeroAutenticacion", EmitDefaultValue=false)]
        public string NumeroAutenticacion { get; set; }
        [DataMember(Name="numeroSolicitud", EmitDefaultValue=false)]
        public string NumeroSolicitud { get; set; }
        [DataMember(Name="estatusAutenticacion", EmitDefaultValue=false)]
        public bool? EstatusAutenticacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Autenticacion {\n");
            sb.Append("  NumeroAutenticacion: ").Append(NumeroAutenticacion).Append("\n");
            sb.Append("  NumeroSolicitud: ").Append(NumeroSolicitud).Append("\n");
            sb.Append("  EstatusAutenticacion: ").Append(EstatusAutenticacion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Autenticacion);
        }
        public bool Equals(Autenticacion input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NumeroAutenticacion == input.NumeroAutenticacion ||
                    (this.NumeroAutenticacion != null &&
                    this.NumeroAutenticacion.Equals(input.NumeroAutenticacion))
                ) && 
                (
                    this.NumeroSolicitud == input.NumeroSolicitud ||
                    (this.NumeroSolicitud != null &&
                    this.NumeroSolicitud.Equals(input.NumeroSolicitud))
                ) && 
                (
                    this.EstatusAutenticacion == input.EstatusAutenticacion ||
                    (this.EstatusAutenticacion != null &&
                    this.EstatusAutenticacion.Equals(input.EstatusAutenticacion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NumeroAutenticacion != null)
                    hashCode = hashCode * 59 + this.NumeroAutenticacion.GetHashCode();
                if (this.NumeroSolicitud != null)
                    hashCode = hashCode * 59 + this.NumeroSolicitud.GetHashCode();
                if (this.EstatusAutenticacion != null)
                    hashCode = hashCode * 59 + this.EstatusAutenticacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.NumeroAutenticacion != null && this.NumeroAutenticacion.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroAutenticacion, length must be less than 10.", new [] { "NumeroAutenticacion" });
            }
            if(this.NumeroSolicitud != null && this.NumeroSolicitud.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroSolicitud, length must be less than 25.", new [] { "NumeroSolicitud" });
            }
            yield break;
        }
    }
}
