using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipList : MonoBehaviour
{
    public AudioClip[] clips;
    private static AudioClipList _Instance;

    // Start is called before the first frame update

    void Awake()
    {
        if (_Instance == null)
        {
            _Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);
    }

}