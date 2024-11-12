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

        public Color Color { get; private set; }


        void Start()
        {
            Color = spriteRenderer.color;
        }

        public void ChangeColor(Color newColor, GridHistoryManager historyManager)
        {
            Color previousColor = Color;

            if (previousColor == newColor)
            {
                return;
            }

            GridAction action = new GridAction(
                doAction: () => SetColor(newColor, isAnimated: true),
                undoAction: () => SetColor(previousColor, isAnimated: false));

            historyManager.AddAction(action);

            action.Execute();
        }

        void SetColor(Color newColor, bool isAnimated = false)
        {
            Debug.Log($"Cell ({gameObject.GetInstanceID()}) color changed: {newColor.GetHashCode()}");

            if (isAnimated)
            {
                Color = newColor;
                colorAnimator.SetColor(newColor, gridSettings.CellColorTransitionDuration);
            }
            else
            {
                SetColorInstantly(newColor);
            }
        }

        void SetColorInstantly(Color newColor)
        {
            Color = newColor;
            spriteRenderer.color = newColor;
        }
    }
}
