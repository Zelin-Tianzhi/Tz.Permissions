using System;
namespace Tz.Utility
{
	public interface IValidation
	{
		ValidationResultCollection Validate(object target);
	}
}
