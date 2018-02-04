using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="AttackCommand",menuName ="Command/Attack")]
public class Command_Attack : Command {

    public override void Execute()
    {
        Debug.Log("Attack");
    }
}