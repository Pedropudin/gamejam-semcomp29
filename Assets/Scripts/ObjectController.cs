using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    public string objectName;
    public GameObject objectImage;
    public Button objectButton;
    public GameObject foundAnimation;
    public Button foundButton;
    public TextMeshProUGUI foundText;

    private void Start()
    {
        if (InventoryController.Instance.HasItem(objectName))
        {
            objectImage.SetActive(false);
            foundAnimation.SetActive(false);
        } else
        {
            objectImage.SetActive(true);
            foundAnimation.SetActive(false);

            objectButton.onClick.AddListener(OnObjectClick);
            foundButton.onClick.AddListener(OnFoundClick);

            foundText.text += objectName;
        }
    }

    public void OnObjectClick()
    {
        objectImage.transform.position = Vector3.zero;
        foundAnimation.SetActive(true);
        objectButton.onClick.RemoveAllListeners();
        objectButton.onClick.AddListener(OnFoundClick);

        InventoryController.Instance.AddItem(objectName);
    }

    public void OnFoundClick()
    {
        foundAnimation.SetActive(false);
        objectImage.SetActive(false);
    }

}
