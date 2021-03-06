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
    /// MaxOnScreenSchema
    /// </summary>
    [DataContract]
    public partial class MaxOnScreenSchema :  IEquatable<MaxOnScreenSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaxOnScreenSchema" /> class.
        /// </summary>
        /// <param name="Audio">Audio.</param>
        /// <param name="Image">Image.</param>
        /// <param name="Video">Video.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Id">Id.</param>
        public MaxOnScreenSchema(decimal? Audio = default(decimal?), decimal? Image = default(decimal?), decimal? Video = default(decimal?), decimal? Text = default(decimal?), string Id = default(string))
        {
            this.Audio = Audio;
            this.Image = Image;
            this.Video = Video;
            this.Text = Text;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public decimal? Audio { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public decimal? Image { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public decimal? Video { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public decimal? Text { get; set; }

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
            sb.Append("class MaxOnScreenSchema {\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as MaxOnScreenSchema);
        }

        /// <summary>
        /// Returns true if MaxOnScreenSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of MaxOnScreenSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaxOnScreenSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Audio == other.Audio ||
                    this.Audio != null &&
                    this.Audio.Equals(other.Audio)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Audio != null)
                    hash = hash * 59 + this.Audio.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}
