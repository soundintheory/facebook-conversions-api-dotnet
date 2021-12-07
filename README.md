# SoundInTheory.Facebook.ConversionsAPI - the C# library for the Facebook Conversions API (for Web)

The Conversions API (for web) allows advertisers to send web events from their servers directly to Facebook. Conversions API events are linked to a pixel and are processed like browser pixel events. This means that these conversion events are used in measurement, reporting, and optimization in the same way as browser pixel events.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 0.1.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using SoundInTheory.Facebook.ConversionsAPI.Api;
using SoundInTheory.Facebook.ConversionsAPI.Client;
using SoundInTheory.Facebook.ConversionsAPI.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out SoundInTheory.Facebook.ConversionsAPI.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SoundInTheory.Facebook.ConversionsAPI.Api;
using SoundInTheory.Facebook.ConversionsAPI.Client;
using SoundInTheory.Facebook.ConversionsAPI.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://graph.facebook.com/v8.0";
            // Configure API key authorization: facebook_api_key
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

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

## Documentation for API Endpoints

All URIs are relative to *https://graph.facebook.com/v8.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**PixelIdEventsPost**](docs/DefaultApi.md#pixelideventspost) | **POST** /{pixelId}/events | 


## Documentation for Models

 - [Model.Content](docs/Content.md)
 - [Model.CustomData](docs/CustomData.md)
 - [Model.EventRequest](docs/EventRequest.md)
 - [Model.ModelEvent](docs/ModelEvent.md)
 - [Model.ResponseError](docs/ResponseError.md)
 - [Model.ResponseErrorError](docs/ResponseErrorError.md)
 - [Model.ResponseSuccess](docs/ResponseSuccess.md)
 - [Model.UserData](docs/UserData.md)


## Documentation for Authorization


### facebook_api_key

- **Type**: API key

- **API key parameter name**: access_token
- **Location**: URL query string
