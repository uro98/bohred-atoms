using UnityEngine;
using System.Collections;

public class Destroy2 : MonoBehaviour {

    public GameObject ps;
    public GameObject rotator;
    public static int electronCount2;

    private GameController gc;

    void Start()
    {
        electronCount2 = 18;
        gc = GameObject.FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet1")
        {
            electronCount2--;
            gc.ElementName2(electronCount2);
            if (electronCount2 == 0)
            {
                gc.Win();
            }
            Instantiate(ps, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(rotator);
        }
    }
}
