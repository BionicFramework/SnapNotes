using System.Threading.Tasks;

public interface IStorage {
  Task<T> Get<T>(string key);
  Task Set<T>(string key, T value);
}