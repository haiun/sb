using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScrollPanel : MonoBehaviour
{
    public UIRoot UIRoot3D = null;
    public Camera GameCamera = null;

    private UIPanel panel = null;

    private void Awake()
    {
        panel = GetComponent<UIPanel>();
    }

    private void Start ()
    {
        var clipRegion = panel.baseClipRegion;

        //UIRoot3D.manualWidth
        //UIRoot3D.manualHeight

        //camera.orthographicSize;
    }
	
}
