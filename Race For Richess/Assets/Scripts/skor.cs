using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{

    public Text coinyazisi;
    public float coinsayisi;


    void Start()
    {
        
    }

    
    void Update()
    {
        coinyazisi.text = "Skor: " + coinsayisi;
    }
}
