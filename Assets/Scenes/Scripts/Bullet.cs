using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 8.0f;
    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start() {
        // 앞으로 speed 속도 만큼 계속 이동
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
                playerController.Die();
        } else if (other.tag == "Wall") {
            Destroy(gameObject, 0.0f);
        }
    }
}
