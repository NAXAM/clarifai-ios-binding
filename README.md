# Clarifai Xamarin.iOS Client
A client for iOS apps using the Clarifai V2 API.

* Sign up for a free developer account at: https://developer.clarifai.com/signup/
* Read the developer guide at: https://developer.clarifai.com/guide/
* Read the full Objective-C docs at: http://cocoadocs.org/docsets/Clarifai/

## Getting Started

1. Create a new XCode project, or use a current one.

2. Add Clarifai to your Podfile and generate workspace. 
```
Install-Package Naxam.Clarifai.iOS
```

3. Go to [developer.clarifai.com/applications](https://developer.clarifai.com/applications), click
on your application, then copy your app's API Key (if you don't already
have an account or application, you'll need to sign up first).

5. Create your Clarifai application in your project.
```c#
var app = new ClarifaiApp("{YOUR-API-KEY}");
```
6. That's it! Explore the [API docs and guide](https://developer.clarifai.com).

## Documentation

The most recent docs can be found [here](http://cocoadocs.org/docsets/Clarifai/) on Cocoadocs. 