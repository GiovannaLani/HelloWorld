using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableCharacters
{
public abstract class Character
{
    public string name;
    public int healthPoints = 5;
    public int HealthPoints { get => healthPoints; set => healthPoints = value; }
    public Character(string name)
    {
        this.name = name;
        Debug.Log("Hola soy "+name);
    }
    ~Character()
    {
        Debug.Log(name + "ha muerto");
    }

    public abstract void TakeDamage();
}
}
