using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public static GameCamera Instance { get; private set; }

    private void Awake()
    {
        Initialize();
    }

    public void Initialize()
    {
        Instance = this;
    }

    public Camera GetCamera()
    {
        return GetComponent<Camera>();
    }

    public UICamera GetUICamera()
    {
        return GetComponent<UICamera>();
    }
}
