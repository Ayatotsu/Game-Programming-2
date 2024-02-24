using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class PokemonButton : MonoBehaviour
{
    public Pokemon cPokemon;


    [Header("Text References")]
    public GameObject pokemonData;
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

    public void ShowUI()
    {
        SetPokemonData(cPokemon);
        pokemonData.SetActive(true);
        bgImage.gameObject.SetActive(true);
    }

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
    public void ClearUI()
    {
        
        pokemonName = null;
        pTypes = null;
        pGender = null;
        pHp = null;
        pAtk = null;
        pSpAtk = null;
        pDef = null;
        pSpDef = null;
        pSpeed = null;
    }

    public void OnDisable()
    {
        ClearUI();
    }

}
