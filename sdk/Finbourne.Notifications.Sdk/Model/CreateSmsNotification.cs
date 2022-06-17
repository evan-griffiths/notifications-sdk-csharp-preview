/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.391
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
    /// The information required to create a notification which, when processed, will send an SMS
    /// </summary>
    [DataContract(Name = "CreateSmsNotification")]
    public partial class CreateSmsNotification : IEquatable<CreateSmsNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSmsNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsNotification" /> class.
        /// </summary>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="body">The body of the SMS (required).</param>
        /// <param name="recipients">The phone numbers to which the SMS will be sent to (E.164 format) (required).</param>
        public CreateSmsNotification(string description = default(string), string body = default(string), List<string> recipients = default(List<string>))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for CreateSmsNotification and cannot be null");
            // to ensure "body" is required (not null)
            this.Body = body ?? throw new ArgumentNullException("body is a required property for CreateSmsNotification and cannot be null");
            // to ensure "recipients" is required (not null)
            this.Recipients = recipients ?? throw new ArgumentNullException("recipients is a required property for CreateSmsNotification and cannot be null");
        }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The body of the SMS
        /// </summary>
        /// <value>The body of the SMS</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// The phone numbers to which the SMS will be sent to (E.164 format)
        /// </summary>
        /// <value>The phone numbers to which the SMS will be sent to (E.164 format)</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSmsNotification {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
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
            return this.Equals(input as CreateSmsNotification);
        }

        /// <summary>
        /// Returns true if CreateSmsNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSmsNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSmsNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                return hashCode;
            }
        }

    }
}
