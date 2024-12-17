using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryBounce : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PhaseBall ball = collision.gameObject.GetComponent<PhaseBall>();

        if (ball != null)
        {
            Vector3 blockposition = transform.position;
            Vector2 contractpoint = collision.GetContact(0).point;

            float offset = blockposition.x - contractpoint.x;
            float width = collision.otherCollider.bounds.size.x / 2;

            float curangle = Vector2.SignedAngle(Vector2.up, ball.rb.velocity);

            float bounceangle = (offset / width) * 75f;

            float newAngle = Mathf.Clamp(curangle + bounceangle, -75f, 75f);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            ball.rb.velocity = rotation * Vector2.up * ball.rb.velocity.magnitude;

        }
    }
}
