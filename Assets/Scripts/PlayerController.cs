using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    [Tooltip("Fuerza del salto")] [Range(0, 50)] public float jumpForce = 5.0f;
    [Tooltip("Control de gravedad")] [Range(0, 50)] public float gravityModifier = 5;
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        //obtener el rigidbody 
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
       
    }

  

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
