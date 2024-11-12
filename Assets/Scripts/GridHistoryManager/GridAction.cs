using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public class GridAction
    {
        readonly Action doAction;
        readonly Action undoAction;

        public GridAction(Action doAction, Action undoAction)
        {
            this.doAction = doAction;
            this.undoAction = undoAction;
        }

        public void Execute()
        {
            doAction?.Invoke();
        }

        public void Undo()
        {
            undoAction?.Invoke();
        }
    }
}
