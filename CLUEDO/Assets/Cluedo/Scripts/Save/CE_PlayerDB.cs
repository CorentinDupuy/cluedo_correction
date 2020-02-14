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
    [SerializeField] public float positionX;
    [SerializeField] public float positionY;
    [SerializeField] public float positionZ;
    [SerializeField] public bool IsInRoom;
    [SerializeField] public CE_NoteSystem NoteSystem;
    [SerializeField] public CE_HandCards HandCards;
    [SerializeField] public int idNextRoom;
    [SerializeField] public int idLastRoom;
    [SerializeField] public AIPhase aiPhase;
    [SerializeField] public CE_Door NextDoor;
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private
    #endregion
    #region Public
    public CE_PlayerDB(Vector3 _position, bool _isInRoom, CE_NoteSystem _noteSystem, CE_HandCards _handCards, int _idNextRoom, int _idLastRoom, AIPhase _aiPhase, CE_Door _nextDoor)
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
        NextDoor = _nextDoor;
    }
    #endregion
    #endregion
}