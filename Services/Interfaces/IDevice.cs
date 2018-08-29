using System.Threading.Tasks;
using Bionic.Bridge.Capacitor;

public interface IDevice {
  Task<CameraPhoto> TakePicture(CameraOptions options);

  Task<GeolocationPosition> CurrentLocation();

  Task ToastShort(string message);

  Task ToastLong(string message);

  void OpenInBrowser(string url, string windowName = null, string toolbarColor = null, bool fullscreen = true);

  Task<bool> OpenConfirmModal(string message, string title = "Please confirm", string okLabel = "OK",
    string cancelLabel = "Cancel");
}