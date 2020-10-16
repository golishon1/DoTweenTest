using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LoadingAnimHigh : MonoBehaviour,ILoadingAnim
{
    [SerializeField] private Transform[] _parts;
    [SerializeField] private Vector3 _scaleY;
    void Start()
    {
        
    }


    public void Loading()
    {
        var duration = 1f;
        var sequense = DOTween.Sequence();

         
        sequense.Append(_parts[0].DOScale(_scaleY, duration));
        sequense.Append(_parts[1].DOScale(_scaleY, duration));
        sequense.Append(_parts[2].DOScale(_scaleY, duration));
        sequense.Append(_parts[3].DOScale(_scaleY, duration));
        sequense.Append(_parts[4].DOScale(_scaleY, duration));
        // _startPos = _dot.transform.position;
        // sequense.Append(_dot.DOMove(_startPos, duration));
        // sequense.Append(_dot.DOMove(_startPos + _pos + _pos + _pos, duration));
    }
}
