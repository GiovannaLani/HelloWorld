using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy("Voldemort",2,true);
        Player player = new Player("HP", 4, true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World");

    }
}
