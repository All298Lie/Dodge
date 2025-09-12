using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 8.0f;
    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start() {
        // ������ speed �ӵ� ��ŭ ��� �̵�
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        // 3�� �ڿ� ����
        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
                playerController.Die();
        }
    }
}
