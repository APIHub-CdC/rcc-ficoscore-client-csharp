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
    public partial class Empleo :  IEquatable<Empleo>, IValidatableObject
    {
        [DataMember(Name="estado", EmitDefaultValue=false)]
        public CatalogoEstados? Estado { get; set; }
        [DataMember(Name="claveMoneda", EmitDefaultValue=false)]
        public CatalogoMoneda? ClaveMoneda { get; set; }
        public Empleo(string nombreEmpresa = default(string), string direccion = default(string), string coloniaPoblacion = default(string), string delegacionMunicipio = default(string), string ciudad = default(string), CatalogoEstados? estado = default(CatalogoEstados?), string cP = default(string), string numeroTelefono = default(string), string extension = default(string), string fax = default(string), string puesto = default(string), string fechaContratacion = default(string), CatalogoMoneda? claveMoneda = default(CatalogoMoneda?), float? salarioMensual = default(float?), string fechaUltimoDiaEmpleo = default(string), string fechaVerificacionEmpleo = default(string))
        {
            this.NombreEmpresa = nombreEmpresa;
            this.Direccion = direccion;
            this.ColoniaPoblacion = coloniaPoblacion;
            this.DelegacionMunicipio = delegacionMunicipio;
            this.Ciudad = ciudad;
            this.Estado = estado;
            this.CP = cP;
            this.NumeroTelefono = numeroTelefono;
            this.Extension = extension;
            this.Fax = fax;
            this.Puesto = puesto;
            this.FechaContratacion = fechaContratacion;
            this.ClaveMoneda = claveMoneda;
            this.SalarioMensual = salarioMensual;
            this.FechaUltimoDiaEmpleo = fechaUltimoDiaEmpleo;
            this.FechaVerificacionEmpleo = fechaVerificacionEmpleo;
        }
        [DataMember(Name="nombreEmpresa", EmitDefaultValue=false)]
        public string NombreEmpresa { get; set; }
        [DataMember(Name="direccion", EmitDefaultValue=false)]
        public string Direccion { get; set; }
        [DataMember(Name="coloniaPoblacion", EmitDefaultValue=false)]
        public string ColoniaPoblacion { get; set; }
        [DataMember(Name="delegacionMunicipio", EmitDefaultValue=false)]
        public string DelegacionMunicipio { get; set; }
        [DataMember(Name="ciudad", EmitDefaultValue=false)]
        public string Ciudad { get; set; }
        [DataMember(Name="CP", EmitDefaultValue=false)]
        public string CP { get; set; }
        [DataMember(Name="numeroTelefono", EmitDefaultValue=false)]
        public string NumeroTelefono { get; set; }
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
        [DataMember(Name="puesto", EmitDefaultValue=false)]
        public string Puesto { get; set; }
        [DataMember(Name="fechaContratacion", EmitDefaultValue=false)]
        public string FechaContratacion { get; set; }
        [DataMember(Name="salarioMensual", EmitDefaultValue=false)]
        public float? SalarioMensual { get; set; }
        [DataMember(Name="fechaUltimoDiaEmpleo", EmitDefaultValue=false)]
        public string FechaUltimoDiaEmpleo { get; set; }
        [DataMember(Name="fechaVerificacionEmpleo", EmitDefaultValue=false)]
        public string FechaVerificacionEmpleo { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Empleo {\n");
            sb.Append("  NombreEmpresa: ").Append(NombreEmpresa).Append("\n");
            sb.Append("  Direccion: ").Append(Direccion).Append("\n");
            sb.Append("  ColoniaPoblacion: ").Append(ColoniaPoblacion).Append("\n");
            sb.Append("  DelegacionMunicipio: ").Append(DelegacionMunicipio).Append("\n");
            sb.Append("  Ciudad: ").Append(Ciudad).Append("\n");
            sb.Append("  Estado: ").Append(Estado).Append("\n");
            sb.Append("  CP: ").Append(CP).Append("\n");
            sb.Append("  NumeroTelefono: ").Append(NumeroTelefono).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Puesto: ").Append(Puesto).Append("\n");
            sb.Append("  FechaContratacion: ").Append(FechaContratacion).Append("\n");
            sb.Append("  ClaveMoneda: ").Append(ClaveMoneda).Append("\n");
            sb.Append("  SalarioMensual: ").Append(SalarioMensual).Append("\n");
            sb.Append("  FechaUltimoDiaEmpleo: ").Append(FechaUltimoDiaEmpleo).Append("\n");
            sb.Append("  FechaVerificacionEmpleo: ").Append(FechaVerificacionEmpleo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Empleo);
        }
        public bool Equals(Empleo input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NombreEmpresa == input.NombreEmpresa ||
                    (this.NombreEmpresa != null &&
                    this.NombreEmpresa.Equals(input.NombreEmpresa))
                ) && 
                (
                    this.Direccion == input.Direccion ||
                    (this.Direccion != null &&
                    this.Direccion.Equals(input.Direccion))
                ) && 
                (
                    this.ColoniaPoblacion == input.ColoniaPoblacion ||
                    (this.ColoniaPoblacion != null &&
                    this.ColoniaPoblacion.Equals(input.ColoniaPoblacion))
                ) && 
                (
                    this.DelegacionMunicipio == input.DelegacionMunicipio ||
                    (this.DelegacionMunicipio != null &&
                    this.DelegacionMunicipio.Equals(input.DelegacionMunicipio))
                ) && 
                (
                    this.Ciudad == input.Ciudad ||
                    (this.Ciudad != null &&
                    this.Ciudad.Equals(input.Ciudad))
                ) && 
                (
                    this.Estado == input.Estado ||
                    (this.Estado != null &&
                    this.Estado.Equals(input.Estado))
                ) && 
                (
                    this.CP == input.CP ||
                    (this.CP != null &&
                    this.CP.Equals(input.CP))
                ) && 
                (
                    this.NumeroTelefono == input.NumeroTelefono ||
                    (this.NumeroTelefono != null &&
                    this.NumeroTelefono.Equals(input.NumeroTelefono))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Puesto == input.Puesto ||
                    (this.Puesto != null &&
                    this.Puesto.Equals(input.Puesto))
                ) && 
                (
                    this.FechaContratacion == input.FechaContratacion ||
                    (this.FechaContratacion != null &&
                    this.FechaContratacion.Equals(input.FechaContratacion))
                ) && 
                (
                    this.ClaveMoneda == input.ClaveMoneda ||
                    (this.ClaveMoneda != null &&
                    this.ClaveMoneda.Equals(input.ClaveMoneda))
                ) && 
                (
                    this.SalarioMensual == input.SalarioMensual ||
                    (this.SalarioMensual != null &&
                    this.SalarioMensual.Equals(input.SalarioMensual))
                ) && 
                (
                    this.FechaUltimoDiaEmpleo == input.FechaUltimoDiaEmpleo ||
                    (this.FechaUltimoDiaEmpleo != null &&
                    this.FechaUltimoDiaEmpleo.Equals(input.FechaUltimoDiaEmpleo))
                ) && 
                (
                    this.FechaVerificacionEmpleo == input.FechaVerificacionEmpleo ||
                    (this.FechaVerificacionEmpleo != null &&
                    this.FechaVerificacionEmpleo.Equals(input.FechaVerificacionEmpleo))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NombreEmpresa != null)
                    hashCode = hashCode * 59 + this.NombreEmpresa.GetHashCode();
                if (this.Direccion != null)
                    hashCode = hashCode * 59 + this.Direccion.GetHashCode();
                if (this.ColoniaPoblacion != null)
                    hashCode = hashCode * 59 + this.ColoniaPoblacion.GetHashCode();
                if (this.DelegacionMunicipio != null)
                    hashCode = hashCode * 59 + this.DelegacionMunicipio.GetHashCode();
                if (this.Ciudad != null)
                    hashCode = hashCode * 59 + this.Ciudad.GetHashCode();
                if (this.Estado != null)
                    hashCode = hashCode * 59 + this.Estado.GetHashCode();
                if (this.CP != null)
                    hashCode = hashCode * 59 + this.CP.GetHashCode();
                if (this.NumeroTelefono != null)
                    hashCode = hashCode * 59 + this.NumeroTelefono.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Puesto != null)
                    hashCode = hashCode * 59 + this.Puesto.GetHashCode();
                if (this.FechaContratacion != null)
                    hashCode = hashCode * 59 + this.FechaContratacion.GetHashCode();
                if (this.ClaveMoneda != null)
                    hashCode = hashCode * 59 + this.ClaveMoneda.GetHashCode();
                if (this.SalarioMensual != null)
                    hashCode = hashCode * 59 + this.SalarioMensual.GetHashCode();
                if (this.FechaUltimoDiaEmpleo != null)
                    hashCode = hashCode * 59 + this.FechaUltimoDiaEmpleo.GetHashCode();
                if (this.FechaVerificacionEmpleo != null)
                    hashCode = hashCode * 59 + this.FechaVerificacionEmpleo.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.NombreEmpresa != null && this.NombreEmpresa.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NombreEmpresa, length must be less than 40.", new [] { "NombreEmpresa" });
            }
            if(this.Direccion != null && this.Direccion.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Direccion, length must be less than 80.", new [] { "Direccion" });
            }
            if(this.ColoniaPoblacion != null && this.ColoniaPoblacion.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ColoniaPoblacion, length must be less than 65.", new [] { "ColoniaPoblacion" });
            }
            if(this.DelegacionMunicipio != null && this.DelegacionMunicipio.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DelegacionMunicipio, length must be less than 65.", new [] { "DelegacionMunicipio" });
            }
            if(this.Ciudad != null && this.Ciudad.Length > 65)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ciudad, length must be less than 65.", new [] { "Ciudad" });
            }
            if(this.CP != null && this.CP.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CP, length must be less than 5.", new [] { "CP" });
            }
            if(this.NumeroTelefono != null && this.NumeroTelefono.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroTelefono, length must be less than 20.", new [] { "NumeroTelefono" });
            }
            if(this.Extension != null && this.Extension.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Extension, length must be less than 8.", new [] { "Extension" });
            }
            if(this.Fax != null && this.Fax.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Fax, length must be less than 20.", new [] { "Fax" });
            }
            if(this.Puesto != null && this.Puesto.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Puesto, length must be less than 60.", new [] { "Puesto" });
            }
            yield break;
        }
    }
}
