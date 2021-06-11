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
    public partial class Errores :  IEquatable<Errores>, IValidatableObject
    {
        public Errores(List<Error> errores = default(List<Error>), Autenticacion autenticacion = default(Autenticacion))
        {
            this._Errores = errores;
            this.Autenticacion = autenticacion;
        }
        [DataMember(Name="errores", EmitDefaultValue=false)]
        public List<Error> _Errores { get; set; }
        [DataMember(Name="autenticacion", EmitDefaultValue=false)]
        public Autenticacion Autenticacion { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Errores {\n");
            sb.Append("  _Errores: ").Append(_Errores).Append("\n");
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
            return this.Equals(input as Errores);
        }
        public bool Equals(Errores input)
        {
            if (input == null)
                return false;
            return 
                (
                    this._Errores == input._Errores ||
                    this._Errores != null &&
                    this._Errores.SequenceEqual(input._Errores)
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
                if (this._Errores != null)
                    hashCode = hashCode * 59 + this._Errores.GetHashCode();
                if (this.Autenticacion != null)
                    hashCode = hashCode * 59 + this.Autenticacion.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
