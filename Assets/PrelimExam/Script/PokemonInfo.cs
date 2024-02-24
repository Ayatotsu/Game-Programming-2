using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Analytics;

public class PokemonInfo : MonoBehaviour
{
    public Pokemon pokemon;

    [Header("UI Headers")]

    public TextMeshProUGUI pokemonName;
    public TextMeshProUGUI pokemonTypes;
    public TextMeshProUGUI pokemonGender;
    public TextMeshProUGUI pokemonHp;
    public TextMeshProUGUI pokemonAtk;
    public TextMeshProUGUI pokemonSpAtk;
    public TextMeshProUGUI pokemonDef;
    public TextMeshProUGUI pokemonSpDef;
    public TextMeshProUGUI pokemonSpeed;
    [Header("Image References")]
    public Image image;
    public Image bgImage;
    public void ShowUI() 
    {
        DisplayPokemon(pokemon);
    }
    public void DisplayPokemon(Pokemon pokemon)
    {
        pokemonName.text = "Name:  " + pokemon.name;
        pokemonTypes.text = "Types:  " + pokemon.types.ToString() + ", " + pokemon.types2.ToString();
        pokemonGender.text = "Gender:  " + pokemon.gender.ToString();
        pokemonHp.text = "HP:  " + pokemon.pHp.ToString();
        pokemonAtk.text = "Atk:  " + pokemon.atk.ToString();
        pokemonSpAtk.text = "SpAtk:  " + pokemon.spatk.ToString();
        pokemonDef.text = "Def:  " + pokemon.def.ToString();
        pokemonSpDef.text = "SpDef:  " + pokemon.spdef.ToString();
        pokemonSpeed.text = "Speed:  " + pokemon.speed.ToString();
        image.sprite = pokemon.image;
        bgImage.sprite = pokemon.bgImage;

    }

    public void ClearUI()
    {
        pokemon = null;
        pokemonName = null;
        pokemonTypes = null;
        pokemonGender = null;
        pokemonHp = null;
        pokemonAtk = null;
        pokemonSpAtk = null;
        pokemonDef = null;
        pokemonSpDef = null;
        pokemonSpeed = null;
        image = null;
        bgImage = null;
    }

    public void OnDisable()
    {
        ClearUI();
    }
}
