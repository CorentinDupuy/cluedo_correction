using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
public class CE_GameUser
{
    #region Events
    #endregion

    #region Members
    #region Private
    [SerializeField] string userPseudo = "Jean-Marmoud";
    #endregion
    #region Public
    public string UserFolder => Path.Combine(CE_BaseURL.FolderPath, userPseudo);
    public string UserSaveJson => Path.Combine(CE_BaseURL.FolderPath, userPseudo, $"cluedo_save_{userPseudo}.json");
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private
    #endregion
    #region Public
    public void SaveUserJson()
    {
        if (!Directory.Exists(UserFolder)) return;
        CE_GameManager instance = CE_GameManager.Instance;
        CE_GlobalSaveData saveData = new CE_GlobalSaveData(instance.CurrentCharacterTurnIndex,
            instance.CurrentTurn,
            instance.MysteryCards,
            instance.PlayerCharacterIndex,
            instance.AllCharacterInGame);

        string _data = JsonUtility.ToJson(saveData);
        File.WriteAllText(UserSaveJson, _data);
        Debug.Log(_data);
    }

    public void SaveUserBinary()
    {
        if (!Directory.Exists(UserFolder)) return;
        CE_GameManager instance = CE_GameManager.Instance;
        CE_GlobalSaveData saveData = new CE_GlobalSaveData(instance.CurrentCharacterTurnIndex,
            instance.CurrentTurn,
            instance.MysteryCards,
            instance.PlayerCharacterIndex,
            instance.AllCharacterInGame);

      //  string _data = BinaryWriter.(saveData);
       // File.WriteAllText(UserSaveJson, _data);
      //  Debug.Log(_data);
    }
    #endregion
    #endregion
}