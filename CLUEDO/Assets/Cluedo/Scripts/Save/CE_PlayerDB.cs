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
    [SerializeField] float positionX;
    [SerializeField] float positionY;
    [SerializeField] float positionZ;
    [SerializeField] bool IsInRoom;
    [SerializeField] CE_NoteSystem NoteSystem;
    [SerializeField] CE_HandCards HandCards;
    [SerializeField] int idNextRoom;
    [SerializeField] int idLastRoom;
    [SerializeField] AIPhase aiPhase;
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private
    #endregion
    #region Public
    public CE_PlayerDB(Vector3 _position, bool _isInRoom, CE_NoteSystem _noteSystem, CE_HandCards _handCards, int _idNextRoom, int _idLastRoom, AIPhase _aiPhase)
    {
        positionX = _position.x;
        positionY = _position.y;
        positionZ = _position.z;

        IsInRoom = _isInRoom;

        NoteSystem = _noteSystem;

        HandCards = _handCards;

        idLastRoom = _idLastRoom;
        idNextRoom = _idNextRoom;

        aiPhase = _aiPhase;
    }
    #endregion
    #endregion
}