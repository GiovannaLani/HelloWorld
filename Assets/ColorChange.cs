using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        objetos = GameObject.FindGameObjectsWithTag("Rojo");

        foreach (GameObject objeto in objetos)
        {
            objeto.GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
