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
    /// The status object of a notification
    /// </summary>
    [DataContract(Name = "NotificationStatus")]
    public partial class NotificationStatus : IEquatable<NotificationStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationStatus" /> class.
        /// </summary>
        /// <param name="result">The status of the notification.</param>
        /// <param name="lastUpdated">The time at which the notification status was last updated.</param>
        public NotificationStatus(string result = default(string), DateTimeOffset lastUpdated = default(DateTimeOffset))
        {
            this.Result = result;
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// The status of the notification
        /// </summary>
        /// <value>The status of the notification</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// The time at which the notification status was last updated
        /// </summary>
        /// <value>The time at which the notification status was last updated</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationStatus {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as NotificationStatus);
        }

        /// <summary>
        /// Returns true if NotificationStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationStatus input)
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
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                return hashCode;
            }
        }

    }
}
