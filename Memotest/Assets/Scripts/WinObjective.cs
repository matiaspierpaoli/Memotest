using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinObjective : MonoBehaviour
{
    public static int winObjective = 5;
    public Text WinText;

    // Start is called before the first frame update
    void Start()
    {
        WinText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (winObjective == 5)
        {
            WinText.text = "Congrats!";

        }
    }
}
