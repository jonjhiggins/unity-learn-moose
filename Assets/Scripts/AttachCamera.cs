using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Canvas>().worldCamera = Camera.main;
    }

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.position);
    }

}
