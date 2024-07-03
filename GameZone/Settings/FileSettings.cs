namespace GameZone.Settings
{
	public static class FileSettings
	{
		public const string ImagePath = "/Files/Images";
		public const string AllowedExtension = ".jpg,.png,.jpeg";
		public const int MaxFileSizeInMB = 1;
		public const int MaxFileSizeInByets = MaxFileSizeInMB * (1024 * 10242);
	}
}
