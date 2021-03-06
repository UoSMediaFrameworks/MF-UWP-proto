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
    /// MediaAssetSchemaCuePointEvents
    /// </summary>
    [DataContract]
    public partial class MediaAssetSchemaCuePointEvents :  IEquatable<MediaAssetSchemaCuePointEvents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetSchemaCuePointEvents" /> class.
        /// </summary>
        /// <param name="TimeElapsed">TimeElapsed.</param>
        /// <param name="Themes">Themes.</param>
        /// <param name="Id">Id.</param>
        public MediaAssetSchemaCuePointEvents(decimal? TimeElapsed = default(decimal?), List<Object> Themes = default(List<Object>), string Id = default(string))
        {
            this.TimeElapsed = TimeElapsed;
            this.Themes = Themes;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets TimeElapsed
        /// </summary>
        [DataMember(Name="timeElapsed", EmitDefaultValue=false)]
        public decimal? TimeElapsed { get; set; }

        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<Object> Themes { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaAssetSchemaCuePointEvents {\n");
            sb.Append("  TimeElapsed: ").Append(TimeElapsed).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as MediaAssetSchemaCuePointEvents);
        }

        /// <summary>
        /// Returns true if MediaAssetSchemaCuePointEvents instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaAssetSchemaCuePointEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaAssetSchemaCuePointEvents other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TimeElapsed == other.TimeElapsed ||
                    this.TimeElapsed != null &&
                    this.TimeElapsed.Equals(other.TimeElapsed)
                ) && 
                (
                    this.Themes == other.Themes ||
                    this.Themes != null &&
                    this.Themes.SequenceEqual(other.Themes)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.TimeElapsed != null)
                    hash = hash * 59 + this.TimeElapsed.GetHashCode();
                if (this.Themes != null)
                    hash = hash * 59 + this.Themes.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}
