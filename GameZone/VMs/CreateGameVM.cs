using GameZone.Attributes;
using GameZone.Settings;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace GameZone.VMS
{
    public class CreateGameVM
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Display(Name="Category")]
        public int CategoryId { get; set; }
		[Display(Name = "Device")]
		public List<int> SelectedDevices { get; set; } = default;
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();

        [AllowedExtentionAttributes(FileSettings.AllowedExtension)]
        [AllowedImageSize(FileSettings.MaxFileSizeInByets)]
        public IFormFile Cover { get; set; } = default;
        public string Description { get; set; } = string.Empty;
    }
}
