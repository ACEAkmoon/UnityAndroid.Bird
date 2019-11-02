using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

    public GameObject bomb;

    void Start() {
        StartCoroutine(Spawn ());
    }

    IEnumerator Spawn() {
        while (!Bird.lose && Bird.start)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.6f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }

    }
}
