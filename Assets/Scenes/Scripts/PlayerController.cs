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
         * 힘을 가해서 움직이는 방식 - AddForce
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

        // 키(키보드, 조이스틱)로부터 입력받은 수치를 가져와 사용할 속도값으로 변환
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // 벡터값으로 변환 후 플레이어의 Rigidbody 물리에 적용
        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);
        playerRigidbody.velocity = newVelocity;

    }

    public void Die() {
        gameObject.SetActive(false);
    }
}
