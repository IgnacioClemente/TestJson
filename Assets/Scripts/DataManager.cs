using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public WeaponDataCollection WeaponDataCollection;
    public string path = "weapons.json";

    string dataToSave;
    string loadedData;
    string dataPath;

    private WeaponDataCollection loadedWeaponData;

    private void Awake()
    {
        dataPath = Application.streamingAssetsPath + path;
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) LoadData();    
    }

    public void SaveData()
    {
        if(!File.Exists(dataPath))
            File.WriteAllText(dataPath, dataToSave);
    }

    public void LoadData()
    {
        if (File.Exists(dataPath))
        {
            loadedWeaponData = JsonUtility.FromJson<WeaponDataCollection>(File.ReadAllText(dataPath));
            Debug.Log("Existe ");
            for (int i = 0; i < loadedWeaponData.WeaponData.Count; i++)
            {
                Debug.Log(loadedWeaponData.WeaponData[i].Nombre);
            }
        }
    }
}
