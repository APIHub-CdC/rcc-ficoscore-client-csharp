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
    public partial class Score :  IEquatable<Score>, IValidatableObject
    {
        public Score(string nombreScore = default(string), int? valor = default(int?), List<CatalogoRazones> razones = default(List<CatalogoRazones>))
        {
            this.NombreScore = nombreScore;
            this.Valor = valor;
            this.Razones = razones;
        }
        [DataMember(Name="nombreScore", EmitDefaultValue=false)]
        public string NombreScore { get; set; }
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public int? Valor { get; set; }
        [DataMember(Name="razones", EmitDefaultValue=false)]
        public List<CatalogoRazones> Razones { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Score {\n");
            sb.Append("  NombreScore: ").Append(NombreScore).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Razones: ").Append(Razones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Score);
        }
        public bool Equals(Score input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.NombreScore == input.NombreScore ||
                    (this.NombreScore != null &&
                    this.NombreScore.Equals(input.NombreScore))
                ) && 
                (
                    this.Valor == input.Valor ||
                    (this.Valor != null &&
                    this.Valor.Equals(input.Valor))
                ) && 
                (
                    this.Razones == input.Razones ||
                    this.Razones != null &&
                    this.Razones.SequenceEqual(input.Razones)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.NombreScore != null)
                    hashCode = hashCode * 59 + this.NombreScore.GetHashCode();
                if (this.Valor != null)
                    hashCode = hashCode * 59 + this.Valor.GetHashCode();
                if (this.Razones != null)
                    hashCode = hashCode * 59 + this.Razones.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.Valor > (int?)900)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Valor, must be a value less than or equal to 900.", new [] { "Valor" });
            }
            if(this.Valor < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Valor, must be a value greater than or equal to 0.", new [] { "Valor" });
            }
            yield break;
        }
    }
}
