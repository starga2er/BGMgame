using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MusicBox : MonoBehaviour
{
    AudioSource mp3;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        mp3 = GetComponent<AudioSource>();
        MusicController controller =  MusicController.GetInstance();
        mp3.clip = controller.music;

        GameObject sqaure = GameObject.Find("Square");
        sqaure.GetComponent<SpriteRenderer>().sprite = controller.sprite;

        float i = controller.sprite.rect.width;
        if (i < controller.sprite.rect.height)
            i = controller.sprite.rect.height;
        sqaure.transform.localScale = new Vector3 (1,1,1) * 900 / i;

        mp3.volume = controller.volume;
        slider.value = controller.volume;
    }

    public void MusicButton1()
    {
        if (mp3.isPlaying) mp3.Pause();
        else mp3.Play();
    }

    public void MusicButton2()
    {
        mp3.Stop();
    }

    public void MusicButton3()
    {
        GameObject.Destroy(GameObject.Find("random"));
    }

    public void MusicButton4()
    {
        SceneManager.LoadScene("main");
    }
    
    public void SliderUpdate()
    {
        mp3.volume = slider.value;
    }

}
