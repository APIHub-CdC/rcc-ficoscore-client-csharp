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
    public partial class Respuesta :  IEquatable<Respuesta>, IValidatableObject
    {
        public Respuesta(string folioConsulta = default(string), string folioConsultaOtorgante = default(string), string claveOtorgante = default(string), string declaracionesConsumidor = default(string), PersonaRespuesta persona = default(PersonaRespuesta), List<Consulta> consultas = default(List<Consulta>), List<Credito> creditos = default(List<Credito>), List<DomicilioRespuesta> domicilios = default(List<DomicilioRespuesta>), List<Empleo> empleos = default(List<Empleo>), List<Score> scores = default(List<Score>), List<Mensaje> mensajes = default(List<Mensaje>), Autenticacion autenticacion = default(Autenticacion))
        {
            this.FolioConsulta = folioConsulta;
            this.FolioConsultaOtorgante = folioConsultaOtorgante;
            this.ClaveOtorgante = claveOtorgante;
            this.DeclaracionesConsumidor = declaracionesConsumidor;
            this.Persona = persona;
            this.Consultas = consultas;
            this.Creditos = creditos;
            this.Domicilios = domicilios;
            this.Empleos = empleos;
            this.Scores = scores;
            this.Mensajes = mensajes;
            this.Autenticacion = autenticacion;
        }
        [DataMember(Name="folioConsulta", EmitDefaultValue=false)]
        public string FolioConsulta { get; set; }
        [DataMember(Name="folioConsultaOtorgante", EmitDefaultValue=false)]
        public string FolioConsultaOtorgante { get; set; }
        [DataMember(Name="claveOtorgante", EmitDefaultValue=false)]
        public string ClaveOtorgante { get; set; }
        [DataMember(Name="declaracionesConsumidor", EmitDefaultValue=false)]
        public string DeclaracionesConsumidor { get; set; }
        [DataMember(Name="persona", EmitDefaultValue=false)]
        public PersonaRespuesta Persona { get; set; }
        [DataMember(Name="consultas", EmitDefaultValue=false)]
        public List<Consulta> Consultas { get; set; }
        [DataMember(Name="creditos", EmitDefaultValue=false)]
        public List<Credito> Creditos { get; set; }
        [DataMember(Name="domicilios", EmitDefaultValue=false)]
        public List<DomicilioRespuesta> Domicilios { get; set; }
        [DataMember(Name="empleos", EmitDefaultValue=false)]
        public List<Empleo> Empleos { get; set; }
        [DataMember(Name="scores", EmitDefaultValue=false)]
        public List<Score> Scores { get; set; }
        [DataMember(Name="mensajes", EmitDefaultValue=false)]
        public List<Mensaje> Mensajes { get; set; }
        [DataMember(Name="autenticacion", EmitDefaultValue=false)]
        public Autenticacion Autenticacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Respuesta {\n");
            sb.Append("  FolioConsulta: ").Append(FolioConsulta).Append("\n");
            sb.Append("  FolioConsultaOtorgante: ").Append(FolioConsultaOtorgante).Append("\n");
            sb.Append("  ClaveOtorgante: ").Append(ClaveOtorgante).Append("\n");
            sb.Append("  DeclaracionesConsumidor: ").Append(DeclaracionesConsumidor).Append("\n");
            sb.Append("  Persona: ").Append(Persona).Append("\n");
            sb.Append("  Consultas: ").Append(Consultas).Append("\n");
            sb.Append("  Creditos: ").Append(Creditos).Append("\n");
            sb.Append("  Domicilios: ").Append(Domicilios).Append("\n");
            sb.Append("  Empleos: ").Append(Empleos).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
            sb.Append("  Mensajes: ").Append(Mensajes).Append("\n");
            sb.Append("  Autenticacion: ").Append(Autenticacion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Respuesta);
        }
        public bool Equals(Respuesta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FolioConsulta == input.FolioConsulta ||
                    (this.FolioConsulta != null &&
                    this.FolioConsulta.Equals(input.FolioConsulta))
                ) && 
                (
                    this.FolioConsultaOtorgante == input.FolioConsultaOtorgante ||
                    (this.FolioConsultaOtorgante != null &&
                    this.FolioConsultaOtorgante.Equals(input.FolioConsultaOtorgante))
                ) && 
                (
                    this.ClaveOtorgante == input.ClaveOtorgante ||
                    (this.ClaveOtorgante != null &&
                    this.ClaveOtorgante.Equals(input.ClaveOtorgante))
                ) && 
                (
                    this.DeclaracionesConsumidor == input.DeclaracionesConsumidor ||
                    (this.DeclaracionesConsumidor != null &&
                    this.DeclaracionesConsumidor.Equals(input.DeclaracionesConsumidor))
                ) && 
                (
                    this.Persona == input.Persona ||
                    (this.Persona != null &&
                    this.Persona.Equals(input.Persona))
                ) && 
                (
                    this.Consultas == input.Consultas ||
                    this.Consultas != null &&
                    this.Consultas.SequenceEqual(input.Consultas)
                ) && 
                (
                    this.Creditos == input.Creditos ||
                    this.Creditos != null &&
                    this.Creditos.SequenceEqual(input.Creditos)
                ) && 
                (
                    this.Domicilios == input.Domicilios ||
                    this.Domicilios != null &&
                    this.Domicilios.SequenceEqual(input.Domicilios)
                ) && 
                (
                    this.Empleos == input.Empleos ||
                    this.Empleos != null &&
                    this.Empleos.SequenceEqual(input.Empleos)
                ) && 
                (
                    this.Scores == input.Scores ||
                    this.Scores != null &&
                    this.Scores.SequenceEqual(input.Scores)
                ) && 
                (
                    this.Mensajes == input.Mensajes ||
                    this.Mensajes != null &&
                    this.Mensajes.SequenceEqual(input.Mensajes)
                ) && 
                (
                    this.Autenticacion == input.Autenticacion ||
                    (this.Autenticacion != null &&
                    this.Autenticacion.Equals(input.Autenticacion))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FolioConsulta != null)
                    hashCode = hashCode * 59 + this.FolioConsulta.GetHashCode();
                if (this.FolioConsultaOtorgante != null)
                    hashCode = hashCode * 59 + this.FolioConsultaOtorgante.GetHashCode();
                if (this.ClaveOtorgante != null)
                    hashCode = hashCode * 59 + this.ClaveOtorgante.GetHashCode();
                if (this.DeclaracionesConsumidor != null)
                    hashCode = hashCode * 59 + this.DeclaracionesConsumidor.GetHashCode();
                if (this.Persona != null)
                    hashCode = hashCode * 59 + this.Persona.GetHashCode();
                if (this.Consultas != null)
                    hashCode = hashCode * 59 + this.Consultas.GetHashCode();
                if (this.Creditos != null)
                    hashCode = hashCode * 59 + this.Creditos.GetHashCode();
                if (this.Domicilios != null)
                    hashCode = hashCode * 59 + this.Domicilios.GetHashCode();
                if (this.Empleos != null)
                    hashCode = hashCode * 59 + this.Empleos.GetHashCode();
                if (this.Scores != null)
                    hashCode = hashCode * 59 + this.Scores.GetHashCode();
                if (this.Mensajes != null)
                    hashCode = hashCode * 59 + this.Mensajes.GetHashCode();
                if (this.Autenticacion != null)
                    hashCode = hashCode * 59 + this.Autenticacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.DeclaracionesConsumidor != null && this.DeclaracionesConsumidor.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeclaracionesConsumidor, length must be less than 100.", new [] { "DeclaracionesConsumidor" });
            }
            yield break;
        }
    }
}
