using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    //public float upForce = 200f;
    //public float downForce = 200f;
    //public float rightForce = 200f;
    //public float leftForce = 200f;
    public float speed = 4f;
    private Rigidbody2D rb2d;
    private Animator animator;
    public static bool isSwampItemTaken = false;
    public static bool isPondItemTaken = false;
    public static bool isMiddleObjectItem1Taken = false;
    public static bool isMiddleObjectItem2Taken = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    //void Update()
    //{
    //    move = rb2d.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime));
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.position += move * speed * Time.deltaTime;
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.position += move * speed * Time.deltaTime;
    //    }
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.position += move * speed * Time.deltaTime;
    //    }
    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        transform.position += move * speed * Time.deltaTime;
    //    }
    //}
    void Update()
    {
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += transform.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (isSwampItemTaken == true)
        {
            Destroy(EnterSwampCollisioner.EnterSwampCollisionerItem);
        }
        if (isPondItemTaken == true)
        {
            Destroy(EnterPondCollisioner.EnterPondCollisionerItem);
        }
        if (isMiddleObjectItem1Taken == true) {
            Destroy(EnterMiddleObject1Collisioner.EnterMiddleObject1CollisionerItem);
        }
        if (isMiddleObjectItem2Taken == true)
        {
            Destroy(EnterMiddleObject2Collisioner.EnterMiddleObject2CollisionerItem);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gem") {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Teleport") {
            transform.position = new Vector2(-54, -58);
        }
        if (collision.gameObject.tag == "TeleportBack")
        {
            transform.position = new Vector2(-139, 29);
        }
        if (collision.gameObject.tag == "ItemSwamp")
        {
            Destroy(collision.gameObject);
            isSwampItemTaken = true;
        }
        if (collision.gameObject.tag == "ItemPond")
        {
            Destroy(collision.gameObject);
            isPondItemTaken = true;
        }
        if (collision.gameObject.tag == "Middle1")
        {
            Destroy(collision.gameObject);
            isMiddleObjectItem1Taken = true;
        }
        if (collision.gameObject.tag == "Middle2")
        {
            Destroy(collision.gameObject);
            isMiddleObjectItem2Taken = true;
        }
    }
//    public void DestroyBagno()
//    {
//        if (isSwampItemTaken == true)
//        {
//            Destroy(EnterSwampCollisioner.EnterSwampCollisionerItem);
//        }
//}
        //private void Update()
        //{
        //    Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //    rb2d.MovePosition(rb2d.position + moveDirection * speed * Time.deltaTime);
        //}

    }
