using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Animator ainm;

    public void Attack()
    {
        ainm.SetTrigger("Attack");
    }
}
