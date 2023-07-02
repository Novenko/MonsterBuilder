using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeAllButtons : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clipToShot;

    private void Start()
    {
        for (int i = 0; i < _buttons.Length; i++) 
        {
            _buttons[i].onClick.AddListener(PlayClip);
        }
    }

    private void PlayClip()
    {
        _audioSource.PlayOneShot(_clipToShot);
    }

}
