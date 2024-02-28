using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelloWorld1
{

public class HelloWorld : MonoBehaviour
{
        Enemy enemy;
        Player player;
    // Start is called before the first frame update
    void Start()
    {
        enemy = new Enemy("Voldemort",2,true);
        player = new Player("HP", 4, true);
    }

    // Update is called once per frame
    void Update()
    {
            enemy.TakeDamage();
            player.TakeDamage();

            Debug.Log("Vida enemy: " + enemy.healthPoints + " vida player: " + player.healthPoints);

    }
}
}
