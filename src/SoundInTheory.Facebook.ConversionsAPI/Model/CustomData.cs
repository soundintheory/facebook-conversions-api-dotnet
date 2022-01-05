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
    /// An object that includes additional business data about the event which can be used for ads delivery optimization. If our predefined object properties don&#39;t suit your needs, you can include your own, custom properties. Custom properties can be used with both standard and custom events, and can help you further define custom audiences.
    /// </summary>
    [DataContract]
    public partial class CustomData :  IEquatable<CustomData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomData" /> class.
        /// </summary>
        /// <param name="value">A numeric value associated with this event. This could be a monetary value or a value in some other metric..</param>
        /// <param name="currency">The currency for the value specified, if applicable. Currency must be a valid ISO 4217 (https://en.wikipedia.org/wiki/ISO_4217) three digit currency code..</param>
        /// <param name="contentName">The name of the page or product associated with the event..</param>
        /// <param name="contentCategory">The category of the content associated with the event..</param>
        /// <param name="contentIds">The content IDs associated with the event, such as product SKUs for items in an AddToCart event: [&#39;ABC123&#39;, &#39;XYZ789&#39;]. If content_type is a product, then your content IDs must be an array with a single string value. Otherwise, this array can contain any number of string values..</param>
        /// <param name="contents">A list of Content objects that contain the product IDs associated with the event plus information about the products. id, quantity, and item_price are available fields..</param>
        /// <param name="contentType">It should be set to &#39;product&#39; or &#39;product_group&#39;. Use &#39;product&#39;, if the keys you send represent products. Sent keys could be content_ids or contents. Use product_group, if the keys you send in content_ids represent product groups. Product groups are used to distinguish products that are identical but have variations such as color, material, size or pattern..</param>
        /// <param name="orderId">The order ID for this transaction as a String..</param>
        /// <param name="predictedLtv">The predicted lifetime value of a conversion event, as a String..</param>
        /// <param name="numItems">Use only with InitiateCheckout events. The number of items that a user tries to buy during checkout..</param>
        /// <param name="searchString">Use only with Search events. A search query made by a user..</param>
        /// <param name="status">Use only with CompleteRegistration events. The status of the registration event.</param>
        public CustomData(decimal value = default(decimal), string currency = default(string), string contentName = default(string), string contentCategory = default(string), List<string> contentIds = default(List<string>), List<Content> contents = default(List<Content>), string contentType = default(string), string orderId = default(string), decimal predictedLtv = default(decimal), int numItems = default(int), string searchString = default(string), string status = default(string))
        {
            this.Value = value;
            this.Currency = currency;
            this.ContentName = contentName;
            this.ContentCategory = contentCategory;
            this.ContentIds = contentIds;
            this.Contents = contents;
            this.ContentType = contentType;
            this.OrderId = orderId;
            this.PredictedLtv = predictedLtv;
            this.NumItems = numItems;
            this.SearchString = searchString;
            this.Status = status;
        }

        /// <summary>
        /// A numeric value associated with this event. This could be a monetary value or a value in some other metric.
        /// </summary>
        /// <value>A numeric value associated with this event. This could be a monetary value or a value in some other metric.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public decimal Value { get; set; }

        /// <summary>
        /// The currency for the value specified, if applicable. Currency must be a valid ISO 4217 (https://en.wikipedia.org/wiki/ISO_4217) three digit currency code.
        /// </summary>
        /// <value>The currency for the value specified, if applicable. Currency must be a valid ISO 4217 (https://en.wikipedia.org/wiki/ISO_4217) three digit currency code.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The name of the page or product associated with the event.
        /// </summary>
        /// <value>The name of the page or product associated with the event.</value>
        [DataMember(Name="content_name", EmitDefaultValue=false)]
        public string ContentName { get; set; }

        /// <summary>
        /// The category of the content associated with the event.
        /// </summary>
        /// <value>The category of the content associated with the event.</value>
        [DataMember(Name="content_category", EmitDefaultValue=false)]
        public string ContentCategory { get; set; }

        /// <summary>
        /// The content IDs associated with the event, such as product SKUs for items in an AddToCart event: [&#39;ABC123&#39;, &#39;XYZ789&#39;]. If content_type is a product, then your content IDs must be an array with a single string value. Otherwise, this array can contain any number of string values.
        /// </summary>
        /// <value>The content IDs associated with the event, such as product SKUs for items in an AddToCart event: [&#39;ABC123&#39;, &#39;XYZ789&#39;]. If content_type is a product, then your content IDs must be an array with a single string value. Otherwise, this array can contain any number of string values.</value>
        [DataMember(Name="content_ids", EmitDefaultValue=false)]
        public List<string> ContentIds { get; set; }

        /// <summary>
        /// A list of Content objects that contain the product IDs associated with the event plus information about the products. id, quantity, and item_price are available fields.
        /// </summary>
        /// <value>A list of Content objects that contain the product IDs associated with the event plus information about the products. id, quantity, and item_price are available fields.</value>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public List<Content> Contents { get; set; }

        /// <summary>
        /// It should be set to &#39;product&#39; or &#39;product_group&#39;. Use &#39;product&#39;, if the keys you send represent products. Sent keys could be content_ids or contents. Use product_group, if the keys you send in content_ids represent product groups. Product groups are used to distinguish products that are identical but have variations such as color, material, size or pattern.
        /// </summary>
        /// <value>It should be set to &#39;product&#39; or &#39;product_group&#39;. Use &#39;product&#39;, if the keys you send represent products. Sent keys could be content_ids or contents. Use product_group, if the keys you send in content_ids represent product groups. Product groups are used to distinguish products that are identical but have variations such as color, material, size or pattern.</value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The order ID for this transaction as a String.
        /// </summary>
        /// <value>The order ID for this transaction as a String.</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The predicted lifetime value of a conversion event, as a String.
        /// </summary>
        /// <value>The predicted lifetime value of a conversion event, as a String.</value>
        [DataMember(Name="predicted_ltv", EmitDefaultValue=false)]
        public decimal PredictedLtv { get; set; }

        /// <summary>
        /// Use only with InitiateCheckout events. The number of items that a user tries to buy during checkout.
        /// </summary>
        /// <value>Use only with InitiateCheckout events. The number of items that a user tries to buy during checkout.</value>
        [DataMember(Name="num_items", EmitDefaultValue=false)]
        public int NumItems { get; set; }

        /// <summary>
        /// Use only with Search events. A search query made by a user.
        /// </summary>
        /// <value>Use only with Search events. A search query made by a user.</value>
        [DataMember(Name="search_string", EmitDefaultValue=false)]
        public string SearchString { get; set; }

        /// <summary>
        /// Use only with CompleteRegistration events. The status of the registration event
        /// </summary>
        /// <value>Use only with CompleteRegistration events. The status of the registration event</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomData {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ContentName: ").Append(ContentName).Append("\n");
            sb.Append("  ContentCategory: ").Append(ContentCategory).Append("\n");
            sb.Append("  ContentIds: ").Append(ContentIds).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PredictedLtv: ").Append(PredictedLtv).Append("\n");
            sb.Append("  NumItems: ").Append(NumItems).Append("\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as CustomData);
        }

        /// <summary>
        /// Returns true if CustomData instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.ContentName == input.ContentName ||
                    (this.ContentName != null &&
                    this.ContentName.Equals(input.ContentName))
                ) && 
                (
                    this.ContentCategory == input.ContentCategory ||
                    (this.ContentCategory != null &&
                    this.ContentCategory.Equals(input.ContentCategory))
                ) && 
                (
                    this.ContentIds == input.ContentIds ||
                    this.ContentIds != null &&
                    input.ContentIds != null &&
                    this.ContentIds.SequenceEqual(input.ContentIds)
                ) && 
                (
                    this.Contents == input.Contents ||
                    this.Contents != null &&
                    input.Contents != null &&
                    this.Contents.SequenceEqual(input.Contents)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PredictedLtv == input.PredictedLtv ||
                    (this.PredictedLtv != null &&
                    this.PredictedLtv.Equals(input.PredictedLtv))
                ) && 
                (
                    this.NumItems == input.NumItems ||
                    (this.NumItems != null &&
                    this.NumItems.Equals(input.NumItems))
                ) && 
                (
                    this.SearchString == input.SearchString ||
                    (this.SearchString != null &&
                    this.SearchString.Equals(input.SearchString))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ContentName != null)
                    hashCode = hashCode * 59 + this.ContentName.GetHashCode();
                if (this.ContentCategory != null)
                    hashCode = hashCode * 59 + this.ContentCategory.GetHashCode();
                if (this.ContentIds != null)
                    hashCode = hashCode * 59 + this.ContentIds.GetHashCode();
                if (this.Contents != null)
                    hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PredictedLtv != null)
                    hashCode = hashCode * 59 + this.PredictedLtv.GetHashCode();
                if (this.NumItems != null)
                    hashCode = hashCode * 59 + this.NumItems.GetHashCode();
                if (this.SearchString != null)
                    hashCode = hashCode * 59 + this.SearchString.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
