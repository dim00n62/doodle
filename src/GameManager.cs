using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform camera;
    public Player player;
    public bool isGameEnded = false;

    public GameObject retryPanel;

    private float criticalDistance = 15f;


    // Update is called once per frame
    void Update()
    {
        if (player && (camera.position - player.transform.position).y > criticalDistance) {
            isGameEnded = true;
            retryPanel.SetActive(true);
        }
    }

    public void Restart() {
        isGameEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        retryPanel.SetActive(false);
    }
}
