using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PintarTren : MonoBehaviour
{
    private GameObject[] wheels, bases, body, chimenea;

    
    // Start is called before the first frame update
    void Start()
    {
        wheels = GameObject.FindGameObjectsWithTag("Rueda");
        ChangeColor(wheels, Color.black);
        bases = GameObject.FindGameObjectsWithTag("Base");
        ChangeColor(bases, Color.gray);
        body = GameObject.FindGameObjectsWithTag("Cuerpo");
        ChangeColor(body, Color.cyan);
        chimenea = GameObject.FindGameObjectsWithTag("chimenea");
        ChangeColor(chimenea, Color.blue);

    }

    private static void ChangeColor(GameObject[] objects, Color color)
    {
        foreach (GameObject obj in objects)
        {
            obj.GetComponent<MeshRenderer>().material.color = color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
