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
    public partial class Consulta :  IEquatable<Consulta>, IValidatableObject
    {
        [DataMember(Name="claveUnidadMonetaria", EmitDefaultValue=false)]
        public CatalogoMoneda? ClaveUnidadMonetaria { get; set; }
        [DataMember(Name="tipoResponsabilidad", EmitDefaultValue=false)]
        public CatalogoTipoResponsabilidad? TipoResponsabilidad { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiciosEnum
        {
            [EnumMember(Value = "0")]
            _0 = 1,
            [EnumMember(Value = "1")]
            _1 = 2
        }
        [DataMember(Name="servicios", EmitDefaultValue=false)]
        public ServiciosEnum? Servicios { get; set; }
        public Consulta(string fechaConsulta = default(string), string claveOtorgante = default(string), string nombreOtorgante = default(string), string direccionOtorgante = default(string), string telefonoOtorgante = default(string), string tipoCredito = default(string), CatalogoMoneda? claveUnidadMonetaria = default(CatalogoMoneda?), float? importeCredito = default(float?), CatalogoTipoResponsabilidad? tipoResponsabilidad = default(CatalogoTipoResponsabilidad?), string idDomicilio = default(string), ServiciosEnum? servicios = default(ServiciosEnum?))
        {
            this.FechaConsulta = fechaConsulta;
            this.ClaveOtorgante = claveOtorgante;
            this.NombreOtorgante = nombreOtorgante;
            this.DireccionOtorgante = direccionOtorgante;
            this.TelefonoOtorgante = telefonoOtorgante;
            this.TipoCredito = tipoCredito;
            this.ClaveUnidadMonetaria = claveUnidadMonetaria;
            this.ImporteCredito = importeCredito;
            this.TipoResponsabilidad = tipoResponsabilidad;
            this.IdDomicilio = idDomicilio;
            this.Servicios = servicios;
        }
        [DataMember(Name="fechaConsulta", EmitDefaultValue=false)]
        public string FechaConsulta { get; set; }
        [DataMember(Name="claveOtorgante", EmitDefaultValue=false)]
        public string ClaveOtorgante { get; set; }
        [DataMember(Name="nombreOtorgante", EmitDefaultValue=false)]
        public string NombreOtorgante { get; set; }
        [DataMember(Name="direccionOtorgante", EmitDefaultValue=false)]
        public string DireccionOtorgante { get; set; }
        [DataMember(Name="telefonoOtorgante", EmitDefaultValue=false)]
        public string TelefonoOtorgante { get; set; }
        [DataMember(Name="tipoCredito", EmitDefaultValue=false)]
        public string TipoCredito { get; set; }
        [DataMember(Name="importeCredito", EmitDefaultValue=false)]
        public float? ImporteCredito { get; set; }
        [DataMember(Name="idDomicilio", EmitDefaultValue=false)]
        public string IdDomicilio { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Consulta {\n");
            sb.Append("  FechaConsulta: ").Append(FechaConsulta).Append("\n");
            sb.Append("  ClaveOtorgante: ").Append(ClaveOtorgante).Append("\n");
            sb.Append("  NombreOtorgante: ").Append(NombreOtorgante).Append("\n");
            sb.Append("  DireccionOtorgante: ").Append(DireccionOtorgante).Append("\n");
            sb.Append("  TelefonoOtorgante: ").Append(TelefonoOtorgante).Append("\n");
            sb.Append("  TipoCredito: ").Append(TipoCredito).Append("\n");
            sb.Append("  ClaveUnidadMonetaria: ").Append(ClaveUnidadMonetaria).Append("\n");
            sb.Append("  ImporteCredito: ").Append(ImporteCredito).Append("\n");
            sb.Append("  TipoResponsabilidad: ").Append(TipoResponsabilidad).Append("\n");
            sb.Append("  IdDomicilio: ").Append(IdDomicilio).Append("\n");
            sb.Append("  Servicios: ").Append(Servicios).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Consulta);
        }
        public bool Equals(Consulta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FechaConsulta == input.FechaConsulta ||
                    (this.FechaConsulta != null &&
                    this.FechaConsulta.Equals(input.FechaConsulta))
                ) && 
                (
                    this.ClaveOtorgante == input.ClaveOtorgante ||
                    (this.ClaveOtorgante != null &&
                    this.ClaveOtorgante.Equals(input.ClaveOtorgante))
                ) && 
                (
                    this.NombreOtorgante == input.NombreOtorgante ||
                    (this.NombreOtorgante != null &&
                    this.NombreOtorgante.Equals(input.NombreOtorgante))
                ) && 
                (
                    this.DireccionOtorgante == input.DireccionOtorgante ||
                    (this.DireccionOtorgante != null &&
                    this.DireccionOtorgante.Equals(input.DireccionOtorgante))
                ) && 
                (
                    this.TelefonoOtorgante == input.TelefonoOtorgante ||
                    (this.TelefonoOtorgante != null &&
                    this.TelefonoOtorgante.Equals(input.TelefonoOtorgante))
                ) && 
                (
                    this.TipoCredito == input.TipoCredito ||
                    (this.TipoCredito != null &&
                    this.TipoCredito.Equals(input.TipoCredito))
                ) && 
                (
                    this.ClaveUnidadMonetaria == input.ClaveUnidadMonetaria ||
                    (this.ClaveUnidadMonetaria != null &&
                    this.ClaveUnidadMonetaria.Equals(input.ClaveUnidadMonetaria))
                ) && 
                (
                    this.ImporteCredito == input.ImporteCredito ||
                    (this.ImporteCredito != null &&
                    this.ImporteCredito.Equals(input.ImporteCredito))
                ) && 
                (
                    this.TipoResponsabilidad == input.TipoResponsabilidad ||
                    (this.TipoResponsabilidad != null &&
                    this.TipoResponsabilidad.Equals(input.TipoResponsabilidad))
                ) && 
                (
                    this.IdDomicilio == input.IdDomicilio ||
                    (this.IdDomicilio != null &&
                    this.IdDomicilio.Equals(input.IdDomicilio))
                ) && 
                (
                    this.Servicios == input.Servicios ||
                    (this.Servicios != null &&
                    this.Servicios.Equals(input.Servicios))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FechaConsulta != null)
                    hashCode = hashCode * 59 + this.FechaConsulta.GetHashCode();
                if (this.ClaveOtorgante != null)
                    hashCode = hashCode * 59 + this.ClaveOtorgante.GetHashCode();
                if (this.NombreOtorgante != null)
                    hashCode = hashCode * 59 + this.NombreOtorgante.GetHashCode();
                if (this.DireccionOtorgante != null)
                    hashCode = hashCode * 59 + this.DireccionOtorgante.GetHashCode();
                if (this.TelefonoOtorgante != null)
                    hashCode = hashCode * 59 + this.TelefonoOtorgante.GetHashCode();
                if (this.TipoCredito != null)
                    hashCode = hashCode * 59 + this.TipoCredito.GetHashCode();
                if (this.ClaveUnidadMonetaria != null)
                    hashCode = hashCode * 59 + this.ClaveUnidadMonetaria.GetHashCode();
                if (this.ImporteCredito != null)
                    hashCode = hashCode * 59 + this.ImporteCredito.GetHashCode();
                if (this.TipoResponsabilidad != null)
                    hashCode = hashCode * 59 + this.TipoResponsabilidad.GetHashCode();
                if (this.IdDomicilio != null)
                    hashCode = hashCode * 59 + this.IdDomicilio.GetHashCode();
                if (this.Servicios != null)
                    hashCode = hashCode * 59 + this.Servicios.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
          
            yield break;
        }
    }
}
