using System;

namespace Model.DTOs
{
	public class NewDepartmentProduct
	{
		public Guid DepartmentId { get; set; }
		public Guid ProductId { get; set; }
		public int Quantity { get; set; }
	}
}
