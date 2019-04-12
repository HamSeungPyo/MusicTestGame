using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgingRangeControl : MonoBehaviour
{
    public ScoreManager script_ScoreManager;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Note")
        {
            col.GetComponent<EnemyMoveControl>().enabled = false;
            float dis = Mathf.Abs(transform.position.x - col.transform.position.x);
            float score = 0;
            if (dis <= 0.3)
            {
                score = 100;
            }
            else if (dis > 0.3 && dis <= 0.5)
            {
                score = 60;
            }
            else
            {
                score = 30;
            }
            script_ScoreManager.CumulativeScore(score);
            Debug.Log(dis);
            col.gameObject.AddComponent<Rigidbody2D>().velocity = new Vector2(5, 10);
            col.gameObject.GetComponent<Rigidbody2D>().angularVelocity = -150;
            Destroy(col.gameObject,3);
        }
    }
}
