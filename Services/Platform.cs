using System;
using System.Threading.Tasks;
using Bionic.Bridge.Capacitor;
using BionicExtensions.Attributes;

[Injectable(typeof(IPlatform))]
public class Platform : IPlatform {
  private DeviceInfo _info;

  public async Task<DeviceInfo> Info() => _info ?? (_info = await DeviceBridge.GetInfo());

  public async Task<bool> IsWeb() {
    try {
      var info = await Info();
      return await Task.FromResult(info.platform == "web");
    }
    catch (Exception e) {
      Console.WriteLine(e.Message);
    }

    return await Task.FromResult(false);
  }

  public async Task<bool> IsAndroid() {
    try {
      var info = await Info();
      return await Task.FromResult(info.platform == "android");
    }
    catch (Exception e) {
      Console.WriteLine(e.Message);
    }

    return await Task.FromResult(false);
  }

  public async Task<bool> IsiOS() {
    try {
      var info = await Info();
      return await Task.FromResult(info.platform == "ios");
    }
    catch (Exception e) {
      Console.WriteLine(e.Message);
    }

    return await Task.FromResult(false);
  }

  public async Task<bool> IsAndroidPWA() {
    try {
      var info = await Info();
      return await Task.FromResult(info.platform == "web" && info.osVersion.Contains("Android"));
    }
    catch (Exception e) {
      Console.WriteLine(e.Message);
    }

    return await Task.FromResult(false);
  }
}