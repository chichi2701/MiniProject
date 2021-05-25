using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D re;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            re.velocity = new Vector2(5, 0);
            transform.localScale = new Vector2(1,1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            re.velocity = new Vector2(-5, 0);
            transform.localScale = new Vector2(-1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            re.velocity = new Vector2(re.velocity.x, 10f);
            
        }
    }
}
