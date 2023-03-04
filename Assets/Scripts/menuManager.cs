using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    [SerializeField] private Text TapToPlay;
    [SerializeField] private GameObject Hand_Icon;

    // Start is called before the first frame update
    void Start()
    {
        TapToPlay.transform.DOScale(1.1f,0.6f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InOutFlash);
        Hand_Icon.transform.DOScale(1.1f, 0.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutFlash);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
