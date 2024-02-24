using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Pokemon", menuName = "ScriptableObjects/Pokemon")]
public class Pokemon : ScriptableObject
{
    public string pName;
    public int pLevel;
    public int pHp;
    public int atk;
    public int spatk;
    public int def;
    public int spdef;
    public int speed;
    public Gender gender;
    public Types types;
    public Types types2;
    public Sprite image;
    public Sprite bgImage;
    Pokemon[] pokemons;
    public void Attack() 
    {
        Debug.Log($"{name} used Tackle!");
    }

    void Start() 
    {
        pokemons[0].name = pName;
        pokemons[1].name = pName;
        pokemons[2].name = pName;
        pokemons[3].name = pName;
        pokemons[4].name = pName;
        pokemons[5].name = pName;
        pokemons[6].name = pName;
        pokemons[7].name = pName;
        pokemons[8].name = pName;
        pokemons[9].name = pName;
    }
}
