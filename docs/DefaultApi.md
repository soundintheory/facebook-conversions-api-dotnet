# SoundInTheory.Facebook.ConversionsAPI.Api.DefaultApi

All URIs are relative to *https://graph.facebook.com/v8.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PixelIdEventsPost**](DefaultApi.md#pixelideventspost) | **POST** /{pixelId}/events | 



## PixelIdEventsPost

> ResponseSuccess PixelIdEventsPost (string pixelId, EventRequest body)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SoundInTheory.Facebook.ConversionsAPI.Api;
using SoundInTheory.Facebook.ConversionsAPI.Client;
using SoundInTheory.Facebook.ConversionsAPI.Model;

namespace Example
{
    public class PixelIdEventsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://graph.facebook.com/v8.0";
            // Configure API key authorization: facebook_api_key
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var pixelId = pixelId_example;  // string | 
            var body = new EventRequest(); // EventRequest | Facebook Conversions API (for Web) post request

            try
            {
                ResponseSuccess result = apiInstance.PixelIdEventsPost(pixelId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PixelIdEventsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pixelId** | **string**|  | 
 **body** | [**EventRequest**](EventRequest.md)| Facebook Conversions API (for Web) post request | 

### Return type

[**ResponseSuccess**](ResponseSuccess.md)

### Authorization

[facebook_api_key](../README.md#facebook_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | unsuccessful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

