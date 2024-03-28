using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

        if(movement.magnitude > 0)
        {
            GetComponent<Animator>().SetInteger("AnimState", 1);
        }
        else { GetComponent<Animator>().SetInteger("AnimState", 0); }

        if (inputX < 0)
        { GetComponent<SpriteRenderer>().flipX = true; }
        else
        { GetComponent<SpriteRenderer>().flipX = false; }
    }
}

