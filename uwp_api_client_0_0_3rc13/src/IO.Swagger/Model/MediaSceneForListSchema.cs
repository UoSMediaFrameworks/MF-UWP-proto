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
    /// MediaSceneForListSchema
    /// </summary>
    [DataContract]
    public partial class MediaSceneForListSchema :  IEquatable<MediaSceneForListSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSceneForListSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaSceneForListSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSceneForListSchema" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="GroupID">GroupID (required).</param>
        public MediaSceneForListSchema(string Id = default(string), string Name = default(string), int? GroupID = default(int?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for MediaSceneForListSchema and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for MediaSceneForListSchema and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "GroupID" is required (not null)
            if (GroupID == null)
            {
                throw new InvalidDataException("GroupID is a required property for MediaSceneForListSchema and cannot be null");
            }
            else
            {
                this.GroupID = GroupID;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets GroupID
        /// </summary>
        [DataMember(Name="_groupID", EmitDefaultValue=false)]
        public int? GroupID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSceneForListSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupID: ").Append(GroupID).Append("\n");
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
            return this.Equals(obj as MediaSceneForListSchema);
        }

        /// <summary>
        /// Returns true if MediaSceneForListSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaSceneForListSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSceneForListSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.GroupID == other.GroupID ||
                    this.GroupID != null &&
                    this.GroupID.Equals(other.GroupID)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.GroupID != null)
                    hash = hash * 59 + this.GroupID.GetHashCode();
                return hash;
            }
        }
    }

}
