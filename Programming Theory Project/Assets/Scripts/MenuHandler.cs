using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void SceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
    public void AnimalChoice(int animalNumber)
    {
        InfoManager.Instance.AnimalChosen(animalNumber); //This is really indirect and stupid but it should work
    }
}
