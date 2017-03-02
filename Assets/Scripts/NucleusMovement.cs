using UnityEngine;
using System.Collections;

public class NucleusMovement : MonoBehaviour {

    public GameObject Player;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position = new Vector3(transform.position.x, Player.GetComponent<Transform>().position.y, transform.position.z);
    }
}
