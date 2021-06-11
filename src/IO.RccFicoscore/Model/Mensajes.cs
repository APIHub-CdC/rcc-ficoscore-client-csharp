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
    public partial class Mensajes :  IEquatable<Mensajes>, IValidatableObject
    {
        public Mensajes(List<Mensaje> mensajes = default(List<Mensaje>))
        {
            this._Mensajes = mensajes;
        }
        [DataMember(Name="mensajes", EmitDefaultValue=false)]
        public List<Mensaje> _Mensajes { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mensajes {\n");
            sb.Append("  _Mensajes: ").Append(_Mensajes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Mensajes);
        }
        public bool Equals(Mensajes input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Mensajes == input._Mensajes ||
                    this._Mensajes != null &&
                    this._Mensajes.SequenceEqual(input._Mensajes)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this._Mensajes != null)
                    hashCode = hashCode * 59 + this._Mensajes.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
