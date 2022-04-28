using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsCreation : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();
    
    //private static int maxPositions = 10;
    private List<Vector3> positions = new List<Vector3>();
    
    public static List<GameObject> cardsInstances = new List<GameObject>();

   

    // Start is called before the first frame update
    void Start()
    {
        positions.Add(new Vector3(0, -4.5f, 2));
        positions.Add(new Vector3(-5, -4.5f, 2));
        positions.Add(new Vector3(0, -4.5f, -3));
        positions.Add(new Vector3(-5, -4.5f, -3));
        positions.Add(new Vector3(5, -4.5f, -3));
        positions.Add(new Vector3(-2, -4.5f, -9));
        positions.Add(new Vector3(-6, -4.5f, -9));
        positions.Add(new Vector3(5, -4.5f, -3));
        positions.Add(new Vector3(2, -4.5f, -9));
        positions.Add(new Vector3(6, -4.5f, -9));

        RandomizePositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomizePositions()
    {
        int index = 0;
        Vector3 pos;

        for (var i = 0; i < cards.Count; i++)
        {
            index = Random.Range(0, positions.Count);
            pos = positions[Random.Range(0, positions.Count)];
            cards[i].transform.localPosition = pos;
            positions.RemoveAt(index);

        }

        Debug.Log("Hola");

    }
}
