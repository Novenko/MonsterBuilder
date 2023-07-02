using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdvShower : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private int _counter = 0;

    private void Start()
    {
        ShowAdv();
    }

    public void PlayAdv() 
    {
        if (_counter / 2 == 0) 
        {
            ShowAdv();
        }
        _counter++;
    }
}
