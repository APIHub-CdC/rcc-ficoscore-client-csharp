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
    public partial class Creditos :  IEquatable<Creditos>, IValidatableObject
    {
        public Creditos(List<Credito> creditos = default(List<Credito>))
        {
            this._Creditos = creditos;
        }
        [DataMember(Name="creditos", EmitDefaultValue=false)]
        public List<Credito> _Creditos { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Creditos {\n");
            sb.Append("  _Creditos: ").Append(_Creditos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Creditos);
        }
        public bool Equals(Creditos input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Creditos == input._Creditos ||
                    this._Creditos != null &&
                    this._Creditos.SequenceEqual(input._Creditos)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this._Creditos != null)
                    hashCode = hashCode * 59 + this._Creditos.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
