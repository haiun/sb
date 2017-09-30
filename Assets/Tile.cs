using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[PrefabPath("Resources/Tile")]
public class Tile : ClickController<Tile.Data, Tile>
{
    public class Data
    {
        public Vector3 Position { get; set; }
        public List<ITrigger> TriggerList = new List<ITrigger>();
    }

    protected override void OnSetData()
    {
        transform.position = data.Position;
    }
}
