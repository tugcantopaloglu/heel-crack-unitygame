using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public static int heelCounter;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (heelCounter == 3)
        {
            GoToNextScene();
        }
    }
    public void GoToNextScene()
    {
        // Get the index of the current scene
        /*int currentIndex = SceneManager.GetActiveScene().buildIndex;

        // Calculate the index of the next scene
        int nextIndex = currentIndex + 1;

        // Load the next scene
        SceneManager.LoadScene(nextIndex);*/
        Debug.Log("Next Scene'a gecildi.");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        heelCounter++;
        Debug.Log(heelCounter); 

    }
}
