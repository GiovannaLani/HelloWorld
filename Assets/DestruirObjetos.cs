using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjetos : MonoBehaviour
{
    private Object[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
        }
    }
}
