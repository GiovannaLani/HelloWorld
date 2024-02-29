using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] //Para verlo en unity
    private GameObject cube;
  
    void Start()
    {
        //cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        Debug.Log("Cube position: " + cube.transform.position);
        Debug.Log("Cube rotation: " + cube.transform.rotation);
        Debug.Log("Cube scale: " + cube.transform.localScale);
    }
}
