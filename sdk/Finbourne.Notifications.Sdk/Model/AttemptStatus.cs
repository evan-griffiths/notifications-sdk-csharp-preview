/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.838
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
    /// Status of the delivery attempt.
    /// </summary>
    [DataContract(Name = "AttemptStatus")]
    public partial class AttemptStatus : IEquatable<AttemptStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttemptStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptStatus" /> class.
        /// </summary>
        /// <param name="result">Result of the delivery. (required).</param>
        /// <param name="detailedMessage">The detailed message from attempting to deliver the message..</param>
        public AttemptStatus(string result = default(string), string detailedMessage = default(string))
        {
            // to ensure "result" is required (not null)
            this.Result = result ?? throw new ArgumentNullException("result is a required property for AttemptStatus and cannot be null");
            this.DetailedMessage = detailedMessage;
        }

        /// <summary>
        /// Result of the delivery.
        /// </summary>
        /// <value>Result of the delivery.</value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// The detailed message from attempting to deliver the message.
        /// </summary>
        /// <value>The detailed message from attempting to deliver the message.</value>
        [DataMember(Name = "detailedMessage", EmitDefaultValue = true)]
        public string DetailedMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttemptStatus {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DetailedMessage: ").Append(DetailedMessage).Append("\n");
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
            return this.Equals(input as AttemptStatus);
        }

        /// <summary>
        /// Returns true if AttemptStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AttemptStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttemptStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.DetailedMessage == input.DetailedMessage ||
                    (this.DetailedMessage != null &&
                    this.DetailedMessage.Equals(input.DetailedMessage))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.DetailedMessage != null)
                    hashCode = hashCode * 59 + this.DetailedMessage.GetHashCode();
                return hashCode;
            }
        }

    }
}
