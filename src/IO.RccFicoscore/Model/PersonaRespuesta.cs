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
    public partial class PersonaRespuesta :  IEquatable<PersonaRespuesta>, IValidatableObject
    {
        [DataMember(Name="residencia", EmitDefaultValue=false)]
        public CatalogoResidencia? Residencia { get; set; }
        [DataMember(Name="estadoCivil", EmitDefaultValue=false)]
        public CatalogoEstadoCivil? EstadoCivil { get; set; }
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public CatalogoSexo? Sexo { get; set; }
        public PersonaRespuesta(string apellidoPaterno = default(string), string apellidoMaterno = default(string), string apellidoAdicional = default(string), string nombres = default(string), string fechaNacimiento = default(string), string rFC = default(string), string cURP = default(string), string numeroSeguridadSocial = default(string), string nacionalidad = default(string), CatalogoResidencia? residencia = default(CatalogoResidencia?), CatalogoEstadoCivil? estadoCivil = default(CatalogoEstadoCivil?), CatalogoSexo? sexo = default(CatalogoSexo?), string claveElectorIFE = default(string), int? numeroDependientes = default(int?), string fechaDefuncion = default(string))
        {
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.ApellidoAdicional = apellidoAdicional;
            this.Nombres = nombres;
            this.FechaNacimiento = fechaNacimiento;
            this.RFC = rFC;
            this.CURP = cURP;
            this.NumeroSeguridadSocial = numeroSeguridadSocial;
            this.Nacionalidad = nacionalidad;
            this.Residencia = residencia;
            this.EstadoCivil = estadoCivil;
            this.Sexo = sexo;
            this.ClaveElectorIFE = claveElectorIFE;
            this.NumeroDependientes = numeroDependientes;
            this.FechaDefuncion = fechaDefuncion;
        }
        [DataMember(Name="apellidoPaterno", EmitDefaultValue=false)]
        public string ApellidoPaterno { get; set; }
        [DataMember(Name="apellidoMaterno", EmitDefaultValue=false)]
        public string ApellidoMaterno { get; set; }
        [DataMember(Name="apellidoAdicional", EmitDefaultValue=false)]
        public string ApellidoAdicional { get; set; }
        [DataMember(Name="nombres", EmitDefaultValue=false)]
        public string Nombres { get; set; }
        [DataMember(Name="fechaNacimiento", EmitDefaultValue=false)]
        public string FechaNacimiento { get; set; }
        [DataMember(Name="RFC", EmitDefaultValue=false)]
        public string RFC { get; set; }
        [DataMember(Name="CURP", EmitDefaultValue=false)]
        public string CURP { get; set; }
        [DataMember(Name="numeroSeguridadSocial", EmitDefaultValue=false)]
        public string NumeroSeguridadSocial { get; set; }
        [DataMember(Name="nacionalidad", EmitDefaultValue=false)]
        public string Nacionalidad { get; set; }
        [DataMember(Name="claveElectorIFE", EmitDefaultValue=false)]
        public string ClaveElectorIFE { get; set; }
        [DataMember(Name="numeroDependientes", EmitDefaultValue=false)]
        public int? NumeroDependientes { get; set; }
        [DataMember(Name="fechaDefuncion", EmitDefaultValue=false)]
        public string FechaDefuncion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonaRespuesta {\n");
            sb.Append("  ApellidoPaterno: ").Append(ApellidoPaterno).Append("\n");
            sb.Append("  ApellidoMaterno: ").Append(ApellidoMaterno).Append("\n");
            sb.Append("  ApellidoAdicional: ").Append(ApellidoAdicional).Append("\n");
            sb.Append("  Nombres: ").Append(Nombres).Append("\n");
            sb.Append("  FechaNacimiento: ").Append(FechaNacimiento).Append("\n");
            sb.Append("  RFC: ").Append(RFC).Append("\n");
            sb.Append("  CURP: ").Append(CURP).Append("\n");
            sb.Append("  NumeroSeguridadSocial: ").Append(NumeroSeguridadSocial).Append("\n");
            sb.Append("  Nacionalidad: ").Append(Nacionalidad).Append("\n");
            sb.Append("  Residencia: ").Append(Residencia).Append("\n");
            sb.Append("  EstadoCivil: ").Append(EstadoCivil).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  ClaveElectorIFE: ").Append(ClaveElectorIFE).Append("\n");
            sb.Append("  NumeroDependientes: ").Append(NumeroDependientes).Append("\n");
            sb.Append("  FechaDefuncion: ").Append(FechaDefuncion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as PersonaRespuesta);
        }
        public bool Equals(PersonaRespuesta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.ApellidoPaterno == input.ApellidoPaterno ||
                    (this.ApellidoPaterno != null &&
                    this.ApellidoPaterno.Equals(input.ApellidoPaterno))
                ) && 
                (
                    this.ApellidoMaterno == input.ApellidoMaterno ||
                    (this.ApellidoMaterno != null &&
                    this.ApellidoMaterno.Equals(input.ApellidoMaterno))
                ) && 
                (
                    this.ApellidoAdicional == input.ApellidoAdicional ||
                    (this.ApellidoAdicional != null &&
                    this.ApellidoAdicional.Equals(input.ApellidoAdicional))
                ) && 
                (
                    this.Nombres == input.Nombres ||
                    (this.Nombres != null &&
                    this.Nombres.Equals(input.Nombres))
                ) && 
                (
                    this.FechaNacimiento == input.FechaNacimiento ||
                    (this.FechaNacimiento != null &&
                    this.FechaNacimiento.Equals(input.FechaNacimiento))
                ) && 
                (
                    this.RFC == input.RFC ||
                    (this.RFC != null &&
                    this.RFC.Equals(input.RFC))
                ) && 
                (
                    this.CURP == input.CURP ||
                    (this.CURP != null &&
                    this.CURP.Equals(input.CURP))
                ) && 
                (
                    this.NumeroSeguridadSocial == input.NumeroSeguridadSocial ||
                    (this.NumeroSeguridadSocial != null &&
                    this.NumeroSeguridadSocial.Equals(input.NumeroSeguridadSocial))
                ) && 
                (
                    this.Nacionalidad == input.Nacionalidad ||
                    (this.Nacionalidad != null &&
                    this.Nacionalidad.Equals(input.Nacionalidad))
                ) && 
                (
                    this.Residencia == input.Residencia ||
                    (this.Residencia != null &&
                    this.Residencia.Equals(input.Residencia))
                ) && 
                (
                    this.EstadoCivil == input.EstadoCivil ||
                    (this.EstadoCivil != null &&
                    this.EstadoCivil.Equals(input.EstadoCivil))
                ) && 
                (
                    this.Sexo == input.Sexo ||
                    (this.Sexo != null &&
                    this.Sexo.Equals(input.Sexo))
                ) && 
                (
                    this.ClaveElectorIFE == input.ClaveElectorIFE ||
                    (this.ClaveElectorIFE != null &&
                    this.ClaveElectorIFE.Equals(input.ClaveElectorIFE))
                ) && 
                (
                    this.NumeroDependientes == input.NumeroDependientes ||
                    (this.NumeroDependientes != null &&
                    this.NumeroDependientes.Equals(input.NumeroDependientes))
                ) && 
                (
                    this.FechaDefuncion == input.FechaDefuncion ||
                    (this.FechaDefuncion != null &&
                    this.FechaDefuncion.Equals(input.FechaDefuncion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.ApellidoPaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoPaterno.GetHashCode();
                if (this.ApellidoMaterno != null)
                    hashCode = hashCode * 59 + this.ApellidoMaterno.GetHashCode();
                if (this.ApellidoAdicional != null)
                    hashCode = hashCode * 59 + this.ApellidoAdicional.GetHashCode();
                if (this.Nombres != null)
                    hashCode = hashCode * 59 + this.Nombres.GetHashCode();
                if (this.FechaNacimiento != null)
                    hashCode = hashCode * 59 + this.FechaNacimiento.GetHashCode();
                if (this.RFC != null)
                    hashCode = hashCode * 59 + this.RFC.GetHashCode();
                if (this.CURP != null)
                    hashCode = hashCode * 59 + this.CURP.GetHashCode();
                if (this.NumeroSeguridadSocial != null)
                    hashCode = hashCode * 59 + this.NumeroSeguridadSocial.GetHashCode();
                if (this.Nacionalidad != null)
                    hashCode = hashCode * 59 + this.Nacionalidad.GetHashCode();
                if (this.Residencia != null)
                    hashCode = hashCode * 59 + this.Residencia.GetHashCode();
                if (this.EstadoCivil != null)
                    hashCode = hashCode * 59 + this.EstadoCivil.GetHashCode();
                if (this.Sexo != null)
                    hashCode = hashCode * 59 + this.Sexo.GetHashCode();
                if (this.ClaveElectorIFE != null)
                    hashCode = hashCode * 59 + this.ClaveElectorIFE.GetHashCode();
                if (this.NumeroDependientes != null)
                    hashCode = hashCode * 59 + this.NumeroDependientes.GetHashCode();
                if (this.FechaDefuncion != null)
                    hashCode = hashCode * 59 + this.FechaDefuncion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.ApellidoPaterno != null && this.ApellidoPaterno.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApellidoPaterno, length must be less than 30.", new [] { "ApellidoPaterno" });
            }
            if(this.ApellidoMaterno != null && this.ApellidoMaterno.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApellidoMaterno, length must be less than 30.", new [] { "ApellidoMaterno" });
            }
            if(this.ApellidoAdicional != null && this.ApellidoAdicional.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApellidoAdicional, length must be less than 30.", new [] { "ApellidoAdicional" });
            }
            if(this.Nombres != null && this.Nombres.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nombres, length must be less than 50.", new [] { "Nombres" });
            }
            if(this.NumeroSeguridadSocial != null && this.NumeroSeguridadSocial.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroSeguridadSocial, length must be less than 11.", new [] { "NumeroSeguridadSocial" });
            }
            if(this.ClaveElectorIFE != null && this.ClaveElectorIFE.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClaveElectorIFE, length must be less than 20.", new [] { "ClaveElectorIFE" });
            }
            yield break;
        }
    }
}
