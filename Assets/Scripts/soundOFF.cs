using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOFF : MonoBehaviour
{
    [SerializeField] public GameObject offButton;

    public void offSound()

    {
        if (offButton.activeSelf)
        {
            offButton.SetActive(false);
        }
        else
        {
            offButton.SetActive(true);
        }
    }
}
