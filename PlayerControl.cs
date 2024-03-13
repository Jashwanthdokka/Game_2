using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRB;
    private Animator myAnim;

    [SerializeField] private AudioSource Move;

    [SerializeField]
    private float speed;

    

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveVelocity = moveInput.normalized * speed;

        myRB.velocity = moveVelocity * Time.deltaTime;

        myAnim.SetFloat("moveX", moveVelocity.x);
        Move.Play();
        myAnim.SetFloat("moveY", moveVelocity.y);
        
    }
}
