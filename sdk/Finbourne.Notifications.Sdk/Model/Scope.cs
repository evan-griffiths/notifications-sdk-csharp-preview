/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.219
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Notifications.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// Scope
    /// </summary>
    [DataContract(Name = "Scope")]
    public partial class Scope : IEquatable<Scope>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        /// <param name="scopeName">scopeName.</param>
        public Scope(string scopeName = default(string))
        {
            this.ScopeName = scopeName;
        }

        /// <summary>
        /// Gets or Sets ScopeName
        /// </summary>
        [DataMember(Name = "scopeName", EmitDefaultValue = true)]
        public string ScopeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scope {\n");
            sb.Append("  ScopeName: ").Append(ScopeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Scope);
        }

        /// <summary>
        /// Returns true if Scope instances are equal
        /// </summary>
        /// <param name="input">Instance of Scope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scope input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScopeName == input.ScopeName ||
                    (this.ScopeName != null &&
                    this.ScopeName.Equals(input.ScopeName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ScopeName != null)
                    hashCode = hashCode * 59 + this.ScopeName.GetHashCode();
                return hashCode;
            }
        }

    }
}
