using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static int health = 100;
    public static int curHealth = 100;
    public static int healthr = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("regen", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            curHealth = health;

        }
        if (curHealth > health)
        {
            curHealth = health;
        }
    }
    void regen()
    {
        curHealth += healthr;
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 70, 30), "H" + curHealth);
    }
}
