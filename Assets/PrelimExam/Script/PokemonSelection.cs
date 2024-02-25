using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelection : MonoBehaviour
{
    
    public PokemonLists pokemonLists;
    
    public Transform parentPos;

    public GameObject pokemonButtonPrefab;

    public TextMeshProUGUI btnText;

    public PokemonInfo pokemonInfo;

    public GameObject panelInfo;

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
            button.onClick.AddListener(() => panelInfo.gameObject.SetActive(true));
            button.onClick.AddListener(() => image.gameObject.SetActive(true));
            
            
            
        }
    }

    

    
}
