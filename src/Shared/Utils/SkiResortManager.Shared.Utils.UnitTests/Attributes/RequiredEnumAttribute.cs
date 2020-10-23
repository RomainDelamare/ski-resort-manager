using SkiResortManager.Shared.Utils.UnitTests.Enums.ExampleEnums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace SkiResortManager.Shared.Utils.UnitTests.Attributes
{
    public class RequiredEnumAttribute
    {
        [Fact]
        public void RequiredEnumAttribute_Validate_Valid()
        {
            var objectWithEnum = new ObjectWithEnum()
            {
                Enum = FilledEnum.Item1
            };

            Assert.Empty(ValidateModel(objectWithEnum));
        }

        [Fact]
        public void RequiredEnumAttribute_Validate_Invalid()
        {
            int invalidEnumIndex = -1;
            var enumValue = (FilledEnum)invalidEnumIndex;

            var objectWithEnum = new ObjectWithEnum()
            {
                Enum = enumValue
            };

            Assert.Single(ValidateModel(objectWithEnum));
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            return validationResults;
        }
    }

    public class ObjectWithEnum
    {
        [Utils.Attributes.RequiredEnum]
        public FilledEnum Enum { get; set; }
    }
}
