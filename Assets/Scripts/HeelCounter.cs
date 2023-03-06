using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelCounter : MonoBehaviour
{
    public static int crackedHeelCount = 0;

    private void Update()
    {
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
            crackedHeelCount += 1;
            Debug.Log("silindi"+crackedHeelCount);
        }
    }
}
