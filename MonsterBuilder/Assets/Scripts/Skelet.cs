using UnityEngine;

public class Skelet : MonoBehaviour
{

    /*_skelet1Eyes;
      _skelet1Brow;
      _skelet1Ears;
      _skelet1Mouth;
      _skelet1Nose;*/

    private Vector2 _armsPos;
    private Vector2 _legsPos;
    private Vector2 _eyesPos;
    private Vector2 _browPos;
    private Vector2 _earsPos;
    private Vector2 _mouthPos;
    private Vector2 _nosePos;

    private Quaternion _armsRotation;

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
    public Quaternion armsRotation 
    {
        get { return _armsRotation; }
        set { _armsRotation = value; }
    }
    public Vector2 eyesPos 
    {
        get { return _eyesPos; }
        set { _eyesPos = value; }
    }
    public Vector2 browPos
    {
        get { return _browPos; }
        set { _browPos = value; }
    }
    public Vector2 earsPos
    {
        get { return _earsPos; }
        set { _earsPos = value; }
    }
    public Vector2 mouthPos
    {
        get { return _mouthPos; }
        set { _mouthPos = value; }
    }
    public Vector2 nosePos
    {
        get { return _nosePos; }
        set { _nosePos = value; }
    }
}
