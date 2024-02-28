using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayableCharacters;

public class Player : Character
{
    public Player(string name, int life, bool alive) : base(name)
    {
        Debug.Log(this.name);
    }

    public override void TakeDamage()
    {
        
    }
}

public class Enemy : Character
{
    public Enemy(string name, int life, bool alive) : base(name)
    {

    }

    public override void TakeDamage()
    {
        healthPoints--;
    }
}