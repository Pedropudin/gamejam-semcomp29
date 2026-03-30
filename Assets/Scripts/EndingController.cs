using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    public TextMeshProUGUI endingText;

    private string final0 = "Você não foi capaz de fazer muita coisa.\nApós mais investigações a polícia chegou a conclusão de que suas deduções estavam incorretas.\nO assassino continua a solta.";
    private string final1 = "Depois da análise das digitais na faca foi possível comprovar que eram do Pedro, enquanto o corpo foi identificado como sendo o da maria.\nContudo você não pode definir que o assassino em série teria algum envolvimento com o caso.\nO assassino continua a solta";
    private string final2 = "Sua análise não apenas estava correta, como você notou que Pedro estava se defendendo de Maria, percebendo que na casa dela haviam compostos químicos que iriam mata-lo\nVocê inocentou o garoto e no final das contas, o assassino já estava morto.\nBom trabalho!";

    void Start()
    {
        switch (InventoryController.Instance.GetEndingStatus())
        {
            case 0:
                endingText.text = final0;
                break;
            case 1:
                endingText.text = final1;
                break;
            case 2:
                endingText.text = final2;
                break;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
