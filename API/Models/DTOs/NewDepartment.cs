using Model.Enums;

namespace Model.DTOs
{
	public class NewDepartment
	{
		public string Name { get; set; }
		public ProductType[] ProductTypes { get; set; }
	}
}
