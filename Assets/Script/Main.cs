using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Main : MonoBehaviour
{
    [SerializeField]
    public Field field = null;

    void Start()
    {
        field.Initialize();
    }
}
