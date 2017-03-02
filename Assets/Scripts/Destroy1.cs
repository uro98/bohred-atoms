using UnityEngine;
using System.Collections;

public class Destroy1 : MonoBehaviour {

    public GameObject ps;
    public GameObject rotator;
    public static int electronCount1;

    private GameController gc;

    void Start()
    {
        electronCount1 = 18;
        gc = GameObject.FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet2")
        {
            electronCount1--;
            gc.ElementName1(electronCount1);
            if (electronCount1 == 0)
            {
                gc.Win();
            }
            Instantiate(ps, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(rotator);
        }
    }
}
