﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
[Serializable]
public class CE_GlobalSaveData 
{
    #region Events
    #endregion

    #region Members
    #region Private
    [SerializeField] List<CE_PlayerDB> savePlayerData = new List<CE_PlayerDB>();
    [SerializeField] CE_GameManagerDB saveGameManagerData = new CE_GameManagerDB();
	#endregion
	#region Public
	#endregion
	#endregion

	#region Getters/Setters
	#endregion

	#region Methods
	#region Private
	#endregion
	#region Public
    public CE_GlobalSaveData(int CharacterIndexTurn, int NumberOfTurns, CE_MysteryCards mysteryCards, int PlayerIndex, List<IGamePlayable> _characters)
    {
        savePlayerData.Clear();
        for (int i = 0; i < _characters.Count; i++)
        {
            savePlayerData.Add(new CE_PlayerDB(_characters[i].CharacterRef.CharacterTransform.position,
                _characters[i].IsInRoom,
                _characters[i].NoteSystem,
                _characters[i].HandCards));
        }
        saveGameManagerData = new CE_GameManagerDB(CharacterIndexTurn, NumberOfTurns, mysteryCards, PlayerIndex);
    }
	#endregion
	#endregion
}