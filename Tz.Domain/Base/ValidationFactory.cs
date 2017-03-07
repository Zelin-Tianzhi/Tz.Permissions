using Tz.Utility.Validations;

namespace Tz.Domain
{
	public class ValidationFactory
	{
		public static IValidation Create()
		{
			return new Validation();
		}
	}
}
