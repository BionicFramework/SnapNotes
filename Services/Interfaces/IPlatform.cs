using System.Threading.Tasks;
using Bionic.Bridge.Capacitor;

public interface IPlatform
{
  Task<DeviceInfo> Info();

  Task<bool> IsWeb();

  Task<bool> IsAndroid();

  Task<bool> IsiOS();
}