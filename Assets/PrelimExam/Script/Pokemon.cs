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
    
    public void Attack() 
    {
        Debug.Log($"{name} used Tackle!");
    }
    
}
