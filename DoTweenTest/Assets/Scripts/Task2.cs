using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] private GameObject[] _loadingAnim;
    private void Start()
    {
        for (int i = 0; i < _loadingAnim.Length; i++)
        {
            _loadingAnim[i].GetComponent<ILoadingAnim>().Loading();
        }
    }
}

interface ILoadingAnim
{
    void Loading();
}
