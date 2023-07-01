using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformChanger : MonoBehaviour
{
    [SerializeField] private Transform _objectToMove;
    [SerializeField] private Vector2 _moveTo;

    public void Move() 
    {
        _objectToMove.position = _moveTo;
    }
}
