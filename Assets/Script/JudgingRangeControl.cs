using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgingRangeControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Enemy")
        {
            float dis = Mathf.Abs(transform.position.x - col.transform.position.x);
            Debug.Log(dis);
            Destroy(col.gameObject);
        }
    }
}
