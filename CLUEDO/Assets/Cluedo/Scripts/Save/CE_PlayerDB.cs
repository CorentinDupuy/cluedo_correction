using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public struct CE_PlayerDB
{
    #region Events
    #endregion

    #region Members
    #region Private
    #endregion
    #region Public
    float positionX;
    float positionY;
    float positionZ;
    bool IsInRoom;
    List<int> NoteSystem;
    List<int> HandCards;
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private
    #endregion
    #region Public
    public CE_PlayerDB(Vector3 _position, bool _isInRoom, List<int> _noteSystem, List<int> _handCards)
    {
        positionX = _position.x;
        positionY = _position.y;
        positionZ = _position.z;

        IsInRoom = _isInRoom;

        NoteSystem = _noteSystem;

        HandCards = _handCards;
    }
    #endregion
    #endregion
}