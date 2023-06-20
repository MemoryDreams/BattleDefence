using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    Player,
    Base,
    Enemy,
    Else
}

public class VitalityScript : MonoBehaviour
{
    public int healthPoints;
    public int maxHealth;
    public ObjectType objectType;
    GlobalSystemScript GlobalScript;

    void Awake()
    {
        GlobalScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GlobalSystemScript>();
    }

    public void takeDamage(int amount)
    {
        healthPoints-=amount;
        if (healthPoints<=0)
        {
            DetermineType();
            Destroy(gameObject);
        }
    }

    public void DetermineType()
    {
        switch (objectType)
        {
            case ObjectType.Player:
                break;

            case ObjectType.Base:
                GlobalScript.InitiateGameOverScreen();
                break;

            case ObjectType.Enemy:
                break;

            default:

                break;
        }
    }
}
