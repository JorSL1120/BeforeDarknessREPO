using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Value = 1;

    public void Show()
    {

    }

    public void Hide()
    {
        transform.gameObject.SetActive(false);
    }
}