using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.iOS;


public class PlayerController : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string playername;
    private Vector2 moveinput;
    public float movespeed = 8f;
    public float jumpforce = 7f;
    private Rigidbody2D rb;
    private Animator myanimator;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
        myanimator.SetBool("move", false);
    }
    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
    }
    public void OnJump(InputValue value)
    {
       if(value.isPressed) // 점프 버튼을 누르면
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }
    // Update is called once per frame
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //   if (collision.name == "door") 
    //        Destroy(collision.gameObject); 
    //}
    void Update()
    {
        
        if(moveinput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if(moveinput.x < 0) 
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.Translate(Vector3.right * movespeed * moveinput.x * Time.deltaTime);

        if(moveinput.magnitude > 0)
        {
            myanimator.SetBool("move",true);
        }
        else
        {
            myanimator.SetBool("move", false);
        }
        transform.Translate(Vector3.right * movespeed * moveinput.x * Time.deltaTime);
    }
}
