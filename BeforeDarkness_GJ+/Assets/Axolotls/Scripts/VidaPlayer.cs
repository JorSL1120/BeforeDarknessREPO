using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Inventory))]
public class VidaPlayer : MonoBehaviour
{
    Inventory inv;
    MovPlayer movPlayer;

    public Slider RecargaVela;
    public float increasespeed;
    public float decreasespeed;
    public float decreasesprint;

    void Start()
    {
        inv = GetComponent<Inventory>();
        movPlayer = GetComponent<MovPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        RecarVela();
        DecVela();

        if (movPlayer.isRecharging)
        {
            RecargaVela.value += increasespeed * Time.deltaTime;

            if (RecargaVela.value >= RecargaVela.maxValue)
            {
                RecargaVela.value = RecargaVela.maxValue;
                movPlayer.isRecharging = false;
                Inventory.Cerillos -= 1;
            }
        }
    }

    void RecarVela()
    {
        if (Inventory.Cerillos > 0)
        {
            if (Input.GetKey(KeyCode.R) && RecargaVela.value < RecargaVela.maxValue)
            {
                movPlayer.isRecharging = true;
            }
        }
    }


    void DecVela()
    {
        if (RecargaVela.value <= 100 && Input.GetAxis("Run") > 0)
        {
            RecargaVela.value -= (decreasesprint * decreasespeed) * Time.deltaTime;
        }
        else if (RecargaVela.value <= 100)
        {
            RecargaVela.value -= decreasespeed * Time.deltaTime;
        }
    }
}
