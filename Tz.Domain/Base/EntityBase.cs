using System;
using System.ComponentModel.DataAnnotations;

namespace Tz.Domain
{
	public class EntityBase : IEntity
	{
		public EntityBase()
		{
		}
		#region 字段
		/// <summary>
		/// 创建时间
		/// </summary>
		public virtual DateTime? CreateTime { get; set; }
		#endregion
		#region 标识
		/// <summary>
		/// 标识
		/// </summary>
		[Required]
		public Guid Id { get; set; }
		#endregion
		#region 重写

		public static bool operator ==(EntityBase entity1, EntityBase entity2)
		{
			return false;
		}

		public static bool operator !=(EntityBase entity1, EntityBase entity2)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (!(obj is EntityBase))
				return false;
			return this == (EntityBase)obj;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
		#endregion
	}
}
