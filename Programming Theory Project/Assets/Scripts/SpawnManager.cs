using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("AnimalSpawning");
    }

    IEnumerator AnimalSpawning()
    {
        while (true)
        {
            Instantiate(animals[InfoManager.Instance.animalIndex]);
            yield return new WaitForSeconds(2);
        }  
    }
}
