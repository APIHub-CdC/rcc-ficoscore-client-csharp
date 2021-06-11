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
    public partial class Mensaje :  IEquatable<Mensaje>, IValidatableObject
    {
        public Mensaje(int? tipoMensaje = default(int?), string leyenda = default(string))
        {
            this.TipoMensaje = tipoMensaje;
            this.Leyenda = leyenda;
        }
        [DataMember(Name="tipoMensaje", EmitDefaultValue=false)]
        public int? TipoMensaje { get; set; }
        [DataMember(Name="leyenda", EmitDefaultValue=false)]
        public string Leyenda { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mensaje {\n");
            sb.Append("  TipoMensaje: ").Append(TipoMensaje).Append("\n");
            sb.Append("  Leyenda: ").Append(Leyenda).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Mensaje);
        }
        public bool Equals(Mensaje input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.TipoMensaje == input.TipoMensaje ||
                    (this.TipoMensaje != null &&
                    this.TipoMensaje.Equals(input.TipoMensaje))
                ) && 
                (
                    this.Leyenda == input.Leyenda ||
                    (this.Leyenda != null &&
                    this.Leyenda.Equals(input.Leyenda))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.TipoMensaje != null)
                    hashCode = hashCode * 59 + this.TipoMensaje.GetHashCode();
                if (this.Leyenda != null)
                    hashCode = hashCode * 59 + this.Leyenda.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.Leyenda != null && this.Leyenda.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Leyenda, length must be less than 100.", new [] { "Leyenda" });
            }
            yield break;
        }
    }
}
