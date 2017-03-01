using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Tz.Utility
{
	public class ValidationResultCollection : IEnumerable<ValidationResult>
	{
		public ValidationResultCollection()
		{
		}
		/// <summary>
		/// 验证结果
		/// </summary>
		private readonly List<ValidationResult> _results;

		/// <summary>
		/// 是否有效
		/// </summary>
		/// <value><c>true</c> if is valid; otherwise, <c>false</c>.</value>
		public bool IsValid
		{
			get
			{
				return _results.Count == 0;
			}
		}
		/// <summary>
		/// 验证结果个数
		/// </summary>
		/// <value>The count.</value>
		public int Count
		{
			get
			{
				return _results.Count;
			}
		}
		/// <summary>
		/// 添加验证结果
		/// </summary>
		/// <returns>The add.</returns>
		/// <param name="result">Result.</param>
		public void Add(ValidationResult result)
		{
			if (result == null)
			{
				return;
			}
			_results.Add(result);
		}
		/// <summary>
		/// 添加验证结果集合
		/// </summary>
		/// <param name="results">Results.</param>
		public void AddRange(IEnumerable<ValidationResult> results)
		{
			if (results == null)
			{
				return;
			}
			foreach (var result in results)
			{
				Add(result);
			}
		}

		/// <summary>
		/// 获取迭代器
		/// </summary>
		IEnumerator<ValidationResult> IEnumerable<ValidationResult>.GetEnumerator()
		{
			return _results.GetEnumerator();
		}

		/// <summary>
		/// 获取迭代器
		/// </summary>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return _results.GetEnumerator();
		}
	}
}
