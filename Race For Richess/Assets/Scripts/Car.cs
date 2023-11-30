using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public WheelCollider önsoltekerlek, önsagtekerlek, arkasoltekerlek, arkasagtekerlek;
    public float motorhızı, dönmehızı;
    public Joystick tus;
    public GameObject coin, engel;
    public skor coinskor;
    public AudioSource crashSound;
    public AudioSource arabasesi, music;
    public Text kaybet;
    private Text info;
    public int coinsayac = 0;
    public int maxsayac = 28;
    public int eksikaltin;
    


    void Update()
    {
        arkasagtekerlek.motorTorque = motorhızı * tus.Vertical;
        arkasoltekerlek.motorTorque = motorhızı * tus.Vertical;
        önsagtekerlek.steerAngle = dönmehızı * tus.Horizontal;
        önsoltekerlek.steerAngle = dönmehızı * tus.Horizontal;

        if(tus.Vertical < 0)
        {
            arabasesi.Play();
        }

      
    }


    public void OnTriggerEnter(Collider nesne)
    {
        if(nesne.gameObject.tag == "coin")
        {
            coinskor.coinsayisi += Random.Range(1,2);
            crashSound.Play();
            Destroy(nesne.gameObject);
            coinsayac += 1;
        }

        if (nesne.gameObject.tag == "engel")
        {
            Time.timeScale = 0.0f;
            arabasesi.Stop();
            music.Stop();
            kaybet.text = "KAYBETTİN... TEKRAR OYNAMAK İÇİN SAĞ ÜSTE TIKLA";
            
        }

        if(nesne.gameObject.tag == "duvar")
        {
            Time.timeScale = 0.0f;
            arabasesi.Stop();
            music.Stop();
        }

        if(nesne.gameObject.tag == "soncoin")
        {
            coinsayac += 1;

            if (coinsayac == maxsayac)
            {
            crashSound.Play();
            Destroy(nesne.gameObject);
            kaybet.text = "TEBRİKLER!! KAZANDIN";
            arabasesi.Stop();
            Time.timeScale = 0.0f;
            }


            if (coinsayac < maxsayac)
            {
                eksikaltin = maxsayac - coinsayac;
                kaybet.text = eksikaltin.ToString() + " Tane eksik altının var. Geri dönmelisin.";
            }
        }

       

        

    }
}
