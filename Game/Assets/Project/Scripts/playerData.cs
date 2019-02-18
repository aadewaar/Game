using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[System.Serializable]
public class playerData {

    public int health;
    public float[] position;

    public playerData (Stats stats)
    {
        health = Stats.curHealth;

        position = new float[3];
        position[0] = stats.transform.position.x;
        position[1] = stats.transform.position.y;
        position[2] = stats.transform.position.z;
    } 
	
}
