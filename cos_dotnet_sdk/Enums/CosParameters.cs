/*
 * Created by SharpDevelop.
 * User: jonnxu
 * Date: 2016/5/24
 * Time: 15:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace QCloud.CosApi.Enums
{
	static class CosParameters
	{
		public const string Authorization = "Authorization";
		
		public const string PARA_OP = "op";
		
		public const string PARA_BIZ_ATTR = "biz_attr";

		public const string PARA_INSERT_ONLY = "insertOnly";
		
		public const string PARA_AUTHORITY = "authority";
		
		public const string PARA_CUSTOM_HEADERS = "custom_headers";
		
		public const string PARA_CACHE_CONTROL = "Cache-Control";
		
		public const string PARA_CONTENT_TYPE = "Content-Type";
		
		public const string PARA_CONTENT_DISPOSITION = "Content-Disposition";

		public const string PARA_CONTENT_LANGUAGE = "Content-Language";

		public const string PARA_X_COS_META_PREFIX = "x-cos-meta-";
		
		public const string PARA_FLAG = "flag";
	}
	
	internal enum FolderPattern
	{
		File = 0,
		Folder,
		Both
	}
	
	internal static class InsertOnly
	{
		public const string INSERTONLY_0 = "0";
		public const string INSERTONLY_1 = "1";
	}

	internal static class Flag
	{
		public const int FLAG_BIZ_ATTR = 0x01;
		public const int FLAG_CUSTOMER_HEADER = 0x40;
		public const int FLAG_AUTHORITY = 0x80;
	}
	
	internal static class Authority
	{
		public const string AUTHORITY_INVALID = "eInvalid";
		public const string AUTHORITY_PRIVATE = "eWRPrivate";
		public const string AUTHORITY_PRIVATEPUBLIC = "eWPrivateRPublic";
	}
}
