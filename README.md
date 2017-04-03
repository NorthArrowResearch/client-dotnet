# GeoOptix API .NET Client

This project is a lightweight .NET client for the GeoOptix Web API V1. It provides language bindings for each of they core objects exposed in the API, as well as methods for making requests on those objects. Since many of the API calls require an OpenID Connect tokens issued by our Keystone Identity Manager, a .NET client is included for these calls as well.

## Motivation

The purpose of this project is to provide GeoOptix developers with a free .NET language binding to the API to help them get jump start writing .NET applications against the GeoOptix API.

## Prerequisites

This project is provided in source form only, which naturally means you'll need Visual Studio to compile it. There are a couple of nuget packages used by this solution that Visual Studio will happily download for you as part of the build process. 

To develop applications that use the OpenID Connect Resource Owner flow, you will also need a Client ID and Client Secret. If you dont have these yet for your client, please send an email to our [technical support team](mailto://support@sitkatech.com) and we'll review the request and assist in get your client application registered.

Finally, depending on what you're trying to do with the API, you may need an account on the Keystone Identity Manager to test with. If you don't have one of those yet, you can get one by visiting our [Account Request](https://keystone.sitkatech.com/Account/Register) page.

## Code Example

First we need to get an authentication token, in this case using the Resource Owner flow:

```csharp
  var client = new TokenClient(authUrl, clientIdentifier, clientSecret);
  var result = client.RequestResourceOwnerPasswordAsync(username, password, "openid profile").Result;
```

And here is an example of a call to get the details about a fictitious program object named "myprogram":
```csharp
  ApiHelper helper = new ApiHelper(apiUrl, authUrl, clientID, clientSecret, userName, password);
  var response = helper.Get<ProgramModel>("program", "myprogram");
  Console.WriteLine(response.Payload.FullName);
```

## API Reference

The [GeoOptix API](http://docs.geooptixv1.apiary.io/#) is documented on Apiary, and the [Keystone Identity Manager API](http://apidocs.sitkatech.com/keystone/v1/) soon will be!

## Tests

There aren't currently any tests for this project, but they are on our to-do list!

## Contributors

This is a beta version of what we hope will eventually be a truly robust and unit tested .NET client for GeoOptix. We welcome pull requests from our development partners and friends. If you don't want to contribute but are having difficulties using this code, please use the github issue tracker to let us know what's not working and we'll do our best to straighten it out pronto.

## License

Licensed under the [Apache License, Version 2.0](http://www.apache.org/licenses/LICENSE-2.0)
