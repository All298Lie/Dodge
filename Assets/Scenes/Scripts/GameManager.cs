using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject gameOverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;

    // Start is called before the first frame update
    void Start() {
        surviveTime = 0.0f;
        isGameover = false;
    }

    // Update is called once per frame
    void Update() {
        if (!isGameover) {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;

        } else {
            if (Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene("Dodge");
            }
        }
    }

    public void EndGame() {
        isGameover = true;

        float record = PlayerPrefs.GetFloat("BestTime");
        if (record < surviveTime) {
            PlayerPrefs.SetFloat("BestTime", surviveTime);
            record = surviveTime;
        }

        recordText.text = "Best Record " + (int)record;

        gameOverText.SetActive(true);
    }
}
