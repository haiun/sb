using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[PrefabPath("Tile")]
public class Tile : ClickController<Tile.Data, Tile>
{
    public class Data
    {
        public int X;
        public int Y;
        public Vector3 Position { get; set; }
        public List<ITrigger> TriggerList = new List<ITrigger>();
    }

    protected override void OnSetData()
    {
        transform.localPosition = data.Position;
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }

    public static Tile CreateInstance(int x, int y, Transform parent)
    {
        var tile = PrefabGen<Tile>.Gen();
        tile.name = string.Format("Tile {0}x{1}", x, y);
        tile.transform.parent = parent;
        tile.SetData(new Tile.Data() { X = x, Y = y, Position = new Vector3(x * 10, 0, y * 10) });
        return tile;
    }
}
