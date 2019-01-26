using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform ukkeli;
    Vector2 oldlocalscale;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        ukkeli = transform.GetChild(0);
        oldlocalscale = ukkeli.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        if(transform.position.x > -10 || direction > 0) {
            transform.Translate(Vector2.right * direction * Time.deltaTime * speed);
        }
        

        // TODO Käännä ukkeli

        //ukkeli.localScale = localscale;
        if(direction != 0) {
            if(direction < 0)
                ukkeli.localScale = new Vector2(-oldlocalscale.x, oldlocalscale.y);
            else
                ukkeli.localScale = oldlocalscale;
        }
    }
}
