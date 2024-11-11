using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ColorPicker
{
    public class GridCell : MonoBehaviour
    {
        [SerializeField] SpriteRenderer spriteRenderer;
        ColorPalette colorPalette;


        void Start()
        {
            colorPalette = FindObjectOfType<ColorPalette>();
        }

        void OnMouseOver()
        {
            if (Mouse.current.leftButton.isPressed)
            {
                PaintCell();
            }
        }

        void PaintCell()
        {
            spriteRenderer.color = colorPalette.SelectedColor;
        }
    }
}
