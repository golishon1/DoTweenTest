using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Task1 : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(ButtonAnimated);
    }

    public void ButtonAnimated()
    { 
        var duration = 1f;
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOShakePosition(duration * 2, 20, 90,40,true,true));
        sequence.Join(transform.DOScale(Vector3.one * 1.5f, duration));
        sequence.Append(transform.DOShakePosition(duration  /2, 20, 90,40,true,true));
        sequence.Join(transform.DOScale(Vector3.one * 1, duration));
    }

    private void OnMouseEnter()
    {
        
    }
}
