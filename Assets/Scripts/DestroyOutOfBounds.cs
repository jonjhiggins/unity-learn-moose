using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30;
    private float lowerBounds = -10;
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds )
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            scoreManager.DecreaseLives();
        }
    }
}
