using UnityEngine;

public class SkeletManager : MonoBehaviour
{
    private Skelet[] _skelets = new Skelet[6];

    [SerializeField] private float _globalXposition;

    [SerializeField] private GameObject _rightArm;
    [SerializeField] private GameObject _rightLeg;
    
    [Header("Skelet1")] 
    /////////////////////////////////////////////////
    [SerializeField] private Vector2 _skelet1Arms;
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
        _skelets[0].armsRotation = 17.9f;

        _skelets[0].legsPos = new Vector2(_skelet1Legs.x + _globalXposition, _skelet1Legs.y);
        /////////////////////////////////////////////////
        _skelets[1].armsPos = new Vector2(_skelet2Arms.x + _globalXposition, _skelet2Arms.y);
        _skelets[1].armsRotation = 17.9f;

        _skelets[1].legsPos = new Vector2(_skelet2Legs.x + _globalXposition, _skelet2Legs.y);
        /////////////////////////////////////////////////
        _skelets[2].armsPos = new Vector2(_skelet3Arms.x + _globalXposition, _skelet3Arms.y);
        _skelets[2].armsRotation = 17.9f;

        _skelets[2].legsPos = new Vector2(_skelet3Legs.x + _globalXposition, _skelet3Legs.y);
        /////////////////////////////////////////////////
        _skelets[3].armsPos = new Vector2(_skelet4Arms.x + _globalXposition, _skelet4Arms.y);
        _skelets[3].armsRotation = 17.9f;

        _skelets[3].legsPos = new Vector2(_skelet4Legs.x + _globalXposition, _skelet4Legs.y);
        /////////////////////////////////////////////////
        _skelets[4].armsPos = new Vector2(_skelet5Arms.x + _globalXposition, _skelet5Arms.y);
        _skelets[4].armsRotation = 17.9f;

        _skelets[4].legsPos = new Vector2(_skelet5Legs.x + _globalXposition, _skelet5Legs.y);
        /////////////////////////////////////////////////
        _skelets[5].armsPos = new Vector2(_skelet6Arms.x + _globalXposition, _skelet6Arms.y);
        _skelets[5].armsRotation = 17.9f;

        _skelets[5].legsPos = new Vector2(_skelet6Legs.x + _globalXposition, _skelet6Legs.y);
        /////////////////////////////////////////////////
    }

    private void Update()
    {
        InitSkelets();
        ChangeSkelet(0);
    }

    public void ChangeSkelet(int skeletIndex) 
    {
        _rightArm.transform.position = _skelets[skeletIndex].armsPos;
        _rightLeg.transform.position = _skelets[skeletIndex].legsPos;
    }
}
