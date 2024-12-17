using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseBall : MonoBehaviour
{

    //public bool _ballStart = false;

    public float spd = 500;

    public Rigidbody2D rb;
    public bool _startgame = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    public void ResetBall()
    {
        if (_startgame == true)
        {
            transform.position = Vector2.zero;
            rb.velocity = Vector2.zero;
            Invoke(nameof(SetRandomBall), 1f);
        }
    }

    public void SetRandomBall()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        rb.AddForce(force * spd);
    }

    public void StartGame()
    {
        _startgame = true;
    }

}
