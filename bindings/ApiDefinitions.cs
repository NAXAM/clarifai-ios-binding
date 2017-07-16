using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ClarifaiSDK
{
	// @interface ClarifaiConcept : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiConcept
	{
		// @property (nonatomic, strong) ClarifaiModel * model;
		[Export ("model", ArgumentSemantic.Strong)]
		ClarifaiModel Model { get; set; }

		// @property (nonatomic, strong) NSString * conceptID;
		[Export ("conceptID", ArgumentSemantic.Strong)]
		string ConceptID { get; set; }

		// @property (nonatomic, strong) NSString * conceptName;
		[Export ("conceptName", ArgumentSemantic.Strong)]
		string ConceptName { get; set; }

		// @property (nonatomic, strong) NSString * appID;
		[Export ("appID", ArgumentSemantic.Strong)]
		string AppID { get; set; }

		// @property (nonatomic) NSString * language;
		[Export ("language")]
		string Language { get; set; }

		// @property (nonatomic) float score;
		[Export ("score")]
		float Score { get; set; }

		// -(instancetype)initWithConceptName:(NSString *)conceptName;
		[Export ("initWithConceptName:")]
		IntPtr Constructor (string conceptName);

		// -(instancetype)initWithConceptID:(NSString *)conceptID;
		[Export ("initWithConceptID:")]
		IntPtr Constructor (string conceptID);

		// -(instancetype)initWithConceptName:(NSString *)conceptName conceptID:(NSString *)conceptID;
		[Export ("initWithConceptName:conceptID:")]
		IntPtr Constructor (string conceptName, string conceptID);

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface ClarifaiLocation : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiLocation
	{
		// @property (nonatomic) double latitude;
		[Export ("latitude")]
		double Latitude { get; set; }

		// @property (nonatomic) double longitude;
		[Export ("longitude")]
		double Longitude { get; set; }

		// -(instancetype)initWithLatitude:(double)latitude longitude:(double)longitude;
		[Export ("initWithLatitude:longitude:")]
		IntPtr Constructor (double latitude, double longitude);

		// -(CLLocation *)clLocation;
		[Export ("clLocation")]
		[Verify (MethodToProperty)]
		CLLocation ClLocation { get; }
	}

	// @interface ClarifaiInput : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiInput
	{
		// @property (nonatomic, strong) NSString * inputID;
		[Export ("inputID", ArgumentSemantic.Strong)]
		string InputID { get; set; }

		// @property (nonatomic, strong) NSString * mediaURL;
		[Export ("mediaURL", ArgumentSemantic.Strong)]
		string MediaURL { get; set; }

		// @property (nonatomic, strong) NSData * mediaData;
		[Export ("mediaData", ArgumentSemantic.Strong)]
		NSData MediaData { get; set; }

		// @property (nonatomic, strong) NSDate * creationDate;
		[Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * concepts;
		[Export ("concepts", ArgumentSemantic.Strong)]
		ClarifaiConcept[] Concepts { get; set; }

		// @property BOOL allowDuplicateURLs;
		[Export ("allowDuplicateURLs")]
		bool AllowDuplicateURLs { get; set; }

		// @property (nonatomic, strong) NSDictionary * metadata;
		[Export ("metadata", ArgumentSemantic.Strong)]
		NSDictionary Metadata { get; set; }

		// @property (nonatomic, strong) ClarifaiLocation * location;
		[Export ("location", ArgumentSemantic.Strong)]
		ClarifaiLocation Location { get; set; }

		// -(instancetype)initWithURL:(NSString *)url;
		[Export ("initWithURL:")]
		IntPtr Constructor (string url);

		// -(instancetype)initWithURL:(NSString *)URL andConcepts:(NSArray *)concepts;
		[Export ("initWithURL:andConcepts:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (string URL, NSObject[] concepts);

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface ClarifaiCrop : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiCrop
	{
		// @property (nonatomic) CGFloat top;
		[Export ("top")]
		nfloat Top { get; set; }

		// @property (nonatomic) CGFloat left;
		[Export ("left")]
		nfloat Left { get; set; }

		// @property (nonatomic) CGFloat bottom;
		[Export ("bottom")]
		nfloat Bottom { get; set; }

		// @property (nonatomic) CGFloat right;
		[Export ("right")]
		nfloat Right { get; set; }

		// -(instancetype)initWithTop:(CGFloat)top left:(CGFloat)left bottom:(CGFloat)bottom right:(CGFloat)right;
		[Export ("initWithTop:left:bottom:right:")]
		IntPtr Constructor (nfloat top, nfloat left, nfloat bottom, nfloat right);
	}

	// @interface ClarifaiImage : ClarifaiInput
	[BaseType (typeof(ClarifaiInput))]
	interface ClarifaiImage
	{
		// @property ClarifaiCrop * crop;
		[Export ("crop", ArgumentSemantic.Assign)]
		ClarifaiCrop Crop { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// -(instancetype)initWithImage:(UIImage *)image;
		[Export ("initWithImage:")]
		IntPtr Constructor (UIImage image);

		// -(instancetype)initWithImage:(UIImage *)image andCrop:(ClarifaiCrop *)crop;
		[Export ("initWithImage:andCrop:")]
		IntPtr Constructor (UIImage image, ClarifaiCrop crop);

		// -(instancetype)initWithImage:(UIImage *)image andConcepts:(NSArray *)concepts;
		[Export ("initWithImage:andConcepts:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (UIImage image, NSObject[] concepts);

		// -(instancetype)initWithImage:(UIImage *)image crop:(ClarifaiCrop *)crop andConcepts:(NSArray *)concepts;
		[Export ("initWithImage:crop:andConcepts:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (UIImage image, ClarifaiCrop crop, NSObject[] concepts);

		// -(instancetype)initWithURL:(NSString *)url andCrop:(ClarifaiCrop *)crop;
		[Export ("initWithURL:andCrop:")]
		IntPtr Constructor (string url, ClarifaiCrop crop);

		// -(instancetype)initWithURL:(NSString *)url crop:(ClarifaiCrop *)crop andConcepts:(NSArray *)concepts;
		[Export ("initWithURL:crop:andConcepts:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (string url, ClarifaiCrop crop, NSObject[] concepts);
	}

	// @interface ClarifaiSearchResult : ClarifaiInput
	[BaseType (typeof(ClarifaiInput))]
	interface ClarifaiSearchResult
	{
		// @property (nonatomic, strong) NSNumber * score;
		[Export ("score", ArgumentSemantic.Strong)]
		NSNumber Score { get; set; }
	}

	// typedef void (^ClarifaiRequestCompletion)(NSError *);
	delegate void ClarifaiRequestCompletion (NSError arg0);

	// typedef void (^ClarifaiInputsCompletion)(NSArray<ClarifaiInput *> *, NSError *);
	delegate void ClarifaiInputsCompletion (ClarifaiInput[] arg0, NSError arg1);

	// typedef void (^ClarifaiSearchCompletion)(NSArray<ClarifaiSearchResult *> *, NSError *);
	delegate void ClarifaiSearchCompletion (ClarifaiSearchResult[] arg0, NSError arg1);

	// typedef void (^ClarifaiPredictionsCompletion)(NSArray<ClarifaiOutput *> *, NSError *);
	delegate void ClarifaiPredictionsCompletion (ClarifaiOutput[] arg0, NSError arg1);

	// typedef void (^ClarifaiConceptsCompletion)(NSArray<ClarifaiConcept *> *, NSError *);
	delegate void ClarifaiConceptsCompletion (ClarifaiConcept[] arg0, NSError arg1);

	// typedef void (^ClarifaiStoreInputCompletion)(ClarifaiInput *, NSError *);
	delegate void ClarifaiStoreInputCompletion (ClarifaiInput arg0, NSError arg1);

	// typedef void (^ClarifaiStoreConceptCompletion)(ClarifaiConcept *, NSError *);
	delegate void ClarifaiStoreConceptCompletion (ClarifaiConcept arg0, NSError arg1);

	// typedef void (^ClarifaiInputsStatusCompletion)(int, int, int, NSError *);
	delegate void ClarifaiInputsStatusCompletion (int arg0, int arg1, int arg2, NSError arg3);

	// typedef void (^ClarifaiModelsCompletion)(NSArray<ClarifaiModel *> *, NSError *);
	delegate void ClarifaiModelsCompletion (ClarifaiModel[] arg0, NSError arg1);

	// typedef void (^ClarifaiModelCompletion)(ClarifaiModel *, NSError *);
	delegate void ClarifaiModelCompletion (ClarifaiModel arg0, NSError arg1);

	// typedef void (^ClarifaiModelVersionsCompletion)(NSArray<ClarifaiModelVersion *> *, NSError *);
	delegate void ClarifaiModelVersionsCompletion (ClarifaiModelVersion[] arg0, NSError arg1);

	// typedef void (^ClarifaiModelVersionCompletion)(ClarifaiModelVersion *, NSError *);
	delegate void ClarifaiModelVersionCompletion (ClarifaiModelVersion arg0, NSError arg1);

	// typedef void (^ClarifaiSearchConceptCompletion)(NSArray<ClarifaiConcept *> *, NSError *);
	delegate void ClarifaiSearchConceptCompletion (ClarifaiConcept[] arg0, NSError arg1);

	// @interface ClarifaiModelVersion : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiModelVersion
	{
		// @property (nonatomic, strong) NSString * versionID;
		[Export ("versionID", ArgumentSemantic.Strong)]
		string VersionID { get; set; }

		// @property (nonatomic, strong) NSDate * createdAt;
		[Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSNumber * statusCode;
		[Export ("statusCode", ArgumentSemantic.Strong)]
		NSNumber StatusCode { get; set; }

		// @property (nonatomic, strong) NSString * statusDescription;
		[Export ("statusDescription", ArgumentSemantic.Strong)]
		string StatusDescription { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface ClarifaiModel : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiModel
	{
		// @property (nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * modelID;
		[Export ("modelID", ArgumentSemantic.Strong)]
		string ModelID { get; set; }

		// @property (nonatomic, strong) NSDate * createdAt;
		[Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * appID;
		[Export ("appID", ArgumentSemantic.Strong)]
		string AppID { get; set; }

		// @property (nonatomic) ClarifaiModelType modelType;
		[Export ("modelType", ArgumentSemantic.Assign)]
		ClarifaiModelType ModelType { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * concepts;
		[Export ("concepts", ArgumentSemantic.Strong)]
		ClarifaiConcept[] Concepts { get; set; }

		// @property BOOL conceptsMututallyExclusive;
		[Export ("conceptsMututallyExclusive")]
		bool ConceptsMututallyExclusive { get; set; }

		// @property BOOL closedEnvironment;
		[Export ("closedEnvironment")]
		bool ClosedEnvironment { get; set; }

		// @property (nonatomic, strong) ClarifaiModelVersion * version;
		[Export ("version", ArgumentSemantic.Strong)]
		ClarifaiModelVersion Version { get; set; }

		// @property (nonatomic, strong) ClarifaiApp * app;
		[Export ("app", ArgumentSemantic.Strong)]
		ClarifaiApp App { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(void)train:(ClarifaiModelVersionCompletion)completion;
		[Export ("train:")]
		void Train (ClarifaiModelVersionCompletion completion);

		// -(void)predictOnImages:(NSArray<ClarifaiImage *> *)images completion:(ClarifaiPredictionsCompletion)completion;
		[Export ("predictOnImages:completion:")]
		void PredictOnImages (ClarifaiImage[] images, ClarifaiPredictionsCompletion completion);

		// -(void)predictOnImages:(NSArray<ClarifaiImage *> *)images withLanguage:(NSString *)language completion:(ClarifaiPredictionsCompletion)completion;
		[Export ("predictOnImages:withLanguage:completion:")]
		void PredictOnImages (ClarifaiImage[] images, string language, ClarifaiPredictionsCompletion completion);

		// -(void)listVersions:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiModelVersionsCompletion)completion;
		[Export ("listVersions:resultsPerPage:completion:")]
		void ListVersions (int page, int resultsPerPage, ClarifaiModelVersionsCompletion completion);

		// -(void)getVersion:(NSString *)versionID completion:(ClarifaiModelVersionCompletion)completion;
		[Export ("getVersion:completion:")]
		void GetVersion (string versionID, ClarifaiModelVersionCompletion completion);

		// -(void)deleteVersion:(NSString *)versionID completion:(ClarifaiRequestCompletion)completion;
		[Export ("deleteVersion:completion:")]
		void DeleteVersion (string versionID, ClarifaiRequestCompletion completion);

		// -(void)listTrainingInputs:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiInputsCompletion)completion;
		[Export ("listTrainingInputs:resultsPerPage:completion:")]
		void ListTrainingInputs (int page, int resultsPerPage, ClarifaiInputsCompletion completion);

		// -(void)listTrainingInputsForVersion:(NSString *)versionID page:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiInputsCompletion)completion;
		[Export ("listTrainingInputsForVersion:page:resultsPerPage:completion:")]
		void ListTrainingInputsForVersion (string versionID, int page, int resultsPerPage, ClarifaiInputsCompletion completion);
	}

	// @interface ClarifaiGeoBox : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiGeoBox
	{
		// @property (nonatomic, strong) ClarifaiLocation * startLoc;
		[Export ("startLoc", ArgumentSemantic.Strong)]
		ClarifaiLocation StartLoc { get; set; }

		// @property (nonatomic, strong) ClarifaiLocation * endLoc;
		[Export ("endLoc", ArgumentSemantic.Strong)]
		ClarifaiLocation EndLoc { get; set; }
	}

	// @interface ClarifaiGeo : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiGeo
	{
		// @property (nonatomic, strong) ClarifaiGeoBox * geoBox;
		[Export ("geoBox", ArgumentSemantic.Strong)]
		ClarifaiGeoBox GeoBox { get; set; }

		// @property (nonatomic, strong) ClarifaiLocation * geoPoint;
		[Export ("geoPoint", ArgumentSemantic.Strong)]
		ClarifaiLocation GeoPoint { get; set; }

		// @property (nonatomic, strong) NSNumber * radius;
		[Export ("radius", ArgumentSemantic.Strong)]
		NSNumber Radius { get; set; }

		// @property (nonatomic, strong) NSString * unitType;
		[Export ("unitType", ArgumentSemantic.Strong)]
		string UnitType { get; set; }

		// -(instancetype)initWithLocation:(ClarifaiLocation *)location andRadius:(double)radius;
		[Export ("initWithLocation:andRadius:")]
		IntPtr Constructor (ClarifaiLocation location, double radius);

		// -(instancetype)initWithLocation:(ClarifaiLocation *)location radius:(double)radius andRadiusUnit:(ClarifaiRadiusUnit)unit;
		[Export ("initWithLocation:radius:andRadiusUnit:")]
		IntPtr Constructor (ClarifaiLocation location, double radius, ClarifaiRadiusUnit unit);

		// -(instancetype)initWithGeoBoxFromStartLocation:(ClarifaiLocation *)startLocation toEndLocation:(ClarifaiLocation *)endLocation;
		[Export ("initWithGeoBoxFromStartLocation:toEndLocation:")]
		IntPtr Constructor (ClarifaiLocation startLocation, ClarifaiLocation endLocation);

		// -(void)setRadiusUnit:(ClarifaiRadiusUnit)unit;
		[Export ("setRadiusUnit:")]
		void SetRadiusUnit (ClarifaiRadiusUnit unit);

		// -(NSDictionary *)geoFilterAsDictionary;
		[Export ("geoFilterAsDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary GeoFilterAsDictionary { get; }
	}

	// @interface ClarifaiSearchTerm : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiSearchTerm
	{
		// +(ClarifaiSearchTerm *)searchVisuallyWithImageURL:(NSString *)imageURL;
		[Static]
		[Export ("searchVisuallyWithImageURL:")]
		ClarifaiSearchTerm SearchVisuallyWithImageURL (string imageURL);

		// +(ClarifaiSearchTerm *)searchVisuallyWithImageURL:(NSString *)imageURL andCrop:(ClarifaiCrop *)imageCrop;
		[Static]
		[Export ("searchVisuallyWithImageURL:andCrop:")]
		ClarifaiSearchTerm SearchVisuallyWithImageURL (string imageURL, ClarifaiCrop imageCrop);

		// +(ClarifaiSearchTerm *)searchVisuallyWithInputID:(NSString *)inputID;
		[Static]
		[Export ("searchVisuallyWithInputID:")]
		ClarifaiSearchTerm SearchVisuallyWithInputID (string inputID);

		// +(ClarifaiSearchTerm *)searchVisuallyWithImageData:(NSData *)imageData;
		[Static]
		[Export ("searchVisuallyWithImageData:")]
		ClarifaiSearchTerm SearchVisuallyWithImageData (NSData imageData);

		// +(ClarifaiSearchTerm *)searchVisuallyWithUIImage:(UIImage *)image;
		[Static]
		[Export ("searchVisuallyWithUIImage:")]
		ClarifaiSearchTerm SearchVisuallyWithUIImage (UIImage image);

		// +(ClarifaiSearchTerm *)searchByPredictedConcept:(ClarifaiConcept *)concept;
		[Static]
		[Export ("searchByPredictedConcept:")]
		ClarifaiSearchTerm SearchByPredictedConcept (ClarifaiConcept concept);

		// -(ClarifaiSearchTerm *)addImageCrop:(ClarifaiCrop *)imageCrop;
		[Export ("addImageCrop:")]
		ClarifaiSearchTerm AddImageCrop (ClarifaiCrop imageCrop);

		// +(ClarifaiSearchTerm *)searchInputsWithImageURL:(NSString *)imageURL;
		[Static]
		[Export ("searchInputsWithImageURL:")]
		ClarifaiSearchTerm SearchInputsWithImageURL (string imageURL);

		// +(ClarifaiSearchTerm *)searchInputsWithInputID:(NSString *)inputID;
		[Static]
		[Export ("searchInputsWithInputID:")]
		ClarifaiSearchTerm SearchInputsWithInputID (string inputID);

		// +(ClarifaiSearchTerm *)searchInputsWithGeoFilter:(ClarifaiGeo *)geo;
		[Static]
		[Export ("searchInputsWithGeoFilter:")]
		ClarifaiSearchTerm SearchInputsWithGeoFilter (ClarifaiGeo geo);

		// +(ClarifaiSearchTerm *)searchInputsWithMetadata:(NSDictionary *)metadata;
		[Static]
		[Export ("searchInputsWithMetadata:")]
		ClarifaiSearchTerm SearchInputsWithMetadata (NSDictionary metadata);

		// +(ClarifaiSearchTerm *)searchInputsByConcept:(ClarifaiConcept *)concept;
		[Static]
		[Export ("searchInputsByConcept:")]
		ClarifaiSearchTerm SearchInputsByConcept (ClarifaiConcept concept);

		// -(instancetype)initWithSearchItem:(id)searchItem isInput:(BOOL)isInput __attribute__((deprecated("")));
		[Export ("initWithSearchItem:isInput:")]
		IntPtr Constructor (NSObject searchItem, bool isInput);

		// -(NSDictionary *)searchTermAsDictionary;
		[Export ("searchTermAsDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary SearchTermAsDictionary { get; }
	}

	// @interface ClarifaiOutputRegion : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiOutputRegion
	{
		// @property double top;
		[Export ("top")]
		double Top { get; set; }

		// @property double left;
		[Export ("left")]
		double Left { get; set; }

		// @property double bottom;
		[Export ("bottom")]
		double Bottom { get; set; }

		// @property double right;
		[Export ("right")]
		double Right { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * concepts;
		[Export ("concepts", ArgumentSemantic.Strong)]
		ClarifaiConcept[] Concepts { get; set; }

		// @property (nonatomic) double focusDensity;
		[Export ("focusDensity")]
		double FocusDensity { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * ageAppearance;
		[Export ("ageAppearance", ArgumentSemantic.Strong)]
		ClarifaiConcept[] AgeAppearance { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * genderAppearance;
		[Export ("genderAppearance", ArgumentSemantic.Strong)]
		ClarifaiConcept[] GenderAppearance { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * multiculturalAppearance;
		[Export ("multiculturalAppearance", ArgumentSemantic.Strong)]
		ClarifaiConcept[] MulticulturalAppearance { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * identity;
		[Export ("identity", ArgumentSemantic.Strong)]
		ClarifaiConcept[] Identity { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface Clarifai (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_Clarifai
	{
		// -(id)findObjectForKey:(NSString *)key;
		[Export ("findObjectForKey:")]
		NSObject FindObjectForKey (string key);
	}

	// @interface Clarifai (NSMutableDictionary)
	[Category]
	[BaseType (typeof(NSMutableDictionary))]
	interface NSMutableDictionary_Clarifai
	{
		// -(id)findObjectForKey:(NSString *)key;
		[Export ("findObjectForKey:")]
		NSObject FindObjectForKey (string key);
	}

	// @interface ClarifaiOutput : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiOutput
	{
		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * concepts;
		[Export ("concepts", ArgumentSemantic.Strong)]
		ClarifaiConcept[] Concepts { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiConcept *> * colors;
		[Export ("colors", ArgumentSemantic.Strong)]
		ClarifaiConcept[] Colors { get; set; }

		// @property (nonatomic, strong) NSArray * embedding;
		[Export ("embedding", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Embedding { get; set; }

		// @property (nonatomic, strong) NSString * clusterID;
		[Export ("clusterID", ArgumentSemantic.Strong)]
		string ClusterID { get; set; }

		// @property (nonatomic, strong) ClarifaiInput * input;
		[Export ("input", ArgumentSemantic.Strong)]
		ClarifaiInput Input { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiOutputRegion *> * regions;
		[Export ("regions", ArgumentSemantic.Strong)]
		ClarifaiOutputRegion[] Regions { get; set; }

		// @property (nonatomic, strong) NSDictionary * responseDict;
		[Export ("responseDict", ArgumentSemantic.Strong)]
		NSDictionary ResponseDict { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface ClarifaiOutputFace : ClarifaiOutput
	[BaseType (typeof(ClarifaiOutput))]
	interface ClarifaiOutputFace
	{
		// @property (nonatomic, strong) NSArray<ClarifaiOutputRegion *> * faces;
		[Export ("faces", ArgumentSemantic.Strong)]
		ClarifaiOutputRegion[] Faces { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface ClarifaiOutputFocus : ClarifaiOutput
	[BaseType (typeof(ClarifaiOutput))]
	interface ClarifaiOutputFocus
	{
		// @property (nonatomic) double focusDensity;
		[Export ("focusDensity")]
		double FocusDensity { get; set; }

		// @property (nonatomic, strong) NSArray<ClarifaiOutputRegion *> * focusRegions;
		[Export ("focusRegions", ArgumentSemantic.Strong)]
		ClarifaiOutputRegion[] FocusRegions { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface ClarifaiApp : NSObject
	[BaseType (typeof(NSObject))]
	interface ClarifaiApp
	{
		// @property (nonatomic, strong) int * sessionManager;
		[Export ("sessionManager", ArgumentSemantic.Strong)]
		unsafe int* SessionManager { get; set; }

		// @property (nonatomic, strong) NSString * accessToken;
		[Export ("accessToken", ArgumentSemantic.Strong)]
		string AccessToken { get; set; }

		// -(instancetype)initWithAppID:(NSString *)appID appSecret:(NSString *)appSecret __attribute__((deprecated("")));
		[Export ("initWithAppID:appSecret:")]
		IntPtr Constructor (string appID, string appSecret);

		// -(instancetype)initWithApiKey:(NSString *)apiKey;
		[Export ("initWithApiKey:")]
		IntPtr Constructor (string apiKey);

		// -(void)addInputs:(NSArray<ClarifaiInput *> *)inputs completion:(ClarifaiInputsCompletion)completion;
		[Export ("addInputs:completion:")]
		void AddInputs (ClarifaiInput[] inputs, ClarifaiInputsCompletion completion);

		// -(void)getInputsOnPage:(int)page pageSize:(int)pageSize completion:(ClarifaiInputsCompletion)completion;
		[Export ("getInputsOnPage:pageSize:completion:")]
		void GetInputsOnPage (int page, int pageSize, ClarifaiInputsCompletion completion);

		// -(void)getInput:(NSString *)inputID completion:(ClarifaiStoreInputCompletion)completion;
		[Export ("getInput:completion:")]
		void GetInput (string inputID, ClarifaiStoreInputCompletion completion);

		// -(void)getInputsStatus:(ClarifaiInputsStatusCompletion)completion;
		[Export ("getInputsStatus:")]
		void GetInputsStatus (ClarifaiInputsStatusCompletion completion);

		// -(void)deleteInput:(NSString *)inputID completion:(ClarifaiRequestCompletion)completion;
		[Export ("deleteInput:completion:")]
		void DeleteInput (string inputID, ClarifaiRequestCompletion completion);

		// -(void)deleteInputsByIDList:(NSArray *)inputs completion:(ClarifaiRequestCompletion)completion;
		[Export ("deleteInputsByIDList:completion:")]
		[Verify (StronglyTypedNSArray)]
		void DeleteInputsByIDList (NSObject[] inputs, ClarifaiRequestCompletion completion);

		// -(void)deleteAllInputs:(ClarifaiRequestCompletion)completion;
		[Export ("deleteAllInputs:")]
		void DeleteAllInputs (ClarifaiRequestCompletion completion);

		// -(void)updateGeoPoint:(ClarifaiLocation *)location forInputWithID:(NSString *)inputID completion:(ClarifaiStoreInputCompletion)completion;
		[Export ("updateGeoPoint:forInputWithID:completion:")]
		void UpdateGeoPoint (ClarifaiLocation location, string inputID, ClarifaiStoreInputCompletion completion);

		// -(void)mergeConcepts:(NSArray<ClarifaiConcept *> *)concepts forInputWithID:(NSString *)inputID completion:(ClarifaiStoreInputCompletion)completion;
		[Export ("mergeConcepts:forInputWithID:completion:")]
		void MergeConcepts (ClarifaiConcept[] concepts, string inputID, ClarifaiStoreInputCompletion completion);

		// -(void)mergeConceptsForInputs:(NSArray<ClarifaiInput *> *)inputs completion:(ClarifaiInputsCompletion)completion;
		[Export ("mergeConceptsForInputs:completion:")]
		void MergeConceptsForInputs (ClarifaiInput[] inputs, ClarifaiInputsCompletion completion);

		// -(void)setConcepts:(NSArray<ClarifaiConcept *> *)concepts forInputWithID:(NSString *)inputID completion:(ClarifaiStoreInputCompletion)completion;
		[Export ("setConcepts:forInputWithID:completion:")]
		void SetConcepts (ClarifaiConcept[] concepts, string inputID, ClarifaiStoreInputCompletion completion);

		// -(void)setConceptsForInputs:(NSArray<ClarifaiInput *> *)inputs completion:(ClarifaiInputsCompletion)completion;
		[Export ("setConceptsForInputs:completion:")]
		void SetConceptsForInputs (ClarifaiInput[] inputs, ClarifaiInputsCompletion completion);

		// -(void)deleteConcepts:(NSArray<ClarifaiConcept *> *)concepts forInputWithID:(NSString *)inputID completion:(ClarifaiStoreInputCompletion)completion;
		[Export ("deleteConcepts:forInputWithID:completion:")]
		void DeleteConcepts (ClarifaiConcept[] concepts, string inputID, ClarifaiStoreInputCompletion completion);

		// -(void)deleteConceptsForInputs:(NSArray<ClarifaiInput *> *)inputs completion:(ClarifaiInputsCompletion)completion;
		[Export ("deleteConceptsForInputs:completion:")]
		void DeleteConceptsForInputs (ClarifaiInput[] inputs, ClarifaiInputsCompletion completion);

		// -(void)getConceptsOnPage:(int)page pageSize:(int)pageSize completion:(ClarifaiSearchConceptCompletion)completion;
		[Export ("getConceptsOnPage:pageSize:completion:")]
		void GetConceptsOnPage (int page, int pageSize, ClarifaiSearchConceptCompletion completion);

		// -(void)getConcept:(NSString *)conceptID completion:(ClarifaiStoreConceptCompletion)completion;
		[Export ("getConcept:completion:")]
		void GetConcept (string conceptID, ClarifaiStoreConceptCompletion completion);

		// -(void)addConcepts:(NSArray<ClarifaiConcept *> *)concepts completion:(ClarifaiSearchConceptCompletion)completion;
		[Export ("addConcepts:completion:")]
		void AddConcepts (ClarifaiConcept[] concepts, ClarifaiSearchConceptCompletion completion);

		// -(void)mergeConcepts:(NSArray<ClarifaiConcept *> *)concepts forModelWithID:(NSString *)modelID completion:(ClarifaiModelCompletion)completion;
		[Export ("mergeConcepts:forModelWithID:completion:")]
		void MergeConcepts (ClarifaiConcept[] concepts, string modelID, ClarifaiModelCompletion completion);

		// -(void)setConcepts:(NSArray<ClarifaiConcept *> *)concepts forModelWithID:(NSString *)modelID completion:(ClarifaiModelCompletion)completion;
		[Export ("setConcepts:forModelWithID:completion:")]
		void SetConcepts (ClarifaiConcept[] concepts, string modelID, ClarifaiModelCompletion completion);

		// -(void)deleteConcepts:(NSArray<ClarifaiConcept *> *)concepts fromModelWithID:(NSString *)modelID completion:(ClarifaiModelCompletion)completion;
		[Export ("deleteConcepts:fromModelWithID:completion:")]
		void DeleteConcepts (ClarifaiConcept[] concepts, string modelID, ClarifaiModelCompletion completion);

		// -(void)createModel:(NSArray *)concepts name:(NSString *)modelName conceptsMutuallyExclusive:(BOOL)conceptsMutuallyExclusive closedEnvironment:(BOOL)closedEnvironment completion:(ClarifaiModelCompletion)completion;
		[Export ("createModel:name:conceptsMutuallyExclusive:closedEnvironment:completion:")]
		[Verify (StronglyTypedNSArray)]
		void CreateModel (NSObject[] concepts, string modelName, bool conceptsMutuallyExclusive, bool closedEnvironment, ClarifaiModelCompletion completion);

		// -(void)createModel:(NSArray *)concepts name:(NSString *)modelName modelID:(NSString *)modelID conceptsMutuallyExclusive:(BOOL)conceptsMutuallyExclusive closedEnvironment:(BOOL)closedEnvironment completion:(ClarifaiModelCompletion)completion;
		[Export ("createModel:name:modelID:conceptsMutuallyExclusive:closedEnvironment:completion:")]
		[Verify (StronglyTypedNSArray)]
		void CreateModel (NSObject[] concepts, string modelName, string modelID, bool conceptsMutuallyExclusive, bool closedEnvironment, ClarifaiModelCompletion completion);

		// -(void)getModels:(ClarifaiModelsCompletion)completion;
		[Export ("getModels:")]
		void GetModels (ClarifaiModelsCompletion completion);

		// -(void)getModels:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiModelsCompletion)completion;
		[Export ("getModels:resultsPerPage:completion:")]
		void GetModels (int page, int resultsPerPage, ClarifaiModelsCompletion completion);

		// -(void)getModelByID:(NSString *)modelID completion:(ClarifaiModelCompletion)completion;
		[Export ("getModelByID:completion:")]
		void GetModelByID (string modelID, ClarifaiModelCompletion completion);

		// -(void)getModelByName:(NSString *)modelName completion:(ClarifaiModelCompletion)completion;
		[Export ("getModelByName:completion:")]
		void GetModelByName (string modelName, ClarifaiModelCompletion completion);

		// -(void)getOutputInfoForModel:(NSString *)modelID completion:(ClarifaiModelCompletion)completion;
		[Export ("getOutputInfoForModel:completion:")]
		void GetOutputInfoForModel (string modelID, ClarifaiModelCompletion completion);

		// -(void)updateModel:(NSString *)modelID name:(NSString *)modelName conceptsMutuallyExclusive:(BOOL)conceptsMutuallyExclusive closedEnvironment:(BOOL)closedEnvironment completion:(ClarifaiModelCompletion)completion;
		[Export ("updateModel:name:conceptsMutuallyExclusive:closedEnvironment:completion:")]
		void UpdateModel (string modelID, string modelName, bool conceptsMutuallyExclusive, bool closedEnvironment, ClarifaiModelCompletion completion);

		// -(void)deleteModel:(NSString *)modelID completion:(ClarifaiRequestCompletion)completion;
		[Export ("deleteModel:completion:")]
		void DeleteModel (string modelID, ClarifaiRequestCompletion completion);

		// -(void)deleteAllModels:(ClarifaiRequestCompletion)completion;
		[Export ("deleteAllModels:")]
		void DeleteAllModels (ClarifaiRequestCompletion completion);

		// -(void)deleteModelsByIDList:(NSArray *)models completion:(ClarifaiRequestCompletion)completion;
		[Export ("deleteModelsByIDList:completion:")]
		[Verify (StronglyTypedNSArray)]
		void DeleteModelsByIDList (NSObject[] models, ClarifaiRequestCompletion completion);

		// -(void)listTrainingInputsForModel:(NSString *)modelID page:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiInputsCompletion)completion;
		[Export ("listTrainingInputsForModel:page:resultsPerPage:completion:")]
		void ListTrainingInputsForModel (string modelID, int page, int resultsPerPage, ClarifaiInputsCompletion completion);

		// -(void)listTrainingInputsForModel:(NSString *)modelID version:(NSString *)versionID page:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiInputsCompletion)completion;
		[Export ("listTrainingInputsForModel:version:page:resultsPerPage:completion:")]
		void ListTrainingInputsForModel (string modelID, string versionID, int page, int resultsPerPage, ClarifaiInputsCompletion completion);

		// -(void)listVersionsForModel:(NSString *)modelID page:(int)page resultsPerPage:(int)resultsPerPage completion:(ClarifaiModelVersionsCompletion)completion;
		[Export ("listVersionsForModel:page:resultsPerPage:completion:")]
		void ListVersionsForModel (string modelID, int page, int resultsPerPage, ClarifaiModelVersionsCompletion completion);

		// -(void)getVersionForModel:(NSString *)modelID versionID:(NSString *)versionID completion:(ClarifaiModelVersionCompletion)completion;
		[Export ("getVersionForModel:versionID:completion:")]
		void GetVersionForModel (string modelID, string versionID, ClarifaiModelVersionCompletion completion);

		// -(void)deleteVersionForModel:(NSString *)modelID versionID:(NSString *)versionID completion:(ClarifaiRequestCompletion)completion;
		[Export ("deleteVersionForModel:versionID:completion:")]
		void DeleteVersionForModel (string modelID, string versionID, ClarifaiRequestCompletion completion);

		// -(void)search:(NSArray<ClarifaiSearchTerm *> *)searchTerms completion:(ClarifaiSearchCompletion)completion;
		[Export ("search:completion:")]
		void Search (ClarifaiSearchTerm[] searchTerms, ClarifaiSearchCompletion completion);

		// -(void)search:(NSArray<ClarifaiSearchTerm *> *)searchTerms page:(NSNumber *)page perPage:(NSNumber *)perPage completion:(ClarifaiSearchCompletion)completion;
		[Export ("search:page:perPage:completion:")]
		void Search (ClarifaiSearchTerm[] searchTerms, NSNumber page, NSNumber perPage, ClarifaiSearchCompletion completion);

		// -(void)search:(NSArray<ClarifaiSearchTerm *> *)searchTerms page:(NSNumber *)page perPage:(NSNumber *)perPage language:(NSString *)language completion:(ClarifaiSearchCompletion)completion;
		[Export ("search:page:perPage:language:completion:")]
		void Search (ClarifaiSearchTerm[] searchTerms, NSNumber page, NSNumber perPage, string language, ClarifaiSearchCompletion completion);

		// -(void)searchByMetadata:(NSDictionary *)metadata page:(NSNumber *)page perPage:(NSNumber *)perPage completion:(ClarifaiSearchCompletion)completion;
		[Export ("searchByMetadata:page:perPage:completion:")]
		void SearchByMetadata (NSDictionary metadata, NSNumber page, NSNumber perPage, ClarifaiSearchCompletion completion);

		// -(void)searchForConceptsByName:(NSString *)name andLanguage:(NSString *)language completion:(ClarifaiSearchConceptCompletion)completion;
		[Export ("searchForConceptsByName:andLanguage:completion:")]
		void SearchForConceptsByName (string name, string language, ClarifaiSearchConceptCompletion completion);

		// -(void)searchForModelByName:(NSString *)modelName modelType:(ClarifaiModelType)modelType completion:(ClarifaiModelsCompletion)completion;
		[Export ("searchForModelByName:modelType:completion:")]
		void SearchForModelByName (string modelName, ClarifaiModelType modelType, ClarifaiModelsCompletion completion);

		// -(void)ensureValidAccessToken:(void (^)(NSError *))handler;
		[Export ("ensureValidAccessToken:")]
		void EnsureValidAccessToken (Action<NSError> handler);
	}

	// typedef id (^CAIMapFunction)(id);
	delegate NSObject CAIMapFunction (NSObject arg0);

	// typedef BOOL (^CAIFilterFunction)(id);
	delegate bool CAIFilterFunction (NSObject arg0);

	// typedef NSComparisonResult (^CAICompareFunction)(id, id);
	delegate NSComparisonResult CAICompareFunction (NSObject arg0, NSObject arg1);

	// @interface Clarifai (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_Clarifai
	{
		// -(NSArray *)map:(CAIMapFunction)mapFn;
		[Export ("map:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Map (CAIMapFunction mapFn);

		// -(NSArray *)filter:(CAIFilterFunction)filterFn;
		[Export ("filter:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Filter (CAIFilterFunction filterFn);

		// -(NSArray *)filter:(CAIFilterFunction)filterFn map:(CAIMapFunction)mapFn;
		[Export ("filter:map:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Filter (CAIFilterFunction filterFn, CAIMapFunction mapFn);

		// -(NSDictionary *)asDictionaryUsingKey:(CAIMapFunction)keyFn;
		[Export ("asDictionaryUsingKey:")]
		NSDictionary AsDictionaryUsingKey (CAIMapFunction keyFn);

		// -(NSArray *)sortedByKey:(NSString *)key ascending:(BOOL)ascending;
		[Export ("sortedByKey:ascending:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SortedByKey (string key, bool ascending);

		// -(NSArray *)asBatchesOfSize:(NSInteger)batchSize;
		[Export ("asBatchesOfSize:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AsBatchesOfSize (nint batchSize);

		// -(NSArray *)slicedFrom:(NSInteger)from to:(NSInteger)to;
		[Export ("slicedFrom:to:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SlicedFrom (nint from, nint to);

		// -(NSArray *)duplicatesRemoved;
		[Export ("duplicatesRemoved")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] DuplicatesRemoved { get; }

		// -(NSArray *)shuffled;
		[Export ("shuffled")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Shuffled { get; }

		// -(id)randomElement;
		[Export ("randomElement")]
		[Verify (MethodToProperty)]
		NSObject RandomElement { get; }

		// -(NSInteger)binarySearch:(id)searchItem compareFN:(CAICompareFunction)compareFN;
		[Export ("binarySearch:compareFN:")]
		nint BinarySearch (NSObject searchItem, CAICompareFunction compareFN);
	}

	// @interface Clarifai (NSMutableArray)
	[Category]
	[BaseType (typeof(NSMutableArray))]
	interface NSMutableArray_Clarifai
	{
		// -(void)sortByKey:(NSString *)key ascending:(BOOL)ascending;
		[Export ("sortByKey:ascending:")]
		void SortByKey (string key, bool ascending);
	}

	// @interface ResponseSerializer
	interface ResponseSerializer
	{
	}
}
