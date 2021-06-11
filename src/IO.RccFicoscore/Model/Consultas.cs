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
    public partial class Consultas :  IEquatable<Consultas>, IValidatableObject
    {
        public Consultas(List<Consulta> consultas = default(List<Consulta>))
        {
            this._Consultas = consultas;
        }
        [DataMember(Name="consultas", EmitDefaultValue=false)]
        public List<Consulta> _Consultas { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Consultas {\n");
            sb.Append("  _Consultas: ").Append(_Consultas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Consultas);
        }
        public bool Equals(Consultas input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Consultas == input._Consultas ||
                    this._Consultas != null &&
                    this._Consultas.SequenceEqual(input._Consultas)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this._Consultas != null)
                    hashCode = hashCode * 59 + this._Consultas.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
