using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorTag : MonoBehaviour
{
    public Color color;
    public bool findByTag;
    public string choosenTag;
    private GameObject[] objectList;
    // Start is called before the first frame update
    void Start()
    {

            objectList = GameObject.FindGameObjectsWithTag(choosenTag);
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        if (findByTag)
        {
            ChangeColor();
            foreach (GameObject objeto in objectList)
            {
                objeto.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
}
