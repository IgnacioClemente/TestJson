using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public WeaponDataCollection WeaponDataCollection;

    string dataToSave;

    private void Awake()
    {
        WeaponData espada = new WeaponData(5, 4, "Espada");
        WeaponData arco = new WeaponData(8, 1, "Arco");
        WeaponData daga = new WeaponData(3, 5, "Daga");

        WeaponDataCollection.WeaponData = new List<WeaponData>();
        WeaponDataCollection.WeaponData.Add(espada);
        WeaponDataCollection.WeaponData.Add(arco);
        WeaponDataCollection.WeaponData.Add(daga);

        dataToSave = JsonUtility.ToJson(WeaponDataCollection);
        Debug.Log(dataToSave);
        SaveData();
    }

    public void SaveData()
    {
        if(!File.Exists(Application.streamingAssetsPath + "weapons.json"))
            File.WriteAllText(Application.streamingAssetsPath + "weapons.json", dataToSave);
    }
}
