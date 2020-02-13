using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class CE_LoadSave
{
   
    public static void ReadSave()
    {
        // connard proof
        //if (!CE_DataPath.IsSave()) return;
        db _db = JsonUtility.FromJson<db>(File.ReadAllText(CE_DataPath.DataPath));
        Debug.Log(_db.numeros);
    }
}
[Serializable]
public struct db
{
    [SerializeField]
    public int numeros;
}
