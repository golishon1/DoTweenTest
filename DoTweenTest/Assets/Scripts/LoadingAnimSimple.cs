using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LoadingAnimSimple : MonoBehaviour,ILoadingAnim
{
    [SerializeField] private Transform _dot;
    [SerializeField] private Vector3 _rot;

    public void Loading()
    {
        _dot.transform.DORotate(_rot,1f,RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
