using System;
using Tz.Utility.Validations;
using System.ComponentModel.DataAnnotations;

namespace Tz.Domain
{
	public abstract class AggregateRoot : EntityBase, IAggregateRoot
	{
		public AggregateRoot()
		{
		}

		public byte[] Version
		{
			get;
			set;
		}

		protected override void Validate(ValidationResultCollection results)
		{
			if (Id == Guid.Empty)
				results.Add(new ValidationResult("Id不能为空。"));
		}
	}
}
