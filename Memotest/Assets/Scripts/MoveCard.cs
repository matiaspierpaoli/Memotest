using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : MonoBehaviour
{
    private void Start()
    {
        
       
    }

    private void OnMouseDown()
    {
        CardsCreation.cards.Add(GetComponent<GameObject>());

        //CardsCreation.cards.deactivate();

        for (var i = 0; i < CardsCreation.cards.Count; i++)
        {
            if (CardsCreation.cards[i])
            {

            }
        }

       
        transform.Rotate(180, 0, 0);      

    }
}
