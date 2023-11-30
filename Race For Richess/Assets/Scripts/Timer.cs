using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float sayac;
    private Slider zaman;
    private Text info;
    public AudioSource arabasesi, music;
    public Text kaybet;


    private void Awake()
    {
        info = GameObject.FindWithTag("info").GetComponent<Text>();
        zaman = GameObject.Find("Timer").GetComponent<Slider>();
    }

    void Start()
    {
        zaman.maxValue = 250;
        zaman.minValue = 0;
        zaman.wholeNumbers = false;
        zaman.value = zaman.maxValue;
        sayac = zaman.value;
    }



    void Update()
    {
        if(zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;
            zaman.value = sayac;
            info.text = ((int)zaman.value).ToString();
        }
        else
        {
            info.text = "Süre Doldu";
            
            arabasesi.Stop();
            music.Stop();
            kaybet.text = "Süren doldu oyunu tekrar başlatmak için sağ üste tıkla";
            Time.timeScale = 1.0f;
            
        }
    }
}
