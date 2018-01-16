# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://dev-uos-mf-api.eu-west-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthTokenGetPost**](DefaultApi.md#authtokengetpost) | **POST** /auth/token/get | 
[**PlaybackIotDataPost**](DefaultApi.md#playbackiotdatapost) | **POST** /playback/iot/data | 
[**PlaybackMediaDonePost**](DefaultApi.md#playbackmediadonepost) | **POST** /playback/media/done | 
[**PlaybackMediaShowPost**](DefaultApi.md#playbackmediashowpost) | **POST** /playback/media/show | 
[**PlaybackMediaTransitioningPost**](DefaultApi.md#playbackmediatransitioningpost) | **POST** /playback/media/transitioning | 
[**PlaybackSceneShowPost**](DefaultApi.md#playbacksceneshowpost) | **POST** /playback/scene/show | 
[**PlaybackSceneThemeShowPost**](DefaultApi.md#playbackscenethemeshowpost) | **POST** /playback/scene/theme/show | 
[**PlaybackScenesShowPost**](DefaultApi.md#playbackscenesshowpost) | **POST** /playback/scenes/show | 
[**PlaybackScenesThemesPermutationsGet**](DefaultApi.md#playbackscenesthemespermutationsget) | **GET** /playback/scenes/themes/permutations | 
[**PlaybackScenesThemesShowPost**](DefaultApi.md#playbackscenesthemesshowpost) | **POST** /playback/scenes/themes/show | 
[**PlaybackTagMatcherSetPost**](DefaultApi.md#playbacktagmatchersetpost) | **POST** /playback/tag/matcher/set | 
[**PlaybackThemeShowPost**](DefaultApi.md#playbackthemeshowpost) | **POST** /playback/theme/show | 
[**SceneFindByNameGet**](DefaultApi.md#scenefindbynameget) | **GET** /scene/find/by/name | 
[**SceneFullGet**](DefaultApi.md#scenefullget) | **GET** /scene/full | 
[**SceneListGet**](DefaultApi.md#scenelistget) | **GET** /scene/list | 


<a name="authtokengetpost"></a>
# **AuthTokenGetPost**
> SessionResult AuthTokenGetPost (Password creds)



As a client, get a valid session token for the API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthTokenGetPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var creds = new Password(); // Password | A password key

            try
            {
                SessionResult result = apiInstance.AuthTokenGetPost(creds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthTokenGetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creds** | [**Password**](Password.md)| A password key | 

### Return type

[**SessionResult**](SessionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackiotdatapost"></a>
# **PlaybackIotDataPost**
> ApiAck PlaybackIotDataPost (Data data)



When a client begins transitioning a piece of media

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackIotDataPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var data = new Data(); // Data | a schemaless data object from an IoT device

            try
            {
                ApiAck result = apiInstance.PlaybackIotDataPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackIotDataPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Data**](Data.md)| a schemaless data object from an IoT device | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackmediadonepost"></a>
# **PlaybackMediaDonePost**
> ApiAck PlaybackMediaDonePost (MediaCommand finished)



When a client begins transitioning a piece of media

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackMediaDonePostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var finished = new MediaCommand(); // MediaCommand | the media object finished by a client

            try
            {
                ApiAck result = apiInstance.PlaybackMediaDonePost(finished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackMediaDonePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **finished** | [**MediaCommand**](MediaCommand.md)| the media object finished by a client | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackmediashowpost"></a>
# **PlaybackMediaShowPost**
> ApiAck PlaybackMediaShowPost (MediaCommand play)



Playback media

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackMediaShowPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new MediaCommand(); // MediaCommand | A play request

            try
            {
                ApiAck result = apiInstance.PlaybackMediaShowPost(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackMediaShowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**MediaCommand**](MediaCommand.md)| A play request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackmediatransitioningpost"></a>
# **PlaybackMediaTransitioningPost**
> ApiAck PlaybackMediaTransitioningPost (MediaCommand transitioning)



When a client begins transitioning a piece of media

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackMediaTransitioningPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var transitioning = new MediaCommand(); // MediaCommand | the media object being transitioned by a client

            try
            {
                ApiAck result = apiInstance.PlaybackMediaTransitioningPost(transitioning);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackMediaTransitioningPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transitioning** | [**MediaCommand**](MediaCommand.md)| the media object being transitioned by a client | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbacksceneshowpost"></a>
# **PlaybackSceneShowPost**
> ApiAck PlaybackSceneShowPost (PlayScene play)



Show scene

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackSceneShowPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new PlayScene(); // PlayScene | A play request

            try
            {
                ApiAck result = apiInstance.PlaybackSceneShowPost(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackSceneShowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**PlayScene**](PlayScene.md)| A play request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackscenethemeshowpost"></a>
# **PlaybackSceneThemeShowPost**
> ApiAck PlaybackSceneThemeShowPost (PlaySceneTheme play)



Show scene theme

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackSceneThemeShowPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new PlaySceneTheme(); // PlaySceneTheme | A play request

            try
            {
                ApiAck result = apiInstance.PlaybackSceneThemeShowPost(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackSceneThemeShowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**PlaySceneTheme**](PlaySceneTheme.md)| A play request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackscenesshowpost"></a>
# **PlaybackScenesShowPost**
> ApiAck PlaybackScenesShowPost (PlayScenes play)



Show scenes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackScenesShowPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new PlayScenes(); // PlayScenes | A play request

            try
            {
                ApiAck result = apiInstance.PlaybackScenesShowPost(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackScenesShowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**PlayScenes**](PlayScenes.md)| A play request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackscenesthemespermutationsget"></a>
# **PlaybackScenesThemesPermutationsGet**
> SceneThemes PlaybackScenesThemesPermutationsGet (Play play)



Get a list of every unique permutations of SceneTheme from a bucket of Scenes and Themes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackScenesThemesPermutationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new Play(); // Play | A play request

            try
            {
                SceneThemes result = apiInstance.PlaybackScenesThemesPermutationsGet(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackScenesThemesPermutationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**Play**](Play.md)| A play request | 

### Return type

[**SceneThemes**](SceneThemes.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackscenesthemesshowpost"></a>
# **PlaybackScenesThemesShowPost**
> ApiAck PlaybackScenesThemesShowPost (Play play)



Playback scene and theme combinations from the provided scenes and themes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackScenesThemesShowPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new Play(); // Play | A play request

            try
            {
                ApiAck result = apiInstance.PlaybackScenesThemesShowPost(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackScenesThemesShowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**Play**](Play.md)| A play request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbacktagmatchersetpost"></a>
# **PlaybackTagMatcherSetPost**
> ApiAck PlaybackTagMatcherSetPost (SetTagMatcher matcher)



Set a tag matcher

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackTagMatcherSetPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var matcher = new SetTagMatcher(); // SetTagMatcher | A tag matcher update request

            try
            {
                ApiAck result = apiInstance.PlaybackTagMatcherSetPost(matcher);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackTagMatcherSetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matcher** | [**SetTagMatcher**](SetTagMatcher.md)| A tag matcher update request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playbackthemeshowpost"></a>
# **PlaybackThemeShowPost**
> ApiAck PlaybackThemeShowPost (PlayTheme play)



Show theme

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PlaybackThemeShowPostExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var play = new PlayTheme(); // PlayTheme | A play request

            try
            {
                ApiAck result = apiInstance.PlaybackThemeShowPost(play);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PlaybackThemeShowPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **play** | [**PlayTheme**](PlayTheme.md)| A play request | 

### Return type

[**ApiAck**](ApiAck.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scenefindbynameget"></a>
# **SceneFindByNameGet**
> MediaSceneSchema SceneFindByNameGet (string sceneName)



Get a media scene.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SceneFindByNameGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var sceneName = sceneName_example;  // string | A scene name

            try
            {
                MediaSceneSchema result = apiInstance.SceneFindByNameGet(sceneName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SceneFindByNameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sceneName** | **string**| A scene name | 

### Return type

[**MediaSceneSchema**](MediaSceneSchema.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scenefullget"></a>
# **SceneFullGet**
> MediaSceneSchema SceneFullGet (string sceneId)



Get a media scene with any uploaded media object full database details appended.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SceneFullGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var sceneId = sceneId_example;  // string | A scene id

            try
            {
                MediaSceneSchema result = apiInstance.SceneFullGet(sceneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SceneFullGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sceneId** | **string**| A scene id | 

### Return type

[**MediaSceneSchema**](MediaSceneSchema.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scenelistget"></a>
# **SceneListGet**
> SceneList SceneListGet ()



Get a list of media scenes (_id, names and _groupID)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SceneListGetExample
    {
        public void main()
        {
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                SceneList result = apiInstance.SceneListGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SceneListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SceneList**](SceneList.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

