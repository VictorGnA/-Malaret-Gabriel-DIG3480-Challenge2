using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("State", 1);
        }

        if (Input.GetKeyUp("KeyCode.D"))
        {
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetInteger("State", 2);
        }

        if (Input.GetKeyUp("KeyCode.F"))
        {
            anim.SetInteger("State", 0);
        }
    }




}
