using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CE_SaveManager : MonoBehaviour
{
    #region Events
    #endregion

    #region Members
    #region Private
    static CE_SaveManager instance = null;
    public static CE_SaveManager Instance => instance;

    [SerializeField] CE_GameUser user = new CE_GameUser();
    #endregion
    #region Public
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private
    private void Awake()
    { 
        CE_GameManager.OnEndInit += () => StartCoroutine(Init());
        InitSingleton();
    }

    void InitSingleton()
    {
        if (instance == null)
            instance = this;
    }

    IEnumerator Init()
    {
        yield return StartCoroutine(CreateGameEnvironment());
        yield return StartCoroutine(CreateUserEnvironmentJson(user));
        yield return new WaitForSeconds(20);
        yield return StartCoroutine(SaveGame());
    }

    IEnumerator CreateGameEnvironment()
    {
        bool _userExist = Directory.Exists(user.UserFolder);
        if(!_userExist)
        {
            Directory.CreateDirectory(user.UserFolder);
            _userExist = Directory.Exists(user.UserFolder);
            if (!_userExist) yield break ;
        }
        yield return null;
    }

    IEnumerator CreateUserEnvironmentJson(CE_GameUser _user)
    {
        bool _saveExist = File.Exists(_user.UserSaveJson);
        if (!_saveExist)
        {
            _user.SaveUserJson();
            _saveExist = File.Exists(_user.UserSaveJson);
            if (!_saveExist) yield break;
        }

        _saveExist = File.Exists(_user.UserSaveBin);
        if(!_saveExist)
        {
            _user.SaveUserBinary();
            _saveExist = File.Exists(_user.UserSaveBin);
            if (!_saveExist) yield break;
        }
        yield return null;
    }

    IEnumerator SaveGame()
    {
        bool _userExist = Directory.Exists(user.UserFolder);
        bool _saveExist = File.Exists(user.UserSaveJson);
        if (!_userExist || !_saveExist) yield break;
        user.SaveUserJson();
        user.SaveUserBinary();
        yield return null;
    }



    // bin
    public bool BinFileExist()
    {
        bool _exist = File.Exists(user.UserSaveBin);
        if (!_exist)
        {
            File.WriteAllText(user.UserSaveBin, "");
        }
        return _exist;
    }

    public bool JsonFileExist()
    {
        bool _exist = File.Exists(user.UserSaveJson);
        if (!_exist)
        {
            File.WriteAllText(user.UserSaveJson, "");
        }
        return _exist;
    }

    #endregion
    #region Public
    public bool IsSave(string _user)
    {
        if (!JsonFileExist() || !BinFileExist()) return false;
        
        return File.ReadAllText(user.UserSaveJson) != string.Empty; // todo test bin
    }
    #endregion
    #endregion
}