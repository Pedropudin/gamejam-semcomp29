using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuController : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI buttonText;
    public GameObject inventoryTab;
    public TextMeshProUGUI itemDescription;

    public GameObject inventoryObject;

    private List<string> inventoryItems;

    void Start()
    {
        inventoryTab.SetActive(false);
        itemDescription.gameObject.SetActive(false);

        button.onClick.AddListener(OpenInventory);
        buttonText.text = "Inventário";
    }

    private void OpenInventory()
    {
        inventoryTab.SetActive(true);
        itemDescription.gameObject.SetActive(true);
        inventoryItems = InventoryController.Instance.GetAllItens();
        // inventoryItems = new List<string> { "abajur", "copo" };
        foreach (string item in inventoryItems)
        {
            inventoryObject.GetComponentInChildren<TextMeshProUGUI>().text = item;
            inventoryObject.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Objetos/" + item);

            Instantiate(inventoryObject, inventoryTab.transform);
        }

        button.onClick.RemoveAllListeners();
        buttonText.text = "Fechar";
        button.onClick.AddListener(CloseInventory);
    }

    private void UpdateDescription(string description)
    {
        Debug.Log("Clicou");
        Debug.Log(description);
        itemDescription.text = description;
    }

    private void CloseInventory()
    {
        inventoryTab.SetActive(false);
        itemDescription.gameObject.SetActive(false);

        foreach (Transform child in inventoryTab.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        button.onClick.RemoveAllListeners();
        buttonText.text = "Inventário";
        button.onClick.AddListener(OpenInventory);
    }
}
