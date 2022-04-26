using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : MonoBehaviour
{
    public CardsCreation intermediate;
    private void OnMouseDown()
    {
        
        transform.Rotate(180, 0, 0);      

    }
}
