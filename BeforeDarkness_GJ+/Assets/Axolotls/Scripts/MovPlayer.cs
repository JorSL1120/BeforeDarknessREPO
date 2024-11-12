using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public CharacterController CC;
    public float Speed;
    private float sprint = 1.5f;

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

        /*if (movimiento != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movimiento);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speedRotation);
        }*/

        if (Input.GetAxis("Run") > 0)
        {
            CC.Move(movimiento * (Speed * sprint) * Time.deltaTime);
        }
        else
        {
            CC.Move(movimiento * Speed * Time.deltaTime);
        }
    }
}
