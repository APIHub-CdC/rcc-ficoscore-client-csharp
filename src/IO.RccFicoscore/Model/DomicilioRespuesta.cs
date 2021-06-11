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
    public partial class DomicilioRespuesta :  IEquatable<DomicilioRespuesta>, IValidatableObject
    {
        [DataMember(Name="estado", EmitDefaultValue=false)]
        public CatalogoEstados? Estado { get; set; }
        [DataMember(Name="tipoDomicilio", EmitDefaultValue=false)]
        public CatalogoTipoDomicilio? TipoDomicilio { get; set; }
        [DataMember(Name="tipoAsentamiento", EmitDefaultValue=false)]
        public CatalogoTipoAsentamiento? TipoAsentamiento { get; set; }
        public DomicilioRespuesta(string direccion = default(string), string coloniaPoblacion = default(string), string delegacionMunicipio = default(string), string ciudad = default(string), CatalogoEstados? estado = default(CatalogoEstados?), string cP = default(string), string fechaResidencia = default(string), string numeroTelefono = default(string), CatalogoTipoDomicilio? tipoDomicilio = default(CatalogoTipoDomicilio?), CatalogoTipoAsentamiento? tipoAsentamiento = default(CatalogoTipoAsentamiento?), string fechaRegistroDomicilio = default(string), int? tipoAltaDomicilio = default(int?), int? numeroOtorgantesCarga = default(int?), int? numeroOtorgantesConsulta = default(int?), string idDomicilio = default(string))
        {
            this.Direccion = direccion;
            this.ColoniaPoblacion = coloniaPoblacion;
            this.DelegacionMunicipio = delegacionMunicipio;
            this.Ciudad = ciudad;
            this.Estado = estado;
            this.CP = cP;
            this.FechaResidencia = fechaResidencia;
            this.NumeroTelefono = numeroTelefono;
            this.TipoDomicilio = tipoDomicilio;
            this.TipoAsentamiento = tipoAsentamiento;
            this.FechaRegistroDomicilio = fechaRegistroDomicilio;
            this.TipoAltaDomicilio = tipoAltaDomicilio;
            this.NumeroOtorgantesCarga = numeroOtorgantesCarga;
            this.NumeroOtorgantesConsulta = numeroOtorgantesConsulta;
            this.IdDomicilio = idDomicilio;
        }
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
        [DataMember(Name="fechaResidencia", EmitDefaultValue=false)]
        public string FechaResidencia { get; set; }
        [DataMember(Name="numeroTelefono", EmitDefaultValue=false)]
        public string NumeroTelefono { get; set; }
        [DataMember(Name="fechaRegistroDomicilio", EmitDefaultValue=false)]
        public string FechaRegistroDomicilio { get; set; }
        [DataMember(Name="tipoAltaDomicilio", EmitDefaultValue=false)]
        public int? TipoAltaDomicilio { get; set; }
        [DataMember(Name="numeroOtorgantesCarga", EmitDefaultValue=false)]
        public int? NumeroOtorgantesCarga { get; set; }
        [DataMember(Name="numeroOtorgantesConsulta", EmitDefaultValue=false)]
        public int? NumeroOtorgantesConsulta { get; set; }
        [DataMember(Name="idDomicilio", EmitDefaultValue=false)]
        public string IdDomicilio { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomicilioRespuesta {\n");
            sb.Append("  Direccion: ").Append(Direccion).Append("\n");
            sb.Append("  ColoniaPoblacion: ").Append(ColoniaPoblacion).Append("\n");
            sb.Append("  DelegacionMunicipio: ").Append(DelegacionMunicipio).Append("\n");
            sb.Append("  Ciudad: ").Append(Ciudad).Append("\n");
            sb.Append("  Estado: ").Append(Estado).Append("\n");
            sb.Append("  CP: ").Append(CP).Append("\n");
            sb.Append("  FechaResidencia: ").Append(FechaResidencia).Append("\n");
            sb.Append("  NumeroTelefono: ").Append(NumeroTelefono).Append("\n");
            sb.Append("  TipoDomicilio: ").Append(TipoDomicilio).Append("\n");
            sb.Append("  TipoAsentamiento: ").Append(TipoAsentamiento).Append("\n");
            sb.Append("  FechaRegistroDomicilio: ").Append(FechaRegistroDomicilio).Append("\n");
            sb.Append("  TipoAltaDomicilio: ").Append(TipoAltaDomicilio).Append("\n");
            sb.Append("  NumeroOtorgantesCarga: ").Append(NumeroOtorgantesCarga).Append("\n");
            sb.Append("  NumeroOtorgantesConsulta: ").Append(NumeroOtorgantesConsulta).Append("\n");
            sb.Append("  IdDomicilio: ").Append(IdDomicilio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DomicilioRespuesta);
        }
        public bool Equals(DomicilioRespuesta input)
        {
            if (input == null)
                return false;
            return 
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
                    this.FechaResidencia == input.FechaResidencia ||
                    (this.FechaResidencia != null &&
                    this.FechaResidencia.Equals(input.FechaResidencia))
                ) && 
                (
                    this.NumeroTelefono == input.NumeroTelefono ||
                    (this.NumeroTelefono != null &&
                    this.NumeroTelefono.Equals(input.NumeroTelefono))
                ) && 
                (
                    this.TipoDomicilio == input.TipoDomicilio ||
                    (this.TipoDomicilio != null &&
                    this.TipoDomicilio.Equals(input.TipoDomicilio))
                ) && 
                (
                    this.TipoAsentamiento == input.TipoAsentamiento ||
                    (this.TipoAsentamiento != null &&
                    this.TipoAsentamiento.Equals(input.TipoAsentamiento))
                ) && 
                (
                    this.FechaRegistroDomicilio == input.FechaRegistroDomicilio ||
                    (this.FechaRegistroDomicilio != null &&
                    this.FechaRegistroDomicilio.Equals(input.FechaRegistroDomicilio))
                ) && 
                (
                    this.TipoAltaDomicilio == input.TipoAltaDomicilio ||
                    (this.TipoAltaDomicilio != null &&
                    this.TipoAltaDomicilio.Equals(input.TipoAltaDomicilio))
                ) && 
                (
                    this.NumeroOtorgantesCarga == input.NumeroOtorgantesCarga ||
                    (this.NumeroOtorgantesCarga != null &&
                    this.NumeroOtorgantesCarga.Equals(input.NumeroOtorgantesCarga))
                ) && 
                (
                    this.NumeroOtorgantesConsulta == input.NumeroOtorgantesConsulta ||
                    (this.NumeroOtorgantesConsulta != null &&
                    this.NumeroOtorgantesConsulta.Equals(input.NumeroOtorgantesConsulta))
                ) && 
                (
                    this.IdDomicilio == input.IdDomicilio ||
                    (this.IdDomicilio != null &&
                    this.IdDomicilio.Equals(input.IdDomicilio))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
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
                if (this.FechaResidencia != null)
                    hashCode = hashCode * 59 + this.FechaResidencia.GetHashCode();
                if (this.NumeroTelefono != null)
                    hashCode = hashCode * 59 + this.NumeroTelefono.GetHashCode();
                if (this.TipoDomicilio != null)
                    hashCode = hashCode * 59 + this.TipoDomicilio.GetHashCode();
                if (this.TipoAsentamiento != null)
                    hashCode = hashCode * 59 + this.TipoAsentamiento.GetHashCode();
                if (this.FechaRegistroDomicilio != null)
                    hashCode = hashCode * 59 + this.FechaRegistroDomicilio.GetHashCode();
                if (this.TipoAltaDomicilio != null)
                    hashCode = hashCode * 59 + this.TipoAltaDomicilio.GetHashCode();
                if (this.NumeroOtorgantesCarga != null)
                    hashCode = hashCode * 59 + this.NumeroOtorgantesCarga.GetHashCode();
                if (this.NumeroOtorgantesConsulta != null)
                    hashCode = hashCode * 59 + this.NumeroOtorgantesConsulta.GetHashCode();
                if (this.IdDomicilio != null)
                    hashCode = hashCode * 59 + this.IdDomicilio.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.Direccion != null && this.Direccion.Length > 85)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Direccion, length must be less than 85.", new [] { "Direccion" });
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
            if(this.TipoAltaDomicilio > (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TipoAltaDomicilio, must be a value less than or equal to 1.", new [] { "TipoAltaDomicilio" });
            }
            if(this.TipoAltaDomicilio < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TipoAltaDomicilio, must be a value greater than or equal to 0.", new [] { "TipoAltaDomicilio" });
            }
            if(this.NumeroOtorgantesCarga > (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroOtorgantesCarga, must be a value less than or equal to 1.", new [] { "NumeroOtorgantesCarga" });
            }
            if(this.NumeroOtorgantesCarga < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroOtorgantesCarga, must be a value greater than or equal to 0.", new [] { "NumeroOtorgantesCarga" });
            }
            if(this.NumeroOtorgantesConsulta > (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroOtorgantesConsulta, must be a value less than or equal to 1.", new [] { "NumeroOtorgantesConsulta" });
            }
            if(this.NumeroOtorgantesConsulta < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumeroOtorgantesConsulta, must be a value greater than or equal to 0.", new [] { "NumeroOtorgantesConsulta" });
            }
            yield break;
        }
    }
}
