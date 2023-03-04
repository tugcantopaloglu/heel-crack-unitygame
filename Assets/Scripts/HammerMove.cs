using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HammerMove : MonoBehaviour
{
    [SerializeField] private GameObject Hammer;
    private void Start()
    {
        MoveObject();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RotateObject();
        }

    }

    void RotateObject()
    {
        Sequence hitSequence = DOTween.Sequence();
        hitSequence.Append(transform.DORotate(new Vector3(9.537f, -235.971f, -14.177f), 0.2f).SetEase(Ease.Linear));
        hitSequence.Append(transform.DORotate(new Vector3(0, -224.801f, 90), 0.2f).SetEase(Ease.Linear));
    }

    void MoveObject()
    {
        //Sequence moveSequence = DOTween.Sequence();
        transform.DOMove(new Vector3(-1, -1, 0), 1f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        //moveSequence.Append(transform.DOMove(new Vector3(-1, -1f, 0), 0.2f).SetEase(Ease.Linear));
    }
}
