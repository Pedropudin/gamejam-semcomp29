using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string level;
    [SerializeField] private LevelLoader levelLoader;

    public void Jogar()
    {
        levelLoader.LoadLevel(level);
        Debug.Log("AAAAAAAa");
    }

    public void Sair()
    {
        Debug.Log("Saindo");
        Application.Quit();
    }
}