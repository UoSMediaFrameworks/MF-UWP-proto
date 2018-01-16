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
    /// MediaSceneSchema
    /// </summary>
    [DataContract]
    public partial class MediaSceneSchema :  IEquatable<MediaSceneSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSceneSchema" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Version.</param>
        /// <param name="MaximumOnScreen">MaximumOnScreen.</param>
        /// <param name="DisplayDuration">DisplayDuration.</param>
        /// <param name="DisplayInterval">DisplayInterval.</param>
        /// <param name="TransitionDuration">TransitionDuration.</param>
        /// <param name="IsLinear">IsLinear.</param>
        /// <param name="IsLinearOptions">IsLinearOptions.</param>
        /// <param name="ForceFullSequencePlayback">ForceFullSequencePlayback.</param>
        /// <param name="Scene">Scene.</param>
        /// <param name="Id">Id.</param>
        public MediaSceneSchema(string Name = default(string), string Version = default(string), MaxOnScreenSchema MaximumOnScreen = default(MaxOnScreenSchema), decimal? DisplayDuration = default(decimal?), decimal? DisplayInterval = default(decimal?), decimal? TransitionDuration = default(decimal?), string IsLinear = default(string), string IsLinearOptions = default(string), bool? ForceFullSequencePlayback = default(bool?), List<MediaAssetSchema> Scene = default(List<MediaAssetSchema>), string Id = default(string))
        {
            this.Name = Name;
            this.Version = Version;
            this.MaximumOnScreen = MaximumOnScreen;
            this.DisplayDuration = DisplayDuration;
            this.DisplayInterval = DisplayInterval;
            this.TransitionDuration = TransitionDuration;
            this.IsLinear = IsLinear;
            this.IsLinearOptions = IsLinearOptions;
            this.ForceFullSequencePlayback = ForceFullSequencePlayback;
            this.Scene = Scene;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets MaximumOnScreen
        /// </summary>
        [DataMember(Name="maximumOnScreen", EmitDefaultValue=false)]
        public MaxOnScreenSchema MaximumOnScreen { get; set; }

        /// <summary>
        /// Gets or Sets DisplayDuration
        /// </summary>
        [DataMember(Name="displayDuration", EmitDefaultValue=false)]
        public decimal? DisplayDuration { get; set; }

        /// <summary>
        /// Gets or Sets DisplayInterval
        /// </summary>
        [DataMember(Name="displayInterval", EmitDefaultValue=false)]
        public decimal? DisplayInterval { get; set; }

        /// <summary>
        /// Gets or Sets TransitionDuration
        /// </summary>
        [DataMember(Name="transitionDuration", EmitDefaultValue=false)]
        public decimal? TransitionDuration { get; set; }

        /// <summary>
        /// Gets or Sets IsLinear
        /// </summary>
        [DataMember(Name="isLinear", EmitDefaultValue=false)]
        public string IsLinear { get; set; }

        /// <summary>
        /// Gets or Sets IsLinearOptions
        /// </summary>
        [DataMember(Name="isLinearOptions", EmitDefaultValue=false)]
        public string IsLinearOptions { get; set; }

        /// <summary>
        /// Gets or Sets ForceFullSequencePlayback
        /// </summary>
        [DataMember(Name="forceFullSequencePlayback", EmitDefaultValue=false)]
        public bool? ForceFullSequencePlayback { get; set; }

        /// <summary>
        /// Gets or Sets Scene
        /// </summary>
        [DataMember(Name="scene", EmitDefaultValue=false)]
        public List<MediaAssetSchema> Scene { get; set; }

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
            sb.Append("class MediaSceneSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  MaximumOnScreen: ").Append(MaximumOnScreen).Append("\n");
            sb.Append("  DisplayDuration: ").Append(DisplayDuration).Append("\n");
            sb.Append("  DisplayInterval: ").Append(DisplayInterval).Append("\n");
            sb.Append("  TransitionDuration: ").Append(TransitionDuration).Append("\n");
            sb.Append("  IsLinear: ").Append(IsLinear).Append("\n");
            sb.Append("  IsLinearOptions: ").Append(IsLinearOptions).Append("\n");
            sb.Append("  ForceFullSequencePlayback: ").Append(ForceFullSequencePlayback).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
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
            return this.Equals(obj as MediaSceneSchema);
        }

        /// <summary>
        /// Returns true if MediaSceneSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaSceneSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSceneSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.MaximumOnScreen == other.MaximumOnScreen ||
                    this.MaximumOnScreen != null &&
                    this.MaximumOnScreen.Equals(other.MaximumOnScreen)
                ) && 
                (
                    this.DisplayDuration == other.DisplayDuration ||
                    this.DisplayDuration != null &&
                    this.DisplayDuration.Equals(other.DisplayDuration)
                ) && 
                (
                    this.DisplayInterval == other.DisplayInterval ||
                    this.DisplayInterval != null &&
                    this.DisplayInterval.Equals(other.DisplayInterval)
                ) && 
                (
                    this.TransitionDuration == other.TransitionDuration ||
                    this.TransitionDuration != null &&
                    this.TransitionDuration.Equals(other.TransitionDuration)
                ) && 
                (
                    this.IsLinear == other.IsLinear ||
                    this.IsLinear != null &&
                    this.IsLinear.Equals(other.IsLinear)
                ) && 
                (
                    this.IsLinearOptions == other.IsLinearOptions ||
                    this.IsLinearOptions != null &&
                    this.IsLinearOptions.Equals(other.IsLinearOptions)
                ) && 
                (
                    this.ForceFullSequencePlayback == other.ForceFullSequencePlayback ||
                    this.ForceFullSequencePlayback != null &&
                    this.ForceFullSequencePlayback.Equals(other.ForceFullSequencePlayback)
                ) && 
                (
                    this.Scene == other.Scene ||
                    this.Scene != null &&
                    this.Scene.SequenceEqual(other.Scene)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.MaximumOnScreen != null)
                    hash = hash * 59 + this.MaximumOnScreen.GetHashCode();
                if (this.DisplayDuration != null)
                    hash = hash * 59 + this.DisplayDuration.GetHashCode();
                if (this.DisplayInterval != null)
                    hash = hash * 59 + this.DisplayInterval.GetHashCode();
                if (this.TransitionDuration != null)
                    hash = hash * 59 + this.TransitionDuration.GetHashCode();
                if (this.IsLinear != null)
                    hash = hash * 59 + this.IsLinear.GetHashCode();
                if (this.IsLinearOptions != null)
                    hash = hash * 59 + this.IsLinearOptions.GetHashCode();
                if (this.ForceFullSequencePlayback != null)
                    hash = hash * 59 + this.ForceFullSequencePlayback.GetHashCode();
                if (this.Scene != null)
                    hash = hash * 59 + this.Scene.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}