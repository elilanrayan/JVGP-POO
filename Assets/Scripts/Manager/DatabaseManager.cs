using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{

    public PokemonDataBase database;
    public PokemonData GetData(int id) => database.datas[id];

    public int GetCount() => database.datas.Count;


    public void Start()
    {
       // database.InitData();
        database.CreateData();
    }



}
