using UnityEngine;

public class ObjectSpriteCopier : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRendererFrom;
    private SpriteRenderer _SpriteRendererFor;


    private void Awake()
    {
        _SpriteRendererFor = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        CopySprite();
    }

    private void CopySprite() 
    {
        _SpriteRendererFor.sprite = _spriteRendererFrom.sprite;
        _SpriteRendererFor.color = _spriteRendererFrom.color;
    }
}
