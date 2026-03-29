using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance { get; private set; }
    private List<string> inventory = new List<string>();
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        } else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddItem(string name)
    {
        inventory.Add(name);
    }

    public void RemoveItem(string name)
    {
        if (HasItem(name))
        {
            inventory.Remove(name);
        } else
        {
            Debug.LogWarning("Item não encontrado no inventário");
        }
    }

    public List<string>GetAllItens()
    {
        return inventory;
    }

    public bool HasItem(string name)
    {
        return inventory.Contains(name);
    }

}
