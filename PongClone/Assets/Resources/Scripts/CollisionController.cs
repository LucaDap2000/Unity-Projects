using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacquet(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racquetPosition = c.gameObject.transform.position;

        float racquetHeight = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "RacquetPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racquetPosition.y) / racquetHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacquetPlayer1" ||  collision.gameObject.name == "RacquetPlayer2")
        {
            this.BounceFromRacquet(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with WallLeft");
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with WallRight");
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
    }
}
