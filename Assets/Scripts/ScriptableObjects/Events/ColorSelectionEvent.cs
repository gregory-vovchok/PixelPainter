using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorSelectionEvent", menuName = "Assets/Events/ColorSelectionEvent")]
public class ColorSelectionEvent : ScriptableObject
{
    public event Action<Color> OnColorSelected;


    public void RaiseEvent(Color color)
    {
        OnColorSelected?.Invoke(color);
    }
}
