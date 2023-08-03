/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.804
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
    /// The information required to update an Email notification
    /// </summary>
    [DataContract(Name = "UpdateEmailNotification")]
    public partial class UpdateEmailNotification : IEquatable<UpdateEmailNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmailNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateEmailNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmailNotification" /> class.
        /// </summary>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="subject">The subject of the email (required).</param>
        /// <param name="plainTextBody">The plain text body of the email (required).</param>
        /// <param name="htmlBody">The HTML body of the email (if any).</param>
        /// <param name="emailAddressTo">&#39;To&#39; recipients of the email (required).</param>
        /// <param name="emailAddressCc">&#39;Cc&#39; recipients of the email.</param>
        /// <param name="emailAddressBcc">&#39;Bcc&#39; recipients of the email.</param>
        public UpdateEmailNotification(string description = default(string), string subject = default(string), string plainTextBody = default(string), string htmlBody = default(string), List<string> emailAddressTo = default(List<string>), List<string> emailAddressCc = default(List<string>), List<string> emailAddressBcc = default(List<string>))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for UpdateEmailNotification and cannot be null");
            // to ensure "subject" is required (not null)
            this.Subject = subject ?? throw new ArgumentNullException("subject is a required property for UpdateEmailNotification and cannot be null");
            // to ensure "plainTextBody" is required (not null)
            this.PlainTextBody = plainTextBody ?? throw new ArgumentNullException("plainTextBody is a required property for UpdateEmailNotification and cannot be null");
            // to ensure "emailAddressTo" is required (not null)
            this.EmailAddressTo = emailAddressTo ?? throw new ArgumentNullException("emailAddressTo is a required property for UpdateEmailNotification and cannot be null");
            this.HtmlBody = htmlBody;
            this.EmailAddressCc = emailAddressCc;
            this.EmailAddressBcc = emailAddressBcc;
        }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The subject of the email
        /// </summary>
        /// <value>The subject of the email</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// The plain text body of the email
        /// </summary>
        /// <value>The plain text body of the email</value>
        [DataMember(Name = "plainTextBody", IsRequired = true, EmitDefaultValue = false)]
        public string PlainTextBody { get; set; }

        /// <summary>
        /// The HTML body of the email (if any)
        /// </summary>
        /// <value>The HTML body of the email (if any)</value>
        [DataMember(Name = "htmlBody", EmitDefaultValue = true)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// &#39;To&#39; recipients of the email
        /// </summary>
        /// <value>&#39;To&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressTo", IsRequired = true, EmitDefaultValue = false)]
        public List<string> EmailAddressTo { get; set; }

        /// <summary>
        /// &#39;Cc&#39; recipients of the email
        /// </summary>
        /// <value>&#39;Cc&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressCc", EmitDefaultValue = true)]
        public List<string> EmailAddressCc { get; set; }

        /// <summary>
        /// &#39;Bcc&#39; recipients of the email
        /// </summary>
        /// <value>&#39;Bcc&#39; recipients of the email</value>
        [DataMember(Name = "emailAddressBcc", EmitDefaultValue = true)]
        public List<string> EmailAddressBcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEmailNotification {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  PlainTextBody: ").Append(PlainTextBody).Append("\n");
            sb.Append("  HtmlBody: ").Append(HtmlBody).Append("\n");
            sb.Append("  EmailAddressTo: ").Append(EmailAddressTo).Append("\n");
            sb.Append("  EmailAddressCc: ").Append(EmailAddressCc).Append("\n");
            sb.Append("  EmailAddressBcc: ").Append(EmailAddressBcc).Append("\n");
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
            return this.Equals(input as UpdateEmailNotification);
        }

        /// <summary>
        /// Returns true if UpdateEmailNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateEmailNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateEmailNotification input)
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
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.PlainTextBody == input.PlainTextBody ||
                    (this.PlainTextBody != null &&
                    this.PlainTextBody.Equals(input.PlainTextBody))
                ) && 
                (
                    this.HtmlBody == input.HtmlBody ||
                    (this.HtmlBody != null &&
                    this.HtmlBody.Equals(input.HtmlBody))
                ) && 
                (
                    this.EmailAddressTo == input.EmailAddressTo ||
                    this.EmailAddressTo != null &&
                    input.EmailAddressTo != null &&
                    this.EmailAddressTo.SequenceEqual(input.EmailAddressTo)
                ) && 
                (
                    this.EmailAddressCc == input.EmailAddressCc ||
                    this.EmailAddressCc != null &&
                    input.EmailAddressCc != null &&
                    this.EmailAddressCc.SequenceEqual(input.EmailAddressCc)
                ) && 
                (
                    this.EmailAddressBcc == input.EmailAddressBcc ||
                    this.EmailAddressBcc != null &&
                    input.EmailAddressBcc != null &&
                    this.EmailAddressBcc.SequenceEqual(input.EmailAddressBcc)
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.PlainTextBody != null)
                    hashCode = hashCode * 59 + this.PlainTextBody.GetHashCode();
                if (this.HtmlBody != null)
                    hashCode = hashCode * 59 + this.HtmlBody.GetHashCode();
                if (this.EmailAddressTo != null)
                    hashCode = hashCode * 59 + this.EmailAddressTo.GetHashCode();
                if (this.EmailAddressCc != null)
                    hashCode = hashCode * 59 + this.EmailAddressCc.GetHashCode();
                if (this.EmailAddressBcc != null)
                    hashCode = hashCode * 59 + this.EmailAddressBcc.GetHashCode();
                return hashCode;
            }
        }

    }
}
