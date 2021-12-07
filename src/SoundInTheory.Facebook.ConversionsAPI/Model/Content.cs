/*
 * Facebook Conversions API (for Web)
 *
 * The Conversions API (for web) allows advertisers to send web events from their servers directly to Facebook. Conversions API events are linked to a pixel and are processed like browser pixel events. This means that these conversion events are used in measurement, reporting, and optimization in the same way as browser pixel events.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: web_signals_integrations@fb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = SoundInTheory.Facebook.ConversionsAPI.Client.OpenAPIDateConverter;

namespace SoundInTheory.Facebook.ConversionsAPI.Model
{
    /// <summary>
    /// An object that contain the product IDs associated with the event plus information about the products.
    /// </summary>
    [DataContract]
    public partial class Content :  IEquatable<Content>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        /// <param name="id">Product Id.</param>
        /// <param name="quantity">number of product.</param>
        /// <param name="itemPrice">Item Price..</param>
        public Content(string id = default(string), int quantity = default(int), float itemPrice = default(float))
        {
            this.Id = id;
            this.Quantity = quantity;
            this.ItemPrice = itemPrice;
        }

        /// <summary>
        /// Product Id
        /// </summary>
        /// <value>Product Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// number of product
        /// </summary>
        /// <value>number of product</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Item Price.
        /// </summary>
        /// <value>Item Price.</value>
        [DataMember(Name="item_price", EmitDefaultValue=false)]
        public float ItemPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Content {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
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
            return this.Equals(input as Content);
        }

        /// <summary>
        /// Returns true if Content instances are equal
        /// </summary>
        /// <param name="input">Instance of Content to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Content input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ItemPrice == input.ItemPrice ||
                    (this.ItemPrice != null &&
                    this.ItemPrice.Equals(input.ItemPrice))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ItemPrice != null)
                    hashCode = hashCode * 59 + this.ItemPrice.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
