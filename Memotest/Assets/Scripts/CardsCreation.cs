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
        positions[0] = new Vector3(0,-4.5f,2);
        positions[1] = new Vector3(-5, -4.5f, 2);
        positions[2] = new Vector3(0, -4.5f, -3);
        positions[3] = new Vector3(-5, -4.5f, -3);
        positions[4] = new Vector3(5, -4.5f, -3);
        positions[5] = new Vector3(-2, -4.5f, -9);
        positions[6] = new Vector3(-6, -4.5f, -9);
        positions[7] = new Vector3(5, -4.5f, -3);
        positions[8] = new Vector3(2, -4.5f, -9);
        positions[9] = new Vector3(6, -4.5f, -9);

        RandomizePositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomizePositions()
    {
        for (var i = 0; i < cards.Count; i++)        
        {
            var index = Random.Range(0, cards.Count);
            var pos = positions[Random.Range(0, positions.Count)];
            cards[i].transform.position = pos;
            positions.RemoveAt(index);

        }

    }
}
