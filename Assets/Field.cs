using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field
{
    public List<Tile> TileList = new List<Tile>();
    
    public void Initialize()
    {
        int w = 5;
        int h = 5;

        TileList = GenerateTile(w, h);
    }

    public List<Tile> GenerateTile(int w, int h)
    {
        var fieldRoot = new GameObject();
        fieldRoot.transform.SetParent(Root3D.Instance);
        fieldRoot.transform.localPosition = new Vector3(w * -5, 0, h * -5);
        fieldRoot.transform.localRotation = Quaternion.identity;
        fieldRoot.transform.localScale = Vector3.one;

        var ret = new List<Tile>();

        for (int y = 0; y < h; ++y)
        {
            for (int x = 0; x < w; ++x)
            {
                ret.Add(Tile.CreateInstance(x, y, fieldRoot.transform));
            }
        }

        return ret;
    }
}
