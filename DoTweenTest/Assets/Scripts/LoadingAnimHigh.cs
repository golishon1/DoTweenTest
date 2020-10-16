using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LoadingAnimHigh : MonoBehaviour,ILoadingAnim
{
    [SerializeField] private Transform[] _parts;
    [SerializeField] private Vector3 _scaleY;


    public void Loading()
    {
        var duration = 1f;
        var sequense = DOTween.Sequence();

        for (int i = 0; i < _parts.Length; i++)
        {
            sequense.Append(_parts[i].DOScale(_scaleY, 0.2f)).AppendInterval(0.2f)
                .Join(_parts[i].DOScale(Vector3.one, 0.2f)).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        }

    }
}
