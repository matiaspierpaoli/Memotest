using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCard : MonoBehaviour
{
    private int maxObjects = 2;
    public static GameObject[] gameObjects;
    public static List<Collider> actualColliders;
    public List<Collider> everyCollider;
    private void Start()
    {
        gameObjects = new GameObject[maxObjects];
        actualColliders = new List<Collider>();     
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
            actualColliders.Add(this.GetComponent<Collider>());
            CardsCreation.cardsInstances.Add(gameObjects[0]);
            RotateThisCard();
        }
        else if (CardsCreation.cardsInstances.Count > 0 && CardsCreation.cardsInstances.Count < 2)
        {
            gameObjects[1] = this.gameObject;

            if (gameObjects[1] != gameObjects[0])
            {
                actualColliders.Add(this.GetComponent<Collider>());
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
                DisableAllColliders();
                Invoke("RotateBothCards", 2);
                EnablePreviousColliders();
            }
            
            CardsCreation.cardsInstances.Clear();
        }
    }

    private void RotateBothCards()
    {
        gameObjects[0].transform.Rotate(180, 0, 0);
        gameObjects[1].transform.Rotate(180, 0, 0);
    }

    private void DisableColliders()
    {
        for (int i = 0; i < actualColliders.Count; i++)
        {
            actualColliders[i].enabled = false;
        }      
    }

    private void DisableAllColliders()
    {
        for (int i = 0; i < everyCollider.Count; i++)
        {
            everyCollider[i].enabled = false;
           
        }   
    }

    private void EnablePreviousColliders()
    {
        for (int i = 0; i < everyCollider.Count; i++)
        {
            for (int j = 0; j < actualColliders.Count; j++)
            {
                if (everyCollider[i] != actualColliders[j])
                {
                    everyCollider[i].enabled = true;
                }
            }                       
        }
    }
}
