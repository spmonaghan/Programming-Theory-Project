using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoManager : MonoBehaviour
{
    public int animalIndex { get; private set; }//ENCAPSULATION
    public static InfoManager Instance { get; private set; } //ENCAPSULATION
    
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void AnimalChosen(int animalNumber)
    {
        animalIndex = animalNumber;
    }

}
