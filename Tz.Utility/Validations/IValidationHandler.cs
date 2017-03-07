using System;
namespace Tz.Utility.Validations
{
	/// <summary>
	/// 验证处理器
	/// </summary>
	public interface IValidationHandler
	{
		/// <summary>
		/// 处理验证错误
		/// </summary>
		/// <returns>The handle.</returns>
		/// <param name="results">Results.</param>
		void Handle(ValidationResultCollection results);
	}
}
