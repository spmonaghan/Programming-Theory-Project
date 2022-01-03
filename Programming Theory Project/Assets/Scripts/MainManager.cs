using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public int animalIndex { get; private set; }//ENCAPSULATION
    public static MainManager Instance { get; private set; } //MORE ENCAPSULATION
    
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

    public void AnimalChosen(int animalNumber)
    {
        animalIndex = animalNumber;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
