using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField]
    private Material tileMaterial = null;

    private List<Tile> tileList = null;
    
    public void Initialize()
    {
        int w = 5;
        int h = 5;

        tileList = GenerateTile(w, h);
    }

    public List<Tile> GenerateTile(int w, int h)
    {
        var fieldRoot = new GameObject();
        fieldRoot.transform.SetParent(Root3D.Instance);
        fieldRoot.transform.localPosition = Vector3.zero; // new Vector3(w * -5, 0, h * -5);
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

        var meshFilterList = fieldRoot.GetComponentsInChildren<MeshFilter>();
        var combineList = new CombineInstance[meshFilterList.Length];
        for (int i = 0; i < meshFilterList.Length; ++i)
        {
            var meshFilter = meshFilterList[i];
            combineList[i].mesh = meshFilter.sharedMesh;
            combineList[i].transform = transform.worldToLocalMatrix * meshFilter.transform.localToWorldMatrix;
        
            var meshRenderer = meshFilter.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                meshRenderer.enabled = false;
            }
        }
        
        var fieldMeshFilter = fieldRoot.AddComponent<MeshFilter>();
        fieldMeshFilter.mesh = new Mesh();
        fieldMeshFilter.mesh.CombineMeshes(combineList);

        var fieldMeshRenderer = fieldRoot.AddComponent<MeshRenderer>();
        fieldMeshRenderer.material = tileMaterial;

        return ret;
    }
}
