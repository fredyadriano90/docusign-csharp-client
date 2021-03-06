/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// RecipientEmail
    /// </summary>
    [DataContract]
    public partial class RecipientEmail :  IEquatable<RecipientEmail>, IValidatableObject
    {
        public RecipientEmail()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientEmail" /> class.
        /// </summary>
        /// <param name="AccountId">The account ID associated with the envelope..</param>
        /// <param name="AccountName">.</param>
        /// <param name="Email">.</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="Name">.</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="Supported">.</param>
        /// <param name="UserId">.</param>
        public RecipientEmail(string AccountId = default(string), string AccountName = default(string), string Email = default(string), string EnvelopeId = default(string), string Name = default(string), string RecipientId = default(string), bool? Supported = default(bool?), string UserId = default(string))
        {
            this.AccountId = AccountId;
            this.AccountName = AccountName;
            this.Email = Email;
            this.EnvelopeId = EnvelopeId;
            this.Name = Name;
            this.RecipientId = RecipientId;
            this.Supported = Supported;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool? Supported { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientEmail {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecipientEmail);
        }

        /// <summary>
        /// Returns true if RecipientEmail instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientEmail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.Equals(other.Supported)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.Supported != null)
                    hash = hash * 59 + this.Supported.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
