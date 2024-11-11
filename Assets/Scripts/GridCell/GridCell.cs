using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace ColorPicker
{
    public partial class GridCell : MonoBehaviour
    {
        [SerializeField] SpriteRenderer spriteRenderer;


        public void PaintCell(Color color)
        {
            Debug.Log($"Cell ({gameObject.GetInstanceID()}) color changed: {color.GetHashCode()}");

            spriteRenderer.color = color;
        }
    }
}
