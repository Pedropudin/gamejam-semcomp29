using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoom : MonoBehaviour
{
    public string roomName;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(roomName);
    }
}
