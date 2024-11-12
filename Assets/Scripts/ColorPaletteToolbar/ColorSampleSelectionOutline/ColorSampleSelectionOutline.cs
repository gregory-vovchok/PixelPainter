using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public partial class ColorSampleSelectionOutline : MonoBehaviour
    {
        [SerializeField] Image image;
        [SerializeField] Color color;

        #region temp
        Tween blinkTween;
        #endregion


        void Start()
        {
            SetColor(color);
        }

        public void SetParent(ColorSample colorSample)
        {
            transform.SetParent(colorSample.transform, false);
            transform.localPosition = Vector3.zero;
        }

        public void SetColor(Color color)
        {
            image.color = color;
        }

        public void SetSize(int width, int height)
        {
            if (image != null)
            {
                RectTransform rectTransform = image.GetComponent<RectTransform>();

                rectTransform.sizeDelta = new Vector2(width, height);
            }
            else
            {
                Debug.LogError("Image component is missing.");
            }
        }
    }
}