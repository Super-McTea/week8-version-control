using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis(InputAxes.PlayerTwoHorizontal);
        float dz = Input.GetAxis(InputAxes.PlayerTwoVertical);

        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(movementSpeed * Vector3.forward * dz * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(movementSpeed * Vector3.right * dx * Time.deltaTime);
        }
    }
}
