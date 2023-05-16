using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier

    Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //rb equals the rigidbody on the player
    }


    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1
        //float YMove = Input.GetKeyDown(KeyCode.Space); // w key changes value to 1, s key changes value to -1
        if(Input.GetKeyDown("space")){
            rb.velocity = new Vector3(-xMove * 2, 6, -zMove * 2) * speed;
        }
        else
        {
            rb.velocity = new Vector3(-xMove * 2, rb.velocity.y, -zMove * 2) * speed;
        }
         // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 
    }
}