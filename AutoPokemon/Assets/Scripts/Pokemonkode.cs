using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemonkode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Figur Pikachu = new Figur();
        Pikachu.Pokemon(300);
        System.Console.WriteLine(Pikachu);

    }
  
    // Update is called once per frame
    void Update()
    {

        System.Console.WriteLine("s");
    }
}
