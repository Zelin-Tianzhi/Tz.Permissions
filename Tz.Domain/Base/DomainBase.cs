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

        #region ToString(输出领域对象的状态)

        /// <summary>
        /// 输出领域对象的状态
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            _description = new StringBuilder();
            AddDescriptions();
            return _description.ToString().TrimEnd().TrimEnd(',');
        }
        /// <summary>
        /// 添加描述
        /// </summary>
        protected virtual void AddDescriptions()
        {
        }

        /// <summary>
        /// 添加描述
        /// </summary>
        /// <param name="description"></param>
        protected void AddDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return;
            _description.Append(description);
        }

        /// <summary>
        /// 添加描述
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        protected void AddDescription<T>(string name, T value)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return;
            _description.AppendFormat("{0}:{1}", name, value);
        }
        #endregion


    }
}
