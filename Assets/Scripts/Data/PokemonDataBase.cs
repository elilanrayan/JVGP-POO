using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName="Pokemon",menuName="Database/Pokemon",order=0)]
public class PokemonDataBase : ScriptableObject
{
    public List<PokemonData> datas=new();
    

    public void InitData()
    {
        datas.RemoveAll(data => data.size <= 0);
    }

    public void CreateData()
    {
        if(!datas.Exists(data => data.name == "Florizzare"))
        {
            PokemonData.Stats stats = datas[0].statsBase;
            Sprite PokeIcon=(Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/florizarre.png", typeof(Sprite));



            datas.Add(new PokemonData(
            "Florizzare", 2, 100, "H/F", PokeIcon, "Ce Pok�mon est capable de transformer la lumi�re du soleil en �nergie. Il est donc encore plus fort en �t�.", stats.GetStatsByLvl(stats, 40, 3)));

        }




    }

    
}
