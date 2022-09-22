using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    

    public Rigidbody2D playerRigidBody;

    public float moveHori = 0f;
    public float moveSpeed = 20f;

    public float moveVert;
    public float vertSpeed = 20f;

    
    /*public static bool onGround; 
    public Transform groundPoint;
    public float groundRange = 0.3f;
    public LayerMask groundLayer;*/

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //onGround = Physics2D.OverlapCircle(groundPoint.position, groundRange, groundLayer);

        //float forceJump = Mathf.Sqrt(jumpHeight * (-2) * (Physics2D.gravity.y * playerRigidBody.gravityScale));

        //playerAnimator.SetBool("onGround", onGround);

        //if (onGround && Input.GetKeyDown(KeyCode.Space) /*Input.GetAxisRaw("Vertical")>=0.5f*/ /*vertMovement >= 0.5f && playerCombat.numPresses < 1*/)
        //{
            //playerRigidBody.velocity = new Vector2(0, 0);//new code --> i think this works for jumping with up on joystick, prevents from impulse force being built up
            //playerRigidBody.AddForce(new Vector2(0, forceJump), ForceMode2D.Impulse);
            //Debug.Log("jumped");
            //playerAnimator.SetBool("onGround", onGround);
        //}

        //if (moveHori > 0)
        //{
        //    gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        //    //facingRight = true;
        //}
        //else if (moveHori < 0)
        //{
        //    gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 1f);
        //    //facingRight = false;
        //}

    }

    private void FixedUpdate()
    {
        moveHori = Input.GetAxisRaw("Horizontal");                                                   //movement using horizontal axis and rigidbody of gameobject
        playerRigidBody.velocity = new Vector2(moveHori * moveSpeed, playerRigidBody.velocity.y);

        moveVert = Input.GetAxisRaw("Vertical");
        playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, moveVert * vertSpeed);
    }


    //private void OnDrawGizmosSelected()
    //{
    //    if (groundPoint == null)               //used to ensure no error is thrown when nothing is within the groundPoint range
    //    {
    //        return;
    //    }

    //    Gizmos.DrawWireSphere(groundPoint.position, groundRange); //visually display the overlapcircle in unity game scene
    //}
}
