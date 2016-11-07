using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bounce: MonoBehaviour
{

    public Vector3 directions;
    public Rigidbody ball;
    public float force = -190;
    public float force2 = 190;
    private object mathf;
    private float y;

    public void OnCollisionEnter(Collision collision)
    {
        directions = collision.contacts[0].point;
        ball.AddForce(directions * force);
        directions = collision.contacts[0].point;
        ball.AddForce(directions * force2);


        if (gameObject.tag == "bumper")
        {
            score_update.score += 69;
        }
        {
           // mathf.random(0, 180) directions.x = y;
        }

    }
}

