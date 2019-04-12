using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveControl : MonoBehaviour
{
    float speed = 10;
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
        if(transform.position.x<-13)
        {
            Destroy(gameObject);
        }
    }
}
