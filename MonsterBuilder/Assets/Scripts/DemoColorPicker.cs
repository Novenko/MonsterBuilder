using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoColorPicker : MonoBehaviour
{
    [SerializeField] private GameObject _activePart;

    public void SetActive(GameObject activePart) 
    {
        _activePart = activePart;
    }

    public void SetColor(Color newColor)
    {
        SpriteRenderer renderer = _activePart.GetComponent<SpriteRenderer>();
        if (renderer == null) 
        {
            renderer = _activePart.GetComponent<Transform>().GetChild(0).GetComponent<SpriteRenderer>();
        }
        renderer.color = newColor;
        Debug.Log(newColor);
    }
}