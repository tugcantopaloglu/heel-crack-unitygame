using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] public GameObject Menu;
    private static bool gameisStart = false;

    private void Awake()
    {
       
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetMouseButtonDown(0)) // Sol fare düğmesine tıklandığında
        {
            StartGame();
        }
    }
    public void StartGame()
    {
        gameisStart = true;
        if (gameisStart)
        {
            Menu.SetActive(false);
        }
        else
        {
            Debug.Log("Oyun Durduruldu.");
        }
        
    }
}
