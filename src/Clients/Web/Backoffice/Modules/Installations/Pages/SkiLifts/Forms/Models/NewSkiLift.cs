using SkiResortManager.Shared.Enums.Enums.Installations.SkiLifts;
using SkiResortManager.Shared.Utils.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace SkiResortManager.Backoffice.Modules.Installations.Pages.SkiLifts.Forms.Models
{
    public class NewSkiLift
    {
        [RequiredEnum(ErrorMessage = "Ski lift type is required")]
        public SkiLiftType SkiLiftType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Code is required")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Code { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Length must be greater than {1}")]
        public int? Length { get; set; }

        [Range(0d, double.MaxValue, ErrorMessage = "Speed must be greater than {1}")]
        public decimal? Speed { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Start altitude must be greater than {1}")]
        public int? StartAltitude { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "End altitude must be greater than {1}")]
        public int? EndAltitude { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Capacity per hour must be greater than {1}")]
        public int? CapacityPerHour { get; set; }
    }
}
