using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DemoColorPicker : MonoBehaviour
    {
        public void SetColor(Color newColor)
        {
            GetComponent<SpriteRenderer>().color = newColor;
            Debug.Log(newColor);
        }
    }