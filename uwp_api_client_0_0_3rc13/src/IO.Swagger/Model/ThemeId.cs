/* 
 * uos-mf-api-controller
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ThemeId
    /// </summary>
    [DataContract]
    public partial class ThemeId :  IEquatable<ThemeId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThemeId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeId" /> class.
        /// </summary>
        /// <param name="Theme">Theme (required).</param>
        public ThemeId(string Theme = default(string))
        {
            // to ensure "Theme" is required (not null)
            if (Theme == null)
            {
                throw new InvalidDataException("Theme is a required property for ThemeId and cannot be null");
            }
            else
            {
                this.Theme = Theme;
            }
        }
        
        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name="theme", EmitDefaultValue=false)]
        public string Theme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThemeId {\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
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
            return this.Equals(obj as ThemeId);
        }

        /// <summary>
        /// Returns true if ThemeId instances are equal
        /// </summary>
        /// <param name="other">Instance of ThemeId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThemeId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Theme == other.Theme ||
                    this.Theme != null &&
                    this.Theme.Equals(other.Theme)
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
                if (this.Theme != null)
                    hash = hash * 59 + this.Theme.GetHashCode();
                return hash;
            }
        }
    }

}