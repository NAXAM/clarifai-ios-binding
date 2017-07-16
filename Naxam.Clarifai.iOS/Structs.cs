using System;
using ObjCRuntime;

namespace ClarifaiSDK
{
	[Native]
	public enum ClarifaiModelType : long
	{
		Concept,
		Embed,
		FaceDetect,
		Detection,
		Cluster,
		Color,
		Blur,
		Unsupported
	}

	[Native]
	public enum ClarifaiRadiusUnit : long
	{
		Miles,
		Kilometers,
		Degrees,
		Radians
	}
}
