using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    void Start()
    {
        if (CSVUtils.TryReadJson(out DataBase dataBase))
        {
            foreach (Data data in dataBase.DataInstances)
            {
                Debug.Log($"{data.Name}: {data.Description}");
            }
        }
        else
        {
            Debug.LogError("Can't read json!");
        }
    }
}
