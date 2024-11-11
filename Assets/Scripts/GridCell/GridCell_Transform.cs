using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace ColorPicker
{
    public partial class GridCell
    {
        public Vector2 GetSize()
        {
            var rectTransform = GetComponent<RectTransform>();

            return new Vector2(
                rectTransform.rect.width,
                rectTransform.rect.height);
        }

        public void SetPosition(Vector2 pos)
        {
            transform.localPosition = new Vector3(
                pos.x,
                pos.y,
                transform.localPosition.z);
        }

        public Vector3 GetPosition()
        {
            return transform.localPosition;
        }

        public void SetScale(float scale)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }

        public float GetScale()
        {
            return transform.localScale.x;
        }

        public void SetRotation(float angle)
        {
            transform.localRotation = Quaternion.Euler(0, 0, angle);
        }

        public Quaternion GetRotation()
        {
            return transform.localRotation;
        }
    }
}
