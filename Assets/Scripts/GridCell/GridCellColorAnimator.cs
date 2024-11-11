using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public class GridCellColorAnimator : MonoBehaviour
    {
        [SerializeField] GridCell gridCell;
        Tween colorTween;


        public void SetColor(Color targetColor, float duration)
        {
            if (colorTween != null && colorTween.IsActive())
            {
                colorTween.Kill();
                colorTween = null;
            }

            colorTween = gridCell.Sprite.DOColor(targetColor, duration);
        }

    }
}