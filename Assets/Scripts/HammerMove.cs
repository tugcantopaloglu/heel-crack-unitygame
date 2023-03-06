using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static Unity.VisualScripting.Metadata;

public class HammerMove : MonoBehaviour
{
    [SerializeField] private GameObject Hammer;
    private bool isHitDone = true;
    private void Start()
    {
        MoveObject();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isHitDone)
        {
            RotateObject();
        }

    }

    void RotateObject()
    {
        ChangeBool();
        Sequence hitSequence = DOTween.Sequence();
        hitSequence.Append(transform.DORotate(new Vector3(9.537f, -235.971f, -14.177f), 0.2f).SetEase(Ease.Linear));
        hitSequence.Append(transform.DORotate(new Vector3(0, -224.801f, 90), 0.2f).SetEase(Ease.Linear)).OnComplete(() => ChangeBool());
    }

    void MoveObject()
    {
        //Sequence moveSequence = DOTween.Sequence();
        transform.DOMove(new Vector3(-1, -1, 0), 1f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
    }

    void ChangeBool()
    {
        isHitDone = !isHitDone;
    }
}
