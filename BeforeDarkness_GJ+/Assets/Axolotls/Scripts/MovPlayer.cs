using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Inventory))]
public class MovPlayer : MonoBehaviour
{
    Inventory inv;
    public CharacterController CC;
    public float Speed;
    private float sprint = 1.5f;

    public Slider RecargaVela;
    public float increasespeed;
    public float decreasespeed;
    public float decreasesprint;
    public bool isRecharging = false;
    private float stop = 0.2f;

    void Start()
    {
        CC = GetComponent<CharacterController>();
        inv = GetComponent<Inventory>();
    }

    void Update()
    {
        Movimiento();
        RecarVela();
        DecVela();
    }


    void Movimiento()
    {
        Vector3 movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        movimiento.Normalize();

        float velocidadMovimiento = 0f;

        if (isRecharging)
        {
            velocidadMovimiento = stop;
        }
        else if (Input.GetAxis("Run") > 0)
        {
            velocidadMovimiento = Speed * sprint;
        }
        else
        {
            velocidadMovimiento = Speed;
        }

        if (movimiento != Vector3.zero)
        {
            CC.Move(movimiento * velocidadMovimiento * Time.deltaTime);
        }
    }

    void RecarVela()
    {
        if (Inventory.Cerillos > 0)
        {
            if (Input.GetKey(KeyCode.R) && RecargaVela.value < RecargaVela.maxValue)
            {
                isRecharging = true;
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
