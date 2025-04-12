using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;
    CharacterController characterControll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterControll = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMovements = (Input.GetAxis("Horizontal"));

        float Speed = 5;
        float ForwardBackMovements = (0.0f);


      //  Debug.Log(Input.GetAxis("Horizontal"));
        if (Input.GetAxis("Horizontal") > 0) { Debug.Log("right"); }
        else if (Input.GetAxis("Horizontal") < 0) { Debug.Log("left"); }


        if (Input.GetKey(KeyCode.W))
        { 
            Debug.Log("Up");
            ForwardBackMovements += 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        { 
            Debug.Log("Down"); 
            ForwardBackMovements-=1.0f;
        }

        characterController.Move((new Vector3(HorizontalMovements, 0.0f, ForwardBackMovements)).normalized * Speed * Time.deltaTime);

       //transform.position = transform.position + (new Vector3(HorizontalMovements, 0.0f, ForwardBackMovements)).normalized * Speed * Time.deltaTime;

        /* if (true)
         { Debug.Log("gods willing"); }
         if (false)
         { Debug.Log("gods willing kill"); } */
    }
}
