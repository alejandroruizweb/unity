using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    public float speedMovement = 5; //Variable con decimales. Al ser pública se verá en el inspector.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Movement();  
    }
    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.position += Vector3.forward * z * speedMovement * Time.deltaTime;
        transform.position += Vector3.right * x * speedMovement * Time.deltaTime;
    }
}
