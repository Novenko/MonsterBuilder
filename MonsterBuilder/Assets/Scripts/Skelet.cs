using UnityEngine;

public class Skelet : MonoBehaviour
{
    private Vector2 _armsPos;
    private Vector2 _legsPos;

    private float _armsRotation;

    public Vector2 armsPos
    {
        get { return _armsPos; }
        set { _armsPos = value; }
    }
    public Vector2 legsPos
    {
        get { return _legsPos; }
        set { _legsPos = value; }
    }
    public float armsRotation 
    {
        get { return _armsRotation; }
        set { _armsRotation = value; }
    }
}
