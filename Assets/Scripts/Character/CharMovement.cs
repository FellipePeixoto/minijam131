using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 200;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LayerMask layerMask = LayerMask.GetMask("Ground");
        //bool onGround = Physics.Raycast(new Ray(transform.position, transform.up * -1), 0.2f);
        bool onGround = Physics.Raycast(new Ray(transform.position, transform.up * -1), 0.2f, layerMask);

        Vector3 movePosition = transform.position;

        if (Input.GetButton("Forward") && onGround)
        {
            movePosition += Vector3.forward * speed * Time.fixedDeltaTime;
            rb.MovePosition(movePosition);
        }

        if (Input.GetButton("Back") && onGround)
        {
            movePosition += Vector3.back * speed * Time.fixedDeltaTime;
            rb.MovePosition(movePosition);
        }

        if (Input.GetButtonDown("Jump"))
        {

        }
    }
}
