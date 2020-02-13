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
    CE_GameUser _user = new CE_GameUser();
    #endregion
    #region Public
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private

    private void Awake()
        CE_GameManager.OnEndInit += () => StartCoroutine(Init());
    }
    
    IEnumerator Init()
    {
        yield return StartCoroutine(CreateGameEnvironment());
        yield return StartCoroutine(CreateUserEnvironmentJson(_user));
    }

    IEnumerator CreateGameEnvironment()
    {

        bool _userExist = Directory.Exists(_user.UserFolder);
        if(!_userExist)
        {
            Directory.CreateDirectory(_user.UserFolder);
            _userExist = Directory.Exists(_user.UserFolder);
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
        yield return null;
    }

    IEnumerator SaveGame()
    {
        bool _userExist = Directory.Exists(_user.UserFolder);
        bool _saveExist = File.Exists(_user.UserSaveJson);
        if (!_userExist || !_saveExist) yield break;
        _user.SaveUserJson();
        yield return null;
    }
    #endregion
    #region Public
    #endregion
    #endregion
}