using UnityEngine;

public class Bird : MonoBehaviour {

    public GameObject restart;
    public GameObject button_start;
    public static bool lose = false;
    public static bool start = false;

    void Awake()
    {
        lose = false;
        if (start == true)
            button_start.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Bomb") {
            lose = true;
            restart.SetActive(true);
        }
    }
}
