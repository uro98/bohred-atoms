using UnityEngine;
using System.Collections;

public class ElectronMovement : MonoBehaviour {

    public GameObject Player;
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;

    private Rigidbody2D rb;
    private float speed = 5.0f;
    private float coor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coor = Player.GetComponent<Transform>().position.y;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (coor < 1f && coor > -1.9f)
        {
            if (Input.GetKey(moveUp))
            {
                var vel = rb.velocity;
                vel.y = speed;
                rb.velocity = vel;
            }
            else if (Input.GetKey(moveDown))
            {
                var vel = rb.velocity;
                vel.y = -1 * speed;
                rb.velocity = vel;
            }
            else if (!Input.anyKey)
            {
                var vel = rb.velocity;
                vel.y = 0.0f;
                rb.velocity = vel;
            }
        }
    }
}
