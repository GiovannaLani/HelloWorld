using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name, int life, bool alive) : base(name)
    {
        Debug.Log(this.name);
    }

    public override void takeDamage()
    {
        
    }
}

public class Enemy : Character
{
    public Enemy(string name, int life, bool alive) : base(name)
    {

    }

    public override void takeDamage()
    {
        life--;
    }
}