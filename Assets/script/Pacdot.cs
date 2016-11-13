using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Check if the isTrigger option on th Collider2D is set to true or false
        if (this.GetComponent<Collider2D>().isTrigger)
        {
            Debug.Log("This Collider2D can be triggered");
        }
        else
        {
            Debug.Log("This Collider2D cannot be triggered");
        }
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void onTriggerEnter2D(Collider2D co)
    {
        Debug.Log(co.name);
        if (co.name == "pacman")
        {
            Destroy(gameObject);
        }
    }
}
