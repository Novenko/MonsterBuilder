using UnityEngine;

public class SkeletManager : MonoBehaviour
{
    private Skelet[] _skelets = new Skelet[6];

    [SerializeField] private float _globalXposition;

    [SerializeField] private GameObject _rightArm;
    [SerializeField] private GameObject _rightLeg;
    [SerializeField] private GameObject _rightEye;
    [SerializeField] private GameObject _rightBrow;
    [SerializeField] private GameObject _rightEar;
    [SerializeField] private GameObject _mouth;
    [SerializeField] private GameObject _nose;


    [Header("Skelet1")] 
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet1Arms;
    [SerializeField] private Quaternion _skelet1ArmsRotation;
    [SerializeField] private Vector2 _skelet1Legs;
    [SerializeField] private Vector2 _skelet1Eyes;
    [SerializeField] private Vector2 _skelet1Brow;
    [SerializeField] private Vector2 _skelet1Ears;
    [SerializeField] private Vector2 _skelet1Mouth;
    [SerializeField] private Vector2 _skelet1Nose;
    /////////////////////////////////////////////////
    [Header("Skelet2")]
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet2Arms;
    [SerializeField] private Quaternion _skelet2ArmsRotation;
    [SerializeField] private Vector2 _skelet2Legs;
    [SerializeField] private Vector2 _skelet2Eyes;
    [SerializeField] private Vector2 _skelet2Brow;
    [SerializeField] private Vector2 _skelet2Ears;
    [SerializeField] private Vector2 _skelet2Mouth;
    [SerializeField] private Vector2 _skelet2Nose;
    /////////////////////////////////////////////////
    [Header("Skelet3")]
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet3Arms;
    [SerializeField] private Quaternion _skelet3ArmsRotation;
    [SerializeField] private Vector2 _skelet3Legs;
    [SerializeField] private Vector2 _skelet3Eyes;
    [SerializeField] private Vector2 _skelet3Brow;
    [SerializeField] private Vector2 _skelet3Ears;
    [SerializeField] private Vector2 _skelet3Mouth;
    [SerializeField] private Vector2 _skelet3Nose;
    /////////////////////////////////////////////////
    [Header("Skelet3")]
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet4Arms;
    [SerializeField] private Quaternion _skelet4ArmsRotation;
    [SerializeField] private Vector2 _skelet4Legs;
    [SerializeField] private Vector2 _skelet4Eyes;
    [SerializeField] private Vector2 _skelet4Brow;
    [SerializeField] private Vector2 _skelet4Ears;
    [SerializeField] private Vector2 _skelet4Mouth;
    [SerializeField] private Vector2 _skelet4Nose;
    /////////////////////////////////////////////////
    [Header("Skelet4")]
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet5Arms;
    [SerializeField] private Quaternion _skelet5ArmsRotation;
    [SerializeField] private Vector2 _skelet5Legs;
    [SerializeField] private Vector2 _skelet5Eyes;
    [SerializeField] private Vector2 _skelet5Brow;
    [SerializeField] private Vector2 _skelet5Ears;
    [SerializeField] private Vector2 _skelet5Mouth;
    [SerializeField] private Vector2 _skelet5Nose;
    /////////////////////////////////////////////////
    [Header("Skelet5")]
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet6Arms;
    [SerializeField] private Quaternion _skelet6ArmsRotation;
    [SerializeField] private Vector2 _skelet6Legs;
    [SerializeField] private Vector2 _skelet6Eyes;
    [SerializeField] private Vector2 _skelet6Brow;
    [SerializeField] private Vector2 _skelet6Ears;
    [SerializeField] private Vector2 _skelet6Mouth;
    [SerializeField] private Vector2 _skelet6Nose;
    /////////////////////////////////////////////////


    private void Awake()
    {
        _skelets[0] = gameObject.AddComponent<Skelet>();
        _skelets[1] = gameObject.AddComponent<Skelet>();
        _skelets[2] = gameObject.AddComponent<Skelet>();
        _skelets[3] = gameObject.AddComponent<Skelet>();
        _skelets[4] = gameObject.AddComponent<Skelet>();
        _skelets[5] = gameObject.AddComponent<Skelet>();

        InitSkelets();
    }

    private void InitSkelets() 
    {

        /////////////////////////////////////////////////
        _skelets[0].armsPos = new Vector2(_skelet1Arms.x + _globalXposition, _skelet1Arms.y);
        _skelets[0].armsRotation = _skelet1ArmsRotation;

        _skelets[0].legsPos = new Vector2(_skelet1Legs.x + _globalXposition, _skelet1Legs.y);
        _skelets[0].eyesPos = new Vector2(_skelet1Eyes.x + _globalXposition, _skelet1Eyes.y);
        _skelets[0].browPos = new Vector2(_skelet1Brow.x + _globalXposition, _skelet1Brow.y);
        _skelets[0].earsPos = new Vector2(_skelet1Ears.x + _globalXposition, _skelet1Ears.y);
        _skelets[0].mouthPos = new Vector2(_skelet1Mouth.x + _globalXposition, _skelet1Mouth.y);
        _skelets[0].nosePos = new Vector2(_skelet1Nose.x + _globalXposition, _skelet1Nose.y);
        /////////////////////////////////////////////////
        _skelets[1].armsPos = new Vector2(_skelet2Arms.x + _globalXposition, _skelet2Arms.y);
        _skelets[1].armsRotation = _skelet2ArmsRotation;

        _skelets[1].legsPos = new Vector2(_skelet2Legs.x + _globalXposition, _skelet2Legs.y);
        _skelets[1].eyesPos = new Vector2(_skelet2Eyes.x + _globalXposition, _skelet2Eyes.y);
        _skelets[1].browPos = new Vector2(_skelet2Brow.x + _globalXposition, _skelet2Brow.y);
        _skelets[1].earsPos = new Vector2(_skelet2Ears.x + _globalXposition, _skelet2Ears.y);
        _skelets[1].mouthPos = new Vector2(_skelet2Mouth.x + _globalXposition, _skelet2Mouth.y);
        _skelets[1].nosePos = new Vector2(_skelet2Nose.x + _globalXposition, _skelet2Nose.y);
        /////////////////////////////////////////////////
        _skelets[2].armsPos = new Vector2(_skelet3Arms.x + _globalXposition, _skelet3Arms.y);
        _skelets[2].armsRotation = _skelet3ArmsRotation;

        _skelets[2].legsPos = new Vector2(_skelet3Legs.x + _globalXposition, _skelet3Legs.y);
        _skelets[2].eyesPos = new Vector2(_skelet2Eyes.x + _globalXposition, _skelet3Eyes.y);
        _skelets[2].browPos = new Vector2(_skelet3Brow.x + _globalXposition, _skelet3Brow.y);
        _skelets[2].earsPos = new Vector2(_skelet3Ears.x + _globalXposition, _skelet3Ears.y);
        _skelets[2].mouthPos = new Vector2(_skelet3Mouth.x + _globalXposition, _skelet3Mouth.y);
        _skelets[2].nosePos = new Vector2(_skelet3Nose.x + _globalXposition, _skelet3Nose.y);
        /////////////////////////////////////////////////
        _skelets[3].armsPos = new Vector2(_skelet4Arms.x + _globalXposition, _skelet4Arms.y);
        _skelets[3].armsRotation = _skelet4ArmsRotation;

        _skelets[3].legsPos = new Vector2(_skelet4Legs.x + _globalXposition, _skelet4Legs.y);
        _skelets[3].eyesPos = new Vector2(_skelet4Eyes.x + _globalXposition, _skelet4Eyes.y);
        _skelets[3].browPos = new Vector2(_skelet4Brow.x + _globalXposition, _skelet4Brow.y);
        _skelets[3].earsPos = new Vector2(_skelet4Ears.x + _globalXposition, _skelet4Ears.y);
        _skelets[3].mouthPos = new Vector2(_skelet4Mouth.x + _globalXposition, _skelet4Mouth.y);
        _skelets[3].nosePos = new Vector2(_skelet4Nose.x + _globalXposition, _skelet4Nose.y);
        /////////////////////////////////////////////////
        _skelets[4].armsPos = new Vector2(_skelet5Arms.x + _globalXposition, _skelet5Arms.y);
        _skelets[4].armsRotation = _skelet5ArmsRotation;

        _skelets[4].legsPos = new Vector2(_skelet5Legs.x + _globalXposition, _skelet5Legs.y);
        _skelets[4].eyesPos = new Vector2(_skelet5Eyes.x + _globalXposition, _skelet5Eyes.y);
        _skelets[4].browPos = new Vector2(_skelet5Brow.x + _globalXposition, _skelet5Brow.y);
        _skelets[4].earsPos = new Vector2(_skelet5Ears.x + _globalXposition, _skelet5Ears.y);
        _skelets[4].mouthPos = new Vector2(_skelet5Mouth.x + _globalXposition, _skelet5Mouth.y);
        _skelets[4].nosePos = new Vector2(_skelet5Nose.x + _globalXposition, _skelet5Nose.y);
        /////////////////////////////////////////////////
        _skelets[5].armsPos = new Vector2(_skelet6Arms.x + _globalXposition, _skelet6Arms.y);
        _skelets[5].armsRotation = _skelet6ArmsRotation;

        _skelets[5].legsPos = new Vector2(_skelet6Legs.x + _globalXposition, _skelet6Legs.y);
        _skelets[5].eyesPos = new Vector2(_skelet6Eyes.x + _globalXposition, _skelet6Eyes.y);
        _skelets[5].browPos = new Vector2(_skelet6Brow.x + _globalXposition, _skelet6Brow.y);
        _skelets[5].earsPos = new Vector2(_skelet6Ears.x + _globalXposition, _skelet6Ears.y);
        _skelets[5].mouthPos = new Vector2(_skelet6Mouth.x + _globalXposition, _skelet6Mouth.y);
        _skelets[5].nosePos = new Vector2(_skelet6Nose.x + _globalXposition, _skelet6Nose.y);
        /////////////////////////////////////////////////
    }

    /*private void Update()
    {
        InitSkelets();
        ChangeSkelet(0);
    }*/

    public void ChangeSkelet(int skeletIndex) 
    {
        _rightArm.transform.position = _skelets[skeletIndex].armsPos;
        _rightArm.transform.rotation = _skelets[skeletIndex].armsRotation;
        _rightEye.transform.position = _skelets[skeletIndex].eyesPos;
        _rightBrow.transform.position = _skelets[skeletIndex].browPos;
        _rightEar.transform.position = _skelets[skeletIndex].earsPos;
        _mouth.transform.position = _skelets[skeletIndex].mouthPos;
        _nose.transform.position = _skelets[skeletIndex].nosePos;
    }
}
/*_rightEye;
_rightBrow;
_rightEar;
_mouth;
_nose;*/
