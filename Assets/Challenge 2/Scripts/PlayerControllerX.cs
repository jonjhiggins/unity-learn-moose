using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float allowRespawnDelay = 1;
    private float allowRespawnTimer = 0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(allowRespawnTimer);
        if (allowRespawnTimer > 0)
        {
            allowRespawnTimer -= Time.deltaTime;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && allowRespawnTimer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            allowRespawnTimer = allowRespawnDelay;
        }
    }

}
