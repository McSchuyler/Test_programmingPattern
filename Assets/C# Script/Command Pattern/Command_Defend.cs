using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="DefendCommand",menuName ="Command/Defend")]
public class Command_Defend : Command
{
    public override void Execute()
    {
        Debug.Log("Defend");
    }
}
