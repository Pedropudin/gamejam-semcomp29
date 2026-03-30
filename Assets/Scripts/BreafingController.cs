using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreafingController : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(!InventoryController.Instance.GameState());
    }

    public void CloseBreafing()
    {
        InventoryController.Instance.GameStarted();
    }
}
