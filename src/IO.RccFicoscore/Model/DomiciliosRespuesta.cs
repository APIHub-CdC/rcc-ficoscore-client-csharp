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
    public partial class DomiciliosRespuesta :  IEquatable<DomiciliosRespuesta>, IValidatableObject
    {
        public DomiciliosRespuesta(List<DomicilioRespuesta> domicilios = default(List<DomicilioRespuesta>))
        {
            this.Domicilios = domicilios;
        }
        [DataMember(Name="domicilios", EmitDefaultValue=false)]
        public List<DomicilioRespuesta> Domicilios { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomiciliosRespuesta {\n");
            sb.Append("  Domicilios: ").Append(Domicilios).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as DomiciliosRespuesta);
        }
        public bool Equals(DomiciliosRespuesta input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Domicilios == input.Domicilios ||
                    this.Domicilios != null &&
                    this.Domicilios.SequenceEqual(input.Domicilios)
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.Domicilios != null)
                    hashCode = hashCode * 59 + this.Domicilios.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
