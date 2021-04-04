using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class MusicTag : MonoBehaviour
{
    // public AudioClip music;
    public Sprite sprite;
    public float volume;
    public int musicNum;

    private void Awake()
    {
        this.gameObject.SetActive(MusicController.GetInstance().list[musicNum]);
    }

    private void Start()
    {
        if (volume == 0)
        {
            volume = 0.5f;
        }
    }

    // 

    public void ChangeScene()
    {
        MusicController controller = MusicController.GetInstance();
        controller.music = GameObject.Find("Clips").GetComponent<AudioClipList>().clips[musicNum];
        controller.sprite = this.sprite;
        controller.volume = this.volume;
        controller.list[musicNum] = false;
        SceneManager.LoadScene("musicscene");
    }
}
