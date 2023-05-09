using UnityEngine;

public class ObjectMirror : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRendererFrom;
    private SpriteRenderer _spriteRendererFor;

    [SerializeField]
    private Transform _transformFrom;
    private Transform _transformFor;


    private void Awake()
    {
        _spriteRendererFor = GetComponent<SpriteRenderer>();
        _transformFor = GetComponent<Transform>();
    }

    private void Update()
    {
        MirrorObject(); 
    }

    public void MirrorObject()
    {
        _spriteRendererFor.sprite = _spriteRendererFrom.sprite;
        _spriteRendererFor.color = _spriteRendererFrom.color;

        _transformFor.localPosition = new Vector3(-_transformFrom.localPosition.x, _transformFrom.localPosition.y, _transformFor.localPosition.z);
        _transformFor.localScale = new Vector3(-_transformFrom.localScale.x, _transformFrom.localScale.y, _transformFor.localScale.z);
        _transformFor.eulerAngles = new Vector3(_transformFrom.eulerAngles.x, _transformFrom.eulerAngles.y, -_transformFrom.eulerAngles.z);
    }
}
