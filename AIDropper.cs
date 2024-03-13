using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDropper : MonoBehaviour
{
    public float threshold = 1.0f;

    AIHelper.State state = AIHelper.State.IDEL;
    GameObject player;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == AIHelper.State.IDEL)
        {
            float distance = Mathf.Abs(transform.position.x - player.transform.position.x);
            if (distance <= threshold)
            {
                state = AIHelper.State.ATTACKING;
                rb.gravityScale = 1.0f;
                Destroy(this.gameObject, 5);
            }
        }
    }
}
