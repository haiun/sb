using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root3D : MonoBehaviour
{
    public static Transform Instance { get; private set; }

    private void Awake()
    {
        Initialize();
    }

    public void Initialize()
    {
        Instance = transform;
    }
}
