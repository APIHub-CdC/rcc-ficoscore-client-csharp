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
    public partial class Empleos :  IEquatable<Empleos>, IValidatableObject
    {
        public Empleos(List<Empleo> empleos = default(List<Empleo>))
        {
            this._Empleos = empleos;
        }
        [DataMember(Name="empleos", EmitDefaultValue=false)]
        public List<Empleo> _Empleos { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Empleos {\n");
            sb.Append("  _Empleos: ").Append(_Empleos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Empleos);
        }
        public bool Equals(Empleos input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Empleos == input._Empleos ||
                    this._Empleos != null &&
                    this._Empleos.SequenceEqual(input._Empleos)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this._Empleos != null)
                    hashCode = hashCode * 59 + this._Empleos.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
