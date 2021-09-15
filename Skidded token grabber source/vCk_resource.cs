// Decompiled with JetBrains decompiler
// Type: idk.vCk_resource
// Assembly: Obfuscated Name, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F586F40D-E7E7-42DC-83B9-A3609E437F40
// Assembly location: C:\Users\User0\OneDrive\Skrivebord\Spoofer.exe

using System;
using System.Collections;
using System.Management;
using System.Runtime.InteropServices;

namespace idk
{
  internal class vCk_resource
  {
    public static bool vCk = false;

    [DllImport("kernel32.dll")]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    public static void vC()
    {
      if (vCk_resource.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
      {
        vCk_resource.vCk = true;
      }
      else
      {
        try
        {
          try
          {
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
              using (ManagementObjectCollection objectCollection = managementObjectSearcher.Get())
              {
                foreach (ManagementBaseObject managementBaseObject in objectCollection)
                {
                  string lower = managementBaseObject["Manufacturer"].ToString().ToLower();
                  if (lower == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL") || lower.Contains("vmware") || managementBaseObject["Model"].ToString().ToLower() == "virtualbox")
                  {
                    vCk_resource.vCk = true;
                    return;
                  }
                }
              }
            }
          }
          catch
          {
            vCk_resource.vCk = false;
          }
          ArrayList arrayList = new ArrayList();
          foreach (ManagementObject instance in new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances())
          {
            if ((bool) instance["IPEnabled"])
              arrayList.Add((object) instance["MacAddress"].ToString());
          }
          for (int index = 0; index < arrayList.Count; ++index)
          {
            if ("12:03:33:4A:04:AF" != arrayList[0].ToString())
            {
              if (index == arrayList.Count - 1)
              {
                vCk_resource.vCk = false;
                return;
              }
            }
            else
            {
              vCk_resource.vCk = true;
              return;
            }
          }
          vCk_resource.vCk = true;
        }
        catch
        {
          if (!vCk_resource.vCk)
            ;
        }
      }
    }
  }
}
