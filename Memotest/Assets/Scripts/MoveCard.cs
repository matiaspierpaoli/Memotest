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
        if (CardsCreation.cards.Count == 0)
        {
            gameObjects[0] = this.gameObject;
            colliders[0] = this.GetComponent<Collider>();
            CardsCreation.cards.Add(gameObjects[0]);
            Debug.Log("Se aniadio el primer componente a la lista");           
            transform.Rotate(180, 0, 0);
        }
        else if (CardsCreation.cards.Count > 0 && CardsCreation.cards.Count < 2)
        {
            gameObjects[1] = this.gameObject;
            colliders[1] = this.GetComponent<Collider>();
            CardsCreation.cards.Add(gameObjects[1]);
            Debug.Log("Se aniadio el segundo componente a la lista");          
            transform.Rotate(180, 0, 0);
        }

        if (CardsCreation.cards.Count == 2)
        {
            Debug.Log("Hay dos componentes en la lista");

            if (gameObjects[0].tag == "Whale" && gameObjects[1].tag == "Whale")
            {
                Debug.Log("Ambos gameObjects eran Whale");
                colliders[0].GetComponent<Collider>().enabled = false;
                colliders[1].GetComponent<Collider>().enabled = false;
            }
            else if (gameObjects[0].tag == "Lion" && gameObjects[1].tag == "Lion")
            {
                Debug.Log("Ambos gameObjects eran Lion");
                colliders[0].GetComponent<Collider>().enabled = false;
                colliders[1].GetComponent<Collider>().enabled = false;
            }
            else if (gameObjects[0].tag == "Dolphin" && gameObjects[1].tag == "Dolphin")
            {
                Debug.Log("Ambos gameObjects eran Dolphin");
                colliders[0].GetComponent<Collider>().enabled = false;
                colliders[1].GetComponent<Collider>().enabled = false;
            }
            else if (gameObjects[0].tag == "Horse" && gameObjects[1].tag == "Horse")
            {
                Debug.Log("Ambos gameObjects eran Horse");
                colliders[0].GetComponent<Collider>().enabled = false;
                colliders[1].GetComponent<Collider>().enabled = false;
            }
            else if (gameObjects[0].tag == "Giraffe" && gameObjects[1].tag == "Giraffe")
            {
                Debug.Log("Ambos gameObjects eran Giraffe");
                colliders[0].GetComponent<Collider>().enabled = false;
                colliders[1].GetComponent<Collider>().enabled = false;
            }
            else
            {
                Debug.Log("Los gameObjects volvieron a rotar");
                gameObjects[0].transform.Rotate(180, 0, 0);
                gameObjects[1].transform.Rotate(180, 0, 0);
            }

            CardsCreation.cards.Clear();
            Debug.Log("La lista quedo vacia");
        }
    }
}
