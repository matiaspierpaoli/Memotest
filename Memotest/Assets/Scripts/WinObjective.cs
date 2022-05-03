using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinObjective : MonoBehaviour
{
    public static int winObjective = 0;
    public Text WinText;
    public GameObject RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        WinText.text = " ";
        RestartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckObjective();
    }

    private void CheckObjective()
    {
        if (winObjective == 5)
        {
            RestartButton.SetActive(true);
            WinText.text = "Congrats!";

        }
    }
}
