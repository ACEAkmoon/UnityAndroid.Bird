using UnityEngine;
using UnityEngine.UI;
//using System.Collections;

public class Grass : MonoBehaviour {

    private int Score = 0;
    public Text countText;

    void Awake()
    {
        GUI.Label(new Rect(0, 0, 0, 0), "" + Score);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
            Score++;
        //GUI.Label(new Rect(10, 10, 100, 20), "" + Score);
        //Console.WriteLine("\nOur result is {0} ", Score);
    }
}
