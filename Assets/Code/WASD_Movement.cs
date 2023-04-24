using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Movement : MonoBehaviour
{
    public float speed = 0.25f;  //defines the players speed

    public KeyCode upKey = KeyCode.W;  //variable to move up
    public KeyCode downKey = KeyCode.S;  //variable to move down
    public KeyCode leftKey = KeyCode.A;  //variable to move left
    public KeyCode rightKey = KeyCode.D;  //variable to move right

    float border = 5f;    //variable for vertical border
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        if (Input.GetKeyDown(upKey)){ //if the up key is pressed
            newPosition.y += speed; //move newPosition up
        }
        if (Input.GetKeyDown(downKey))//if the down key is pressed
        {
            newPosition.y -= speed;//move newPosition down
        }
        if (Input.GetKeyDown(rightKey))  //if the right key is pressed
        {
            newPosition.x += speed;  //move newPosition right
        }
        if (Input.GetKeyDown(leftKey)) //if the left key is pressed
        {
            newPosition.x -= speed;  //move newPosition left
        }
       

        if(newPosition.y > border)
        {
            newPosition.y = -border;
            Score.scoreValue++;
        }
        else if(newPosition.y < -border)
        {
            newPosition.y = -border;
        }

        transform.position = newPosition;
    }
}
