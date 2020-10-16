using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LoadingAnimMiddle : MonoBehaviour,ILoadingAnim
{
    [SerializeField] private Transform _part1;
    [SerializeField] private Transform _part2;
    [SerializeField] private Vector3 _rot;

    private Vector3 _startPos;
    public void Loading()
    {
        _part1.transform.DORotate(_rot,1f,RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        _part2.transform.DORotate(-_rot,1f,RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);

    }
}
