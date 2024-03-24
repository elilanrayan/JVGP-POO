using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PokemonData {


    [Serializable]
    public struct Stats
    {
        public int pv;
        public int atk;
        public int def;
        public int atkSpe;
        public int defSpe;
        public int speed;

        public Stats(int pv,int atk,int def,int atkSpe,int defSpe,int speed)
        {
            this.pv = pv;
            this.atk = atk;
            this.def = def;
            this.atkSpe = atkSpe;
            this.defSpe = defSpe;
            this.speed = speed;
        }

        public Stats (Stats statsBase,int coeff)
        {
            pv = statsBase.pv * coeff;
            atk = statsBase.atk * coeff;
            def = statsBase.def * coeff;
            atkSpe = statsBase.atkSpe * coeff;
            defSpe = statsBase.defSpe * coeff;
            speed = statsBase.speed * coeff;
        }





        public Stats GetStatsByLvl(Stats statsBase,int lvl, int evolution)
        {
            var coeff=(lvl*evolution)/10;
            return new(statsBase, coeff);
           
        }
    }
    public string name;
    public float size;
    public float weight;
    public string sexe;
    public Sprite icon;
    public string caption;
    public string[] faiblesses;
    public string[] types;
    public Stats statsBase;
    public Stats statsSpe;

   

    public PokemonData() { }

    public PokemonData(string name,float size,float weight,string sexe,Sprite icon,string caption,Stats stats)
    {
        this.name = name;
        this.size = size;
        this.weight = weight;
        this.sexe = sexe;
            
        this.icon = icon;
        this.caption = caption;

        this.statsBase = stats;
            
    }





}
    