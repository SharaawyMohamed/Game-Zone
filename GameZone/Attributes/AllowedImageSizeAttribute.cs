using System.ComponentModel.DataAnnotations;

namespace GameZone.Attributes
{
	public class AllowedImageSizeAttribute: ValidationAttribute
	{
		private readonly int ImageSize;

		public AllowedImageSizeAttribute(int _ImageSize)
		{
			ImageSize = _ImageSize;
		}
		protected override ValidationResult? IsValid(object? value, ValidationContext validationcontext)
		{
			var file = value as IFormFile;
			if (file != null)
			{
				if (file.Length > ImageSize)
				{
					return new ValidationResult($"Image Size = {file.Length} is over, Image size shouldn't be more than 1M");
				}
			}
			return ValidationResult.Success;
		}
	}
}
