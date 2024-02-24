using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class PokemonButton : MonoBehaviour
{
    [Header("Text References")]
    
    public TextMeshProUGUI pokemonName;
    public TextMeshProUGUI pTypes;
    public TextMeshProUGUI pGender;
    public TextMeshProUGUI pHp;
    public TextMeshProUGUI pAtk;
    public TextMeshProUGUI pSpAtk;
    public TextMeshProUGUI pDef;
    public TextMeshProUGUI pSpDef;
    public TextMeshProUGUI pSpeed;
    [Header("Image References")]
    public Image image;
    public Image bgImage;

    public void SetPokemonData(Pokemon cPokemon)
    {
        pokemonName.text = "Name:  " + cPokemon.name;
        pTypes.text = "Types:  " + cPokemon.types.ToString() + ", " + cPokemon.types2.ToString();
        pGender.text = "Gender:  " + cPokemon.gender.ToString();
        pHp.text = "HP:  " + cPokemon.pHp.ToString();
        pAtk.text = "Atk:  " + cPokemon.atk.ToString();
        pSpAtk.text = "SpAtk:  " + cPokemon.spatk.ToString();
        pDef.text = "Def:  " + cPokemon.def.ToString();
        pSpDef.text = "SpDef:  " + cPokemon.spdef.ToString();
        pSpeed.text = "Speed:  " + cPokemon.speed.ToString();
        image.sprite = cPokemon.image;
        bgImage.sprite = cPokemon.bgImage;
    }
    
    
}
