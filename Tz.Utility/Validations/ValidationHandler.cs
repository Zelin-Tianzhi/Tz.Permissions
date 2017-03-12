using System;
using System.Linq;
using Tz.Utility.Exceptions;
namespace Tz.Utility.Validations
{
	public class ValidationHandler : IValidationHandler
	{
		public ValidationHandler()
		{
		}

		public void Handle(ValidationResultCollection results)
		{
			if (results.IsValid)
				return;
			throw new CustomException(results.First().ErrorMessage);
		}
	}
}
