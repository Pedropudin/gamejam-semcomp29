using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReportController : MonoBehaviour
{
    public Button openReportButton;
    public Button closeReportButton;
    public Button sendButton;
    public GameObject reportPage;

    public TMP_InputField killerNameInput;
    public TMP_InputField victimNameInput;
    public TMP_InputField weaponNameInput;

    void Start()
    {
        openReportButton.onClick.AddListener(Open);
        sendButton.onClick.AddListener(Send);
        closeReportButton.onClick.AddListener(Close);

        reportPage.SetActive(false);
        closeReportButton.gameObject.SetActive(false);
    }

    private void Open()
    {
        reportPage.SetActive(true);
        closeReportButton.gameObject.SetActive(true);
    }

    private void Close()
    {
        reportPage.SetActive(false);
        closeReportButton.gameObject.SetActive(false);
    }

    private void Send()
    {
        int result = CheckReport();

        InventoryController.Instance.SetEndingStatus(result);

        SceneManager.LoadScene("Final");
    }

    private int CheckReport()
    {
        int status = 2;
    
        if(weaponNameInput.text.ToLower() != "faca")
        {
            status = 0;
        }
        if(killerNameInput.text.ToLower() != "pedro")
        {
            status = 0;
        }
        if(victimNameInput.text.ToLower() != "maria")
        {
            status = 0;
        }

        if(status == 2 && InventoryController.Instance.GetInventorySize() < 7)
        {
            status = 1;
        }

        return status;
    }
}
