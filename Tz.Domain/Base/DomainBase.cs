using System;
using System.Text;
using System.Collections.Generic;
using Tz.Utility.Validations;

namespace Tz.Domain.Base
{
	public class DomainBase
	{
		#region 构造方法

		public DomainBase()
		{
			_rules = new List<IValidationRule>();

		}
		#endregion
		#region 字段

		/// <summary>
		/// 描述
		/// </summary>
		private StringBuilder _description;
		/// <summary>
		/// 验证规则集合
		/// </summary>
		private readonly List<IValidationRule> _rules;
		/// <summary>
		/// 验证处理器
		/// </summary>
		private IValidationHandler _handler;

		#endregion
	}
}
