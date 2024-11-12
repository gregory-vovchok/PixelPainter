using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ColorPicker
{
    public class GridCellPainter : MonoBehaviour
    {
        [SerializeField] ColorPaletteToolbar colorPalette;

        private void Update()
        {
            if (Mouse.current.leftButton.isPressed)
            {
                PaintCellUnderCursor();
            }
        }

        private void PaintCellUnderCursor()
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(cursorPosition, Vector2.zero);

            if (hit.collider != null)
            {
                GridCell cell = hit.collider.GetComponent<GridCell>();
               
                if (cell != null)
                {
                    cell.ChangeColor(colorPalette.SelectedColor, colorPalette.HistoryManager);
                }
            }
        }
    }
}