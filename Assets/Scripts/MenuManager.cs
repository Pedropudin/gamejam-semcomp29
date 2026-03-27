using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string initialLevel;
    [SerializeField] private LevelLoader levelLoader;

    public void Jogar()
    {
        levelLoader.LoadLevel(initialLevel);
    }

    public void Sair()
    {
        Debug.Log("Saindo");
        Application.Quit();
    }
}