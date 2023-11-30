using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject menüpaneli, engelpaneli;
    public Text kaybet;

    public void oyunubaslat()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1.0f;
    }

    public void menüpanelac()
    {
        menüpaneli.SetActive(true);
        Time.timeScale = 0.0f;
        kaybet.text = " ";
    }

    public void oyunadevamet()
    {
        menüpaneli.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void anamenuyegit()
    {
        Application.LoadLevel(0);
    }

}
