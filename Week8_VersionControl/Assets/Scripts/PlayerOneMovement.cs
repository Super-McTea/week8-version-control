using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis(InputAxes.PlayerOneHorizontal);
        float dz = Input.GetAxis(InputAxes.PlayerOneHorizontal);

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed * Vector3.forward * dz * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed * Vector3.right * dx * Time.deltaTime);
        }
    }
}
