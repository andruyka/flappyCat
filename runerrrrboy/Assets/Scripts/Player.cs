using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float force;
    Rigidbody2D rb;

    public GameObject RestartButton;
    public GameObject panel;
    public GameObject efects;
    public SpriteRenderer sprite;
    private Animator camAnim;
   


    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            camAnim.SetTrigger("Shake");
            rb.velocity = Vector2.up * force;
            Instantiate(efects, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Pipes")
        {
            camAnim.SetTrigger("Shake");
            Time.timeScale = 0;
            Destroy(sprite);
            panel.SetActive(true);
            RestartButton.SetActive(true);
        }
    }
}
