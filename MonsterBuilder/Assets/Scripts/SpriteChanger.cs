using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSprite(int index)
    {
        _spriteRenderer.sprite = _sprites[index];
    }
}