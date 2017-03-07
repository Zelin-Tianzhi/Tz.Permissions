using System.ComponentModel.DataAnnotations;

namespace Tz.Utility.Validations
{
	public interface IValidationRule
	{
		ValidationResult Validate();
	}
}
