using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Animator anim;
    bool m_FacingRight = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, GetComponent<Rigidbody2D>().velocity.y);
        anim.SetBool("Walk", false);
        anim.SetBool("Crouch", false);
        if (Input.GetKey(KeyCode.A))
        {
            if (m_FacingRight == false) Flip();
            anim.SetBool("Walk", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 0f);
        } 

        if (Input.GetKey(KeyCode.S))
        {         
            anim.SetBool("Crouch", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (m_FacingRight == true) Flip();
         
            anim.SetBool("Walk", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 0f);
        }

        

    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
       m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
       
    }

}





