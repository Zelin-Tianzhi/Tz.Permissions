using System;
using System.Text;
using System.Collections;
namespace Tz.Utility.Exceptions
{
	public class CustomException : Exception
	{
		#region 构造方法

		public CustomException(string message)
			: this(message, "")
		{
		}

		public CustomException(string message, string code)
			: this(message, code, LogLevel.Warning)
		{
		}

		public CustomException(string message, string code, LogLevel level)
			: this(message, code, level, null)
		{ }

		public CustomException(Exception exception)
			: this("", "", LogLevel.Warning, exception)
		{ }

		public CustomException(string message, string code, Exception exception)
			: this(message, code, LogLevel.Warning, exception)
		{ }

		public CustomException(string message, string code, LogLevel level, Exception exception)
			: base(message ?? "", exception)
		{

		}

		/// <summary>
		/// 获取错误消息
		/// </summary>
		private string GetMessage()
		{
			var result = new StringBuilder();
			AppendSelfMessage(result);
			AppendInnerMessage(result, InnerException);
			return result.ToString().TrimEnd(Environment.NewLine.ToCharArray());
		}

		/// <summary>
		/// 添加本身消息
		/// </summary>
		private void AppendSelfMessage(StringBuilder result)
		{
			if (string.IsNullOrWhiteSpace(base.Message))
				return;
			result.AppendLine(base.Message);
		}

		/// <summary>
		/// 添加内部异常消息
		/// </summary>
		private void AppendInnerMessage(StringBuilder result, Exception exception)
		{
			if (exception == null)
				return;
			if (exception is CustomException)
			{
				result.AppendLine(exception.Message);
				return;
			}
			result.AppendLine(exception.Message);
			result.Append(GetData(exception));
			AppendInnerMessage(result, exception.InnerException);
		}

		/// <summary>
		/// 获取添加的额外数据
		/// </summary>
		private string GetData(Exception ex)
		{
			var result = new StringBuilder();
			foreach (DictionaryEntry data in ex.Data)
				result.AppendFormat("{0}:{1}{2}", data.Key, data.Value, Environment.NewLine);
			return result.ToString();
		}


		#endregion

		#region Message(错误消息)

		/// <summary>
		/// 错误消息
		/// </summary>
		readonly string _message;

		/// <summary>
		/// 错误消息
		/// </summary>
		/// <value>The message.</value>
		public override string Message
		{
			get
			{
				if (Data.Count == 0)
					return _message;
				return _message + Environment.NewLine + GetData(this);
			}

		}

		#endregion

		#region TraceId(跟踪号)
		/// <summary>
		/// 跟踪号
		/// </summary>
		/// <value>The trace identifier.</value>
		public string TraceId { get; set; }

		#endregion
	}
}
