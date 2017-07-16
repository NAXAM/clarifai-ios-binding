using System;
using ObjCRuntime;

namespace ClarifaiSDK
{
	[Native]
	public enum ClarifaiModelType : nint
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
	public enum ClarifaiRadiusUnit : nint
	{
		Miles,
		Kilometers,
		Degrees,
		Radians
	}
}
