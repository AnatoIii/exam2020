namespace DAL.Repositories
{
	public class BaseRepository
	{
		protected ShopDBContext _dBContext { get; set; }
		public BaseRepository(ShopDBContext dBContext)
		{
			_dBContext = dBContext;
		}
	}
}
