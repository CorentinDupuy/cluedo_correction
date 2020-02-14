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
    [SerializeField] public  float positionX;
    [SerializeField] public float positionY;
    [SerializeField] public float positionZ;
    [SerializeField] public Vector3 pos => new Vector3(positionX,positionY,positionZ);
    [SerializeField] public  bool IsInRoom;
    [SerializeField] public CE_NoteSystem NoteSystem;
    [SerializeField] public CE_HandCards HandCards;
    #endregion
    #endregion

    #region Getters/Setters
    #endregion

    #region Methods
    #region Private
    #endregion
    #region Public
    public CE_PlayerDB(Vector3 _position, bool _isInRoom, CE_NoteSystem _noteSystem, CE_HandCards _handCards)
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