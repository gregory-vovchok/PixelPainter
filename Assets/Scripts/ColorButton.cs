using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorPicker
{
    public class ColorButton : MonoBehaviour
    {
        [SerializeField] Button button;
        [SerializeField] Image image;
        public Color Color { get => image.color; set => image.color = value; }

        #region temp
        ColorSelectionEvent colorSelectionEvent;
        #endregion


        void Awake()
        {
            button.onClick.AddListener(OnButtonClicked);
        }

        public void Initialize(Color color, ColorSelectionEvent colorSelectionEvent)
        {
            Color = color;
            this.colorSelectionEvent = colorSelectionEvent;
        }

        void OnButtonClicked()
        {
            Debug.Log($"OnButtonClicked: {Color.GetHashCode()}");
            colorSelectionEvent?.RaiseEvent(Color);
        }
    }
}