﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;
    [Range(0f, 5f)]
    public float dopplerLevel;
    [Range(0, 1000)]
    public int maxDistance;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
