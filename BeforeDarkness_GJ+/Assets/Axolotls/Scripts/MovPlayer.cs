using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovPlayer : MonoBehaviour
{
    public CharacterController CC;
    public float Speed;
    private float sprint = 1.5f;
    public bool isRecharging = false;
    private float stop = 0.2f;

    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movimiento();
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
}
