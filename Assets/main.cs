using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Main : MonoBehaviour
{
    Field field = new Field();

    void Start()
    {
        
        field.Initialize();
    }
}
