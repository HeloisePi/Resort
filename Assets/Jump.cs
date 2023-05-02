using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float speed = 5.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      float moveInput = Input.GetAxisRaw("Horizontal");
      rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Collision");
            Destroy(other.gameObject);

            // Trouver l'objet avec le tag "Platform"
            GameObject platform = GameObject.FindGameObjectWithTag("Platform");
            BoxCollider2D platformCollider = platform.GetComponent<BoxCollider2D>();
            platformCollider.enabled = true;
        }
    }
}
