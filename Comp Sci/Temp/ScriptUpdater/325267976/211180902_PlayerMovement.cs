// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     public float speed = 10f; //Controls velocity multiplier

//     Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script
//     public float mult = 4;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rb = GetComponent<Rigidbody>(); //rb equals the rigidbody on the player
//     }


//     // Update is called once per frame
//     void Update()
//     {
//         //Quaterion
//         float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
//         float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1
//         //float ySpin = +=Input.GetAxisRaw("Horizontal2");
        
        

//         if(Input.GetKeyDown(KeyCode.Space)){
//             rb.velocity = new Vector3(-xMove * mult, 6, -zMove * mult) * speed + GameObject.FindWithTag("Player").transform.rotation;
//         }
//         else
//         {
//             rb.velocity = new Vector3(-xMove * mult, rb.velocity.y, -zMove * mult) * speed + GameObject.FindWithTag("Player").transform.rotation;
//         }

//         //rb.rotation = Quaternion.Euler (0, ySpin, 0) * speed;
//          // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 
//     }
// }
 using UnityEngine;
 using System.Collections;
 
 [RequireComponent (typeof(Rigidbody))]
 public class PlayerMovement : MonoBehaviour {
 
     public float movementSpeed = 5.0f;
     public float clockwise = 1000.0f;
     public float counterClockwise = -5.0f;
 
     void Start () {
         
     }
     
     void Update () {
         if(Input.GetKey(KeyCode.W)) {
             transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.S)) {
             GetComponent<Rigidbody>().position += Vector3.back * Time.deltaTime * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.A)) {
             GetComponent<Rigidbody>().position += Vector3.left * Time.deltaTime * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.D)) {
             GetComponent<Rigidbody>().position += Vector3.right * Time.deltaTime * movementSpeed;
         }
 
         if(Input.GetKey(KeyCode.E)) {
             transform.Rotate(0, Time.deltaTime * clockwise, 0);
         }
         else if(Input.GetKey(KeyCode.Q)) {
             transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
         }
     }
 }