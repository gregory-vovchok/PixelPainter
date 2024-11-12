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
        public void StartBlinking(float duration)
        {
            if (blinkTween != null && blinkTween.IsActive())
            {
                blinkTween.Kill();
                blinkTween = null;
            }

            Color initialColor = image.color;
            initialColor.a = 1f;
            image.color = initialColor;

            blinkTween = image.DOFade(0f, duration / 2)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.InOutSine);
        }

        public void StopBlinking()
        {
            if (blinkTween != null && blinkTween.IsActive())
            {
                blinkTween.Kill();
                blinkTween = null;
            }

            Color color = image.color;
            color.a = 1f;
            image.color = color;
        }
    }
}
