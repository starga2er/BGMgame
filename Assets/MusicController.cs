using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController 
{

    private static MusicController _instance = null;

    public AudioClip music;
    public Sprite sprite;
    public float volume;
    public bool[] list = new bool[100];

    private MusicController()
    {
        for (int i = 0; i < 100; i++)
        {
            list[i] = true;
        }
    }

    public static MusicController GetInstance()
    {
        if (_instance == null) _instance = new MusicController();
        return _instance;
    }

}
