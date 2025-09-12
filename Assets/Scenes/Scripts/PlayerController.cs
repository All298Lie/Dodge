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
        /*
         * ���� ���ؼ� �����̴� ��� - AddForce
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
         */

        // Ű(Ű����, ���̽�ƽ)�κ��� �Է¹��� ��ġ�� ������ ����� �ӵ������� ��ȯ
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // ���Ͱ����� ��ȯ �� �÷��̾��� Rigidbody ������ ����
        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);
        playerRigidbody.velocity = newVelocity;

    }

    public void Die() {
        gameObject.SetActive(false);
    }
}
