using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[System.Serializable]
public class Save {

    public int health;
    public float[] position;
    private FirstPersonController firstPersonController;

    public Save(FirstPersonController firstPersonController)
    {
        this.firstPersonController = firstPersonController;
    }

    public Save (Stats Stats , FirstPersonController FirstPersonController)
    {
        health = Stats.health;

        position = new float[3];
        position[0] = FirstPersonController.transform.position.x;
        position[1] = FirstPersonController.transform.position.y;
        position[2] = FirstPersonController.transform.position.z;
    } 
	
}
