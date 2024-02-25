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
    public TextMeshProUGUI btnNameText;
    
    

    public void SetPokemonData(Pokemon cPokemon)
    {
        btnNameText.text = cPokemon.name;
    }
    
}
