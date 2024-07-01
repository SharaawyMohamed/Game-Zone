using System.ComponentModel.DataAnnotations;

namespace GameZone.Attributes
{
	public class AllowedExtentionAttributes : ValidationAttribute
	{
		private readonly string allowedExtensions;

		public AllowedExtentionAttributes(string _allowedExtensisons)
		{
			allowedExtensions = _allowedExtensisons;
		}
		protected override ValidationResult? IsValid(object? value, ValidationContext validationcontext)
		{
			var file = value as IFormFile;
			if (file != null)
			{
				var extnetion = Path.GetExtension(file.FileName);
				var IsAllowed = allowedExtensions.Split(',').Contains(extnetion, StringComparer.OrdinalIgnoreCase);

				if (!IsAllowed)
				{
					return new ValidationResult("Your File Extension is not allowed");
				}
			}
			return ValidationResult.Success;
		}
	}
}
