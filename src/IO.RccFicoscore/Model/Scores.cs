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
    public partial class Scores :  IEquatable<Scores>, IValidatableObject
    {
        public Scores(List<Score> scores = default(List<Score>))
        {
            this._Scores = scores;
        }
        [DataMember(Name="scores", EmitDefaultValue=false)]
        public List<Score> _Scores { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scores {\n");
            sb.Append("  _Scores: ").Append(_Scores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Scores);
        }
        public bool Equals(Scores input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Scores == input._Scores ||
                    this._Scores != null &&
                    this._Scores.SequenceEqual(input._Scores)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this._Scores != null)
                    hashCode = hashCode * 59 + this._Scores.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
