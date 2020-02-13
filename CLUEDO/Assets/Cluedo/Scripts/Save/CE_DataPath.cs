using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class CE_DataPath
{

    public static string DataPath => Path.Combine(Application.persistentDataPath, DataPathExtension);
    static string DataPathExtension => "SaveCluedo.fdp";

    public static string DataPathSecure => Path.Combine(Application.persistentDataPath,  DataPathSecureExtension);
    static string DataPathSecureExtension => "Porn/ghnhuz.TOTORO";
    
    static bool InitFolder()
    {
        if (!Directory.Exists(DataPathSecure.Replace("/ghnhuz.TOTORO", "")))
            Directory.CreateDirectory(DataPathSecure.Replace("/ghnhuz.TOTORO", ""));

        return Directory.Exists(DataPathSecure.Replace("/ghnhuz.TOTORO", ""));
    }
    public static bool FileExist()
    {
        if (!File.Exists(DataPath))
            File.WriteAllText(DataPath,"");
        if (InitFolder())
            File.WriteAllText(DataPathSecure,"");

        return File.Exists(DataPath) && File.Exists(DataPathSecure);
    }
    public static bool SaveCorrupted()
    {
        if (!FileExist()) return false;
        return File.ReadAllText(DataPath) == File.ReadAllText(DataPathSecure);
    }
    public static bool IsSave()
    {
        return File.ReadAllText(DataPath) == string.Empty;
    }
}
