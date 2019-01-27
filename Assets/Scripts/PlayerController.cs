using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform ukkeli;
    Animator animator;
    Vector2 oldlocalscale;
    public float speed = 10.0f;

    public PlayerStatsScript playerStats;


    // Start is called before the first frame update
    void Start()
    {
        ukkeli = transform.GetChild(0);
        oldlocalscale = ukkeli.localScale;
        animator = ukkeli.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        float currentSpeed = speed - playerStats.cold * (speed / 100);
        Debug.Log(currentSpeed);

        if(direction == 0) {
            animator.Play("Idle");
        }
        else {
            animator.Play("Walking");
        }

        if(transform.position.x > -10 || direction > 0) {
            transform.Translate(Vector2.right * direction * Time.deltaTime * currentSpeed);
        }

        
        
        if(direction != 0) {
            if(direction < 0)
                ukkeli.localScale = new Vector2(-oldlocalscale.x, oldlocalscale.y);
            else
                ukkeli.localScale = oldlocalscale;
        }
    }
}
