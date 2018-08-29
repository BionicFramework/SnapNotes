using System;
using System.Threading.Tasks;
using Bionic.Bridge.Capacitor;
using BionicExtensions.Attributes;

[Injectable(typeof(IDevice))]
public class Device : IDevice {
  private IPlatform _platform;

  public Device(IPlatform platform) {
    _platform = platform;
  }

  public async Task<CameraPhoto> TakePicture(CameraOptions options) => await CameraBridge.GetPhoto(options);

  public async Task<GeolocationPosition> CurrentLocation() => await GeolocationBridge.GetCurrentPosition();

  public async Task ToastShort(string message) => await ToastBridge.ShowWithShortDuration(message);

  public async Task ToastLong(string message) => await ToastBridge.ShowWithLongDuration(message);

  public async void OpenInBrowser(string url, string windowName = null, string toolbarColor = null,
    bool fullscreen = true) {
    await BrowserBridge.Open(new BrowserOpenOptions {
      url = url,
      presentationStyle = fullscreen ? PresentationStyle.Fullscreen : PresentationStyle.Popover,
      windowName = windowName,
      toolbarColor = toolbarColor
    });
  }

  public async Task<bool> OpenConfirmModal(
    string message,
    string title = "Please confirm",
    string okLabel = "OK",
    string cancelLabel = "Cancel"
  ) {
    try {
      var result = await ModalsBridge.Confirm(new ConfirmOptions {
        title = title,
        message = message,
        okButtonTitle = okLabel,
        cancelButtonTitle = cancelLabel
      });
      return await Task.FromResult(result.value);
    }
    catch (Exception e) {
      Console.WriteLine(e.Message);
    }

    return await Task.FromResult(false);
  }
}