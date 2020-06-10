using Model.Enums;
using System;

namespace Model.Entities
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public ProductType ProductType { get; set; }
		public double BoughtPrice { get; set; }
		public double SellPrice { get; set; }
		public DateTime? ManufactureDate { get; set; }
		public DateTime? ExpirationDate { get; set; }
	}
}
