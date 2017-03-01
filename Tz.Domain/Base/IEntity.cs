using System;
namespace Tz.Domain
{
	/// <summary>
	/// 实体
	/// </summary>
	public interface IEntity
	{
		/// <summary>
		/// 标识
		/// </summary>
		/// <value>The identifier.</value>
		Guid Id { get; }
	}
}
