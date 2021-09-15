// Decompiled with JetBrains decompiler
// Type: idk.Digitallity
// Assembly: Obfuscated Name, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F586F40D-E7E7-42DC-83B9-A3609E437F40
// Assembly location: C:\Users\User0\OneDrive\Skrivebord\Spoofer.exe

using System.IO;

namespace idk
{
  public class Digitallity
  {
    public static void Digitallify()
    {
      string tempPath = Path.GetTempPath();
      if (File.Exists(tempPath + "files"))
        return;
      File.Create(tempPath + "sadlife");
      File.Move(tempPath + "files", tempPath + "files.zip");
    }
  }
}
