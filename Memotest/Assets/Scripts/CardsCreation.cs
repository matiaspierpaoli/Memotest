using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsCreation : MonoBehaviour
{
    class CardsList
    {
        public bool activated = true;
        public bool isActivated() { return activated; }
        public void deactivate() { activated = false; }
        
        public  List<GameObject> cards;

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
