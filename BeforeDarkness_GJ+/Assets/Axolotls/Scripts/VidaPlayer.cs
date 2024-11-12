using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public CharacterController CC;
    public Slider VidaVela;
    public float increasespeed;
    public float decreasespeed;
    public float decreasesprint;
    public bool isRecharging = false;
    //private float stop = 0.2f;

    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        RecargarVela();
        BajarVela();
    }

    void RecargarVela()
    {
        /*if (Inventory2.Cerillos > 0)
        {
            if (Input.GetKey(KeyCode.R) && VidaVela.value < VidaVela.maxValue)
            {
                isRecharging = true;
            }
        }*/
    }


    void BajarVela()
    {
        if (VidaVela.value <= 100 && Input.GetAxis("Run") > 0)
        {
            VidaVela.value -= (decreasesprint * decreasespeed) * Time.deltaTime;
        }
        else if (VidaVela.value <= 100)
        {
            VidaVela.value -= decreasespeed * Time.deltaTime;
        }
    }
}
