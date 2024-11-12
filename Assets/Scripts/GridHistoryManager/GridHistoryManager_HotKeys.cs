using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public partial class GridHistoryManager
    {
        GameInput controls;

        void Awake()
        {
            controls = new GameInput();

            controls.UI.Undo.performed += _ => Undo();
            controls.UI.Redo.performed += _ => Redo();
        }
    }
}
