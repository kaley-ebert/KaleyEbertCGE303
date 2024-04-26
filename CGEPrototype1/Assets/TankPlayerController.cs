using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayerController : MonoBehaviour
{
    //try setting this to 8 in the inspector
    public float speed;

    //try setting this to 100 in the inspector
    public float turnSpeed;

    public float horizontalInput;
    public float verticalInput;


    //Update is called once per frame
    void Update()
    {
        //Move forward
        //transform.Translate (1, 0);

        //Which is the same as...
        //transform.Translate(Vector2.right * Time.deltaTime * speed);

        //Get Input - Do this in Update()
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move player side-to-side with horizontal Input
        //transform.Translate(Vector2.right * turnSpeed * Time.deltaTime * horizontalInput);

        //Move player forward with vertical Input
        //transform.Translate(Vector2.right * Time.deltaTime * speed * verticalInput);

        //Rotate player with horizontal Input
        //transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime * horizontalInput);
        if (verticalInput < 0)
        {
            transform.Rotate(Vector3.back, -turnSpeed * Time.deltaTime * horizontalInput);
        }
        else
        {
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }
}
