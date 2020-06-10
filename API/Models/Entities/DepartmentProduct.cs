using System;

namespace Model.Entities
{
	public class DepartmentProduct
	{
		public Guid Id { get; set; }
		public Guid DepartmentId { get; set; }
		public Guid ProductId { get; set; }
		public int Quantity { get; set; }

		public Department Department { get; set; }
		public Product Product { get; set; }
	}
}
