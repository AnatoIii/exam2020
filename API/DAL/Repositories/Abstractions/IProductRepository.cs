using Model.Entities;

namespace DAL.Repositories.Abstractions
{
	public interface IProductRepository
	{
		void AddNewProduct(Product product);
	}
}
