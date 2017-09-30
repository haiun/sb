using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[PrefabPath("Resources/Pawn")]
public class Pawn : ClickController<Pawn.Data, Pawn>
{
    public class Data
    {
        int x;
        int y;
    }
    
    protected override void OnSetData()
    {
        
    }
}
