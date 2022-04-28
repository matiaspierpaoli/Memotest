using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCard : MonoBehaviour
{
    private int maxObjects = 2;
    public static GameObject[] gameObjects;
    public static Collider[] colliders;
    private void Start()
    {
        gameObjects = new GameObject[maxObjects];
        colliders = new Collider[maxObjects];       
    }

    private void OnMouseDown()
    {
        CreateTwoCards();
        IfTwoCards();
    }

    private void CreateTwoCards()
    {
        if (CardsCreation.cardsInstances.Count == 0)
        {
            gameObjects[0] = this.gameObject;
            colliders[0] = this.GetComponent<Collider>();
            CardsCreation.cardsInstances.Add(gameObjects[0]);
            RotateThisCard();
        }
        else if (CardsCreation.cardsInstances.Count > 0 && CardsCreation.cardsInstances.Count < 2)
        {
            gameObjects[1] = this.gameObject;

            if (gameObjects[1] != gameObjects[0])
            {
                colliders[1] = this.GetComponent<Collider>();
                CardsCreation.cardsInstances.Add(gameObjects[1]);
                RotateThisCard();
            }

        }
    }

    private void RotateThisCard()
    {
        transform.Rotate(180, 0, 0);
    }

    private void IfTwoCards()
    {
        if (CardsCreation.cardsInstances.Count == 2)
        {
            if (gameObjects[0].CompareTag("Whale") && gameObjects[1].CompareTag("Whale"))
            {
                DisableColliders();
                WinObjective.winObjective++;
            }
            else if (gameObjects[0].CompareTag("Lion") && gameObjects[1].CompareTag("Lion"))
            {
                DisableColliders();
                WinObjective.winObjective++;
            }
            else if (gameObjects[0].CompareTag("Dolphin") && gameObjects[1].CompareTag("Dolphin"))
            {
                DisableColliders();
                WinObjective.winObjective++;
            }
            else if (gameObjects[0].CompareTag("Horse") && gameObjects[1].CompareTag("Horse"))
            {
                DisableColliders();
                WinObjective.winObjective++;
            }
            else if (gameObjects[0].CompareTag("Giraffe") && gameObjects[1].CompareTag("Giraffe"))
            {
                DisableColliders();
                WinObjective.winObjective++;
            }
            else
            {
                gameObjects[0].transform.Rotate(180, 0, 0);
                gameObjects[1].transform.Rotate(180, 0, 0);
            }

            if (WinObjective.winObjective == 5)
            {
                Debug.Log("Hola");
            }

            CardsCreation.cardsInstances.Clear();
        }
    }

    private void DisableColliders()
    {
        colliders[0].GetComponent<Collider>().enabled = false;
        colliders[1].GetComponent<Collider>().enabled = false;
    }

  
}
