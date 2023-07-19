namespace Bethany_sPieShop.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
