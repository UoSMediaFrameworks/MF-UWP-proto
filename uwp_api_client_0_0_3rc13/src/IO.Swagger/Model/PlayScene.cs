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
    /// PlayScene
    /// </summary>
    [DataContract]
    public partial class PlayScene :  IEquatable<PlayScene>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayScene" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayScene() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayScene" /> class.
        /// </summary>
        /// <param name="RoomId">The playback room.</param>
        /// <param name="Scene">Scene (required).</param>
        public PlayScene(string RoomId = default(string), Scene Scene = default(Scene))
        {
            // to ensure "Scene" is required (not null)
            if (Scene == null)
            {
                throw new InvalidDataException("Scene is a required property for PlayScene and cannot be null");
            }
            else
            {
                this.Scene = Scene;
            }
            this.RoomId = RoomId;
        }
        
        /// <summary>
        /// The playback room
        /// </summary>
        /// <value>The playback room</value>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// Gets or Sets Scene
        /// </summary>
        [DataMember(Name="scene", EmitDefaultValue=false)]
        public Scene Scene { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayScene {\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
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
            return this.Equals(obj as PlayScene);
        }

        /// <summary>
        /// Returns true if PlayScene instances are equal
        /// </summary>
        /// <param name="other">Instance of PlayScene to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayScene other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) && 
                (
                    this.Scene == other.Scene ||
                    this.Scene != null &&
                    this.Scene.Equals(other.Scene)
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
                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();
                if (this.Scene != null)
                    hash = hash * 59 + this.Scene.GetHashCode();
                return hash;
            }
        }
    }

}