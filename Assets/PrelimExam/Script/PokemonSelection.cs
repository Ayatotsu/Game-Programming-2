using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelection : MonoBehaviour
{
    
    public PokemonLists pokemonLists;
    public Transform parentPos;
    public GameObject pokemonButtonPrefab;


    void Start()
    {
        Debug.Log(pokemonLists.pokemons.Count());
        foreach (Pokemon p in pokemonLists.pokemons)
        {
            GameObject buttonPrefab = Instantiate(pokemonButtonPrefab, parentPos);
            PokemonButton pokemonButton = buttonPrefab.GetComponent<PokemonButton>();
            pokemonButton.SetPokemonData(p);
            
        }
    }

    
}
