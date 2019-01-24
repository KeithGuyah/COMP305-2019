using UnityEngine;

public class Controller : MonoBehaviour
{
    //public variabels
    public float speed=10.0f;
    public float jumpForce=500.0f;
    //private Variables
    private Rigidbody2D rBODY;
    //reserved function. only runs when the object is created.
    //used for initalization.
    void start()
    {
        //will only get once when the object is created. more effiecient.
        rBODY=GetComponent<Rigidbody2D>();
    }
//used fixedupdate for phsyics based movment only.
    void FixedUpdate()
    {
        float horiz= Input.GetAxis("Horizontal");

        rBODY.velocity=new Vector2(horiz*speed, rBODY.velocity.y);
        //float vert= Input.GetAxis("Vertical");
       
        
        //GetComponent<RigidBody2D>().velocity= new Vector2(horiz,);
    }
    void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//listens to my space bar key being pressed.
        {
            rBODY.AddForce(new Vector2(0,jumpForce));
        }
    }
}

