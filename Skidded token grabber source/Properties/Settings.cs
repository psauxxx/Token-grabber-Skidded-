// Decompiled with JetBrains decompiler
// Type: idk.Properties.Settings
// Assembly: Obfuscated Name, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F586F40D-E7E7-42DC-83B9-A3609E437F40
// Assembly location: C:\Users\User0\OneDrive\Skrivebord\Spoofer.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace idk.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
