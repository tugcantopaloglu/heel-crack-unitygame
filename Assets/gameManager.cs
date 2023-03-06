using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject level;
    public GameObject settings;
    public GameObject gold;
    public GameObject GameManager;


    private void Awake()
    {
        DontDestroyOnLoad(level);
        DontDestroyOnLoad(settings);
        DontDestroyOnLoad(gold);
        DontDestroyOnLoad(GameManager);

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // Sol fare düğmesine tıklandığında
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
        
    }
}
