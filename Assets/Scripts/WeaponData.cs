using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponData
{
    public int Daño;
    public int Defensa;
    public string Nombre;

    public WeaponData(int daño, int defensa, string nombre)
    {
        Daño = daño;
        Defensa = defensa;
        Nombre = nombre;
    }
}
