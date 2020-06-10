using Model.Enums;
using System;

namespace Model.DTOs
{
	public class DepartmentData
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public ProductType[] ProductTypes { get; set; }

		public ProductData ProductData { get; set; }
	}
}
