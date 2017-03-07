using System;
namespace Tz.Utility.Validations
{
	public interface IValidation
	{
		ValidationResultCollection Validate(object target);
	}
}
