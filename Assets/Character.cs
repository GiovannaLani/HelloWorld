using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableCharacters
{

public abstract class Character
{
    public string name;
    public int life = 1;
    public int Life { get => Life; set => Life = value; }
    public Character(string name)
    {
        this.name = name;
        Debug.Log("Hola soy "+name);
    }
    ~Character()
    {
        Debug.Log(name + "ha muerto");
    }

    public abstract void takeDamage();
}
}
