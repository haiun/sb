using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClickController<Data, Controller> : MonoBehaviour
    where Data : class
    where Controller : ClickController<Data, Controller>
{
    protected Data data = null;
    protected Action<Data, Controller> onClick = null;

    public void SetData(Data data, Action<Data, Controller> onClick = null)
    {
        this.data = data;
        this.onClick = onClick;
        OnSetData();
    }

    public void UpdateData(Data data)
    {
        this.data = data;
        OnSetData();
    }

    public void SetClickAction(Action<Data, Controller> onClick)
    {
        this.onClick = onClick;
    }
    
    public void InvalidData()
    {
        OnSetData();
    }

    public void OnClick()
    {
        Debug.Log(gameObject.name);

        if (onClick != null) onClick(data, (Controller)this);
    }

    protected abstract void OnSetData();
}