using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody playerRigidbody;
    private float speed = 8.0f;

    // Start is called before the first frame update
    void Start() {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        // Ű���� ����Ű �������� �̵�
        if (Input.GetKey(KeyCode.UpArrow) == true) {
            playerRigidbody.AddForce(0.0f, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true) {
            playerRigidbody.AddForce(0.0f, 0.0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true) {
            playerRigidbody.AddForce(speed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            playerRigidbody.AddForce(-speed, 0.0f, 0.0f);
        }
    }

    // �÷��̾ ����� ���
    public void Die() {
        gameObject.SetActive(false);
    }
}
