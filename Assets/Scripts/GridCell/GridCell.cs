using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace ColorPicker
{
    public partial class GridCell : MonoBehaviour
    {
        [SerializeField] GridSettingsData gridSettings;
        [SerializeField] SpriteRenderer spriteRenderer;
        [SerializeField] GridCellColorAnimator colorAnimator;

        public SpriteRenderer Sprite { get => spriteRenderer; }


        public void PaintCell(Color color)
        {
            Debug.Log($"Cell ({gameObject.GetInstanceID()}) color changed: {color.GetHashCode()}");

            SetColor(color, isAnimated: true);
        }

        public void SetColor(Color color, bool isAnimated = false)
        {
            if (isAnimated)
            {
                colorAnimator.SetColor(color, gridSettings.CellColorTransitionDuration);
            }
            else
            {
                spriteRenderer.color = color;
            }
        }
    }
}
