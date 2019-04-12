using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Animator ainm;
    public void Attack_Down()
    {
        ainm.SetBool("Attack",true);
    }
    public void Attack_Up()
    {
        ainm.SetBool("Attack", false);
    }
}
