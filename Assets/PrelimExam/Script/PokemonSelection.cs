using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelection : MonoBehaviour
{
    public Pokemon[] pokemons;
    public PokemonLists pokemonLists;

    public Transform parentPos;

    public GameObject pokemonButtonPrefab;

    public TextMeshProUGUI btnText;
    
    public PokemonInfo pokemonInfo;

    public GameObject stats;

    public GameObject selections;

    public GameObject image;
    


    void Start()
    {
        Debug.Log(pokemonLists.pokemons.Count());
        foreach (Pokemon p in pokemonLists.pokemons)
        {
            GameObject buttonPrefab = Instantiate(pokemonButtonPrefab, parentPos);
            PokemonButton pokemonButton = buttonPrefab.GetComponent<PokemonButton>();
            pokemonButton.SetPokemonData(p);

            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => pokemonInfo.DisplayPokemon(p));
            DisplayText(p);
            button.onClick.AddListener(() => stats.gameObject.SetActive(true));
            button.onClick.AddListener(() => image.gameObject.SetActive(true));
            
            
        }
    }

    public void DisplayText(Pokemon p) 
    {
        
        
    }

    
}
