using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);

        if (collider.tag == "Player")
        {
            scoreManager.DecreaseLives();
        }

        if (collider.tag == "Pizza")
        {
            scoreManager.IncreaseScore();
        }
    }
}
