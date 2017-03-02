using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public KeyCode shoot = KeyCode.LeftArrow;

    public GameObject bullet;
    public Transform bulletSpawn;
    public float fireRate;

    private Rigidbody2D rb;
    private AudioSource audioSource;
    private float movingSpeed = 5.0f;
    private float nextFire = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -1.9f, 1f);
        transform.position = pos;

        if (Input.GetKey(moveUp))
        {
            var vel = rb.velocity;
            vel.y = movingSpeed;
            rb.velocity = vel;
        }
        else if (Input.GetKey(moveDown))
        {
            var vel = rb.velocity;
            vel.y = -1 * movingSpeed;
            rb.velocity = vel;
        }
        else if (!Input.anyKey)
        {
            var vel = rb.velocity;
            vel.y = 0.0f;
            rb.velocity = vel;
        }
        
        if (Input.GetKey(shoot) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            audioSource.Play();
        }

        var reset = rb.velocity;
        reset.x = 0;
        rb.velocity = reset;

    }
}
