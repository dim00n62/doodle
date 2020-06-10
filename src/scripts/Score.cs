using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform camera;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = camera.position.y.ToString("0");
    }
}
