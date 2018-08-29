using System.Threading.Tasks;
using Bionic.Bridge.Capacitor;
using BionicExtensions.Attributes;

[Injectable(typeof(IStorage))]
public class Storage : IStorage {
  public Task<T> Get<T>(string key) {
    return StorageBridge.Get<T>(key);
  }

  public Task Set<T>(string key, T value) {
    return StorageBridge.Set(key, value);
  }
}