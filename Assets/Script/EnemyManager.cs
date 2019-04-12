using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject note;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.57142f)
        {
            int num = Random.Range(0, 2);
            switch (num)
            {
                case 0:
                    Instantiate(note, transform.position, Quaternion.identity);
                    break;
                case 1:
                    break;
            }
            timer = 0;
        }
    }
}
