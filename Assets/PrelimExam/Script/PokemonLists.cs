using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonLists : MonoBehaviour
{
    public Pokemon[] pokemons;
    private string folderPath = "Pokemon";

    void Start()
    {
        pokemons = Resources.LoadAll<Pokemon>(folderPath);
    }

}
