using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static int Llave;
    public static int Cerillos = 3;
    public static int LibroMorado;
    public static int LibroBlanco;
    public static int LibroCyan;
    public static int Estatua;

    public void AddLlave(int amount)
    {
        Llave += amount;
    }

    public void AddCerillo(int amount)
    {
        Cerillos += amount;
    }

    public void AddLibroMorado(int amount)
    {
        LibroMorado += amount;
    }

    public void AddLibroBlanco(int amount)
    {
        LibroBlanco += amount;
    }

    public void AddLibroCyan(int amount)
    {
        LibroCyan += amount;
    }

    public void AddEstatua(int amount)
    {
        Estatua += amount;
    }



    public void RestLlave(int amount)
    {
        Llave -= amount;
    }

    public void RestCerillos(int amount)
    {
        Cerillos -= amount;
    }

    public void RestLibroMorado(int amount)
    {
        LibroMorado -= amount;
    }

    public void RestLibroBlanco(int amount)
    {
        LibroBlanco -= amount;
    }

    public void RestLibroCyan(int amount)
    {
        LibroCyan -= amount;
    }

    public void RestEstatua(int amount)
    {
        Estatua -= amount;
    }
}
