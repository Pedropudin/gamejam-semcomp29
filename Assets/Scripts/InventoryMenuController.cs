using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuController : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI buttonText;
    public GameObject inventoryTab;

    public GameObject inventoryObject;

    private List<string> inventoryItems;

    void Start()
    {
        inventoryTab.SetActive(false);

        button.onClick.AddListener(OpenInventory);
        buttonText.text = "Inventário";
    }

    private void OpenInventory()
    {
        inventoryTab.SetActive(true);
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

    private void CloseInventory()
    {
        inventoryTab.SetActive(false);

        foreach (Transform child in inventoryTab.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        button.onClick.RemoveAllListeners();
        buttonText.text = "Inventário";
        button.onClick.AddListener(OpenInventory);
    }
}
