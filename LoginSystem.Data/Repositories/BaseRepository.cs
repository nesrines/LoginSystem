using LoginSystem.Core.Models;

namespace LoginSystem.Data.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        private static readonly List<T> Items = new List<T>();
        public static async Task CreateAsync(T item)
        {
            Items.Add(item);
        }

        public static  async Task DeleteAsync(T item)
        {
            Items.Remove(item);
        }

        public static async Task<T> GetAsync(Predicate<T> func)
        {
            return Items.Find(func);
        }

        public static List<T> GetAllAsync()
        { return Items; }
    }
}
