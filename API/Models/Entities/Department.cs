using Model.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Model.Entities
{
	public class Department
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		[NotMapped]
		public ProductType[] ProductTypes
		{
			get {
				return Array.ConvertAll(ProductTypes_do_not_use.Split(';'), ToProductType);
			}
			set {
				ProductTypes_do_not_use = string.Join(";", value.Select(p => p.ToString()));
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ProductTypes_do_not_use { get; set; }

		private ProductType ToProductType(string input)
		{
			if (Enum.TryParse(input, out ProductType productType))
				return productType;
			throw new ArgumentException($"Input '{input}' can't be parsed to ProductType", nameof(input));
		}
	}
}
