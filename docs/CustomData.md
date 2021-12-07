
# SoundInTheory.Facebook.ConversionsAPI.Model.CustomData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal** | A numeric value associated with this event. This could be a monetary value or a value in some other metric. | [optional] 
**Currency** | **string** | The currency for the value specified, if applicable. Currency must be a valid ISO 4217 (https://en.wikipedia.org/wiki/ISO_4217) three digit currency code. | [optional] 
**ContentName** | **string** | The name of the page or product associated with the event. | [optional] 
**ContentCategory** | **string** | The category of the content associated with the event. | [optional] 
**ContentIds** | **List&lt;string&gt;** | The content IDs associated with the event, such as product SKUs for items in an AddToCart event: [&#39;ABC123&#39;, &#39;XYZ789&#39;]. If content_type is a product, then your content IDs must be an array with a single string value. Otherwise, this array can contain any number of string values. | [optional] 
**Contents** | [**List&lt;Content&gt;**](Content.md) | A list of Content objects that contain the product IDs associated with the event plus information about the products. id, quantity, and item_price are available fields. | [optional] 
**ContentType** | **string** | It should be set to &#39;product&#39; or &#39;product_group&#39;. Use &#39;product&#39;, if the keys you send represent products. Sent keys could be content_ids or contents. Use product_group, if the keys you send in content_ids represent product groups. Product groups are used to distinguish products that are identical but have variations such as color, material, size or pattern. | [optional] 
**OrderId** | **string** | The order ID for this transaction as a String. | [optional] 
**PredictedLtv** | **decimal** | The predicted lifetime value of a conversion event, as a String. | [optional] 
**NumItems** | **int** | Use only with InitiateCheckout events. The number of items that a user tries to buy during checkout. | [optional] 
**SearchString** | **string** | Use only with Search events. A search query made by a user. | [optional] 
**Status** | **string** | Use only with CompleteRegistration events. The status of the registration event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

