using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class CE_DataPath
{

    
    public static string DataPath => Path.Combine(FolderDataPath, DataPathExtension);
    public static string FolderDataPath => Path.Combine(Application.persistentDataPath, currentUser);
    static string DataPathExtension => "/SaveCluedo.fdp";
    static string currentUser = "";
    public static string DataPathSecure => Path.Combine(FolderDataPathSecure,  DataPathSecureExtension);
    public static string FolderDataPathSecure => Path.Combine(Application.persistentDataPath,  currentUser);
    static string DataPathSecureExtension => "/Porn/ghnhuz.TOTORO";
    
    static bool InitFolder()
    {
        Debug.Log(currentUser);
        if (!Directory.Exists(FolderDataPath))
            Directory.CreateDirectory(FolderDataPath);

        if (!Directory.Exists(FolderDataPathSecure))
            Directory.CreateDirectory(FolderDataPathSecure);

        return Directory.Exists(FolderDataPathSecure);
    }
    public static bool FileExist()
    {
        if (InitFolder() && !File.Exists(DataPathSecure))
        {
            File.WriteAllText(DataPathSecure, "");
        }
        if (!File.Exists(DataPath))
            File.WriteAllText(DataPath,"");

        return File.Exists(DataPath) && File.Exists(DataPathSecure);
    }
    static bool SaveCorrupted()
    {
        if (!FileExist()) return false;
        Debug.Log(File.ReadAllText(DataPath));
        Debug.Log(File.ReadAllText(DataPathSecure));
        return File.ReadAllText(DataPath) != File.ReadAllText(DataPathSecure);
    }
    static void VerifSave()
    {
        if(SaveCorrupted())
        {
            File.WriteAllText(DataPath, "");
            File.WriteAllText(DataPathSecure, "");
        }
    }
    public static bool IsSave(string _user)
    {
        Debug.Log(_user);
        currentUser = _user;
        Debug.Log(currentUser);
        VerifSave();
        return File.ReadAllText(DataPath) != string.Empty;
    }
}
