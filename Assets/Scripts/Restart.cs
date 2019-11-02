using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void OnMouseDown()
    {
        Bird.start = true;
        SceneManager.LoadScene("SampleScene");
    }
}
