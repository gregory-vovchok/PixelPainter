using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public class GridHistoryManager : MonoBehaviour
    {
        Stack<GridAction> undoStack = new Stack<GridAction>();
        public bool IsUndoStackEmpty { get => undoStack.Count == 0; }

        Stack<GridAction> redoStack = new Stack<GridAction>();
        public bool IsRedoStackEmpty { get => redoStack.Count == 0; }
       
        [SerializeField] SimpleButton undoButton;
        [SerializeField] SimpleButton redoButton;


        void Start()
        {
            UpdateControlButtons();
        }

        void OnEnable()
        {
            redoButton.OnClick += OnRedoButtonClicked;
            undoButton.OnClick += OnUndoButtonClicked;
        }

        void OnDisable()
        {
            redoButton.OnClick -= OnRedoButtonClicked;
            undoButton.OnClick -= OnUndoButtonClicked;
        }

        public void AddAction(GridAction action)
        {
            undoStack.Push(action);
            redoStack.Clear();

            UpdateControlButtons();
        }

        public void UpdateControlButtons()
        {
            if (IsUndoStackEmpty) undoButton.Interactable = false;
            else undoButton.Interactable = true;

            if (IsRedoStackEmpty) redoButton.Interactable = false;
            else redoButton.Interactable = true;
        }

        public void OnRedoButtonClicked()
        {
            Redo();
        }

        public void OnUndoButtonClicked()
        {
            Undo();
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                Debug.Log("Undo");
                GridAction action = undoStack.Pop();
                action.Undo();

                redoStack.Push(action);

                UpdateControlButtons();
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                Debug.Log("Redo");

                GridAction action = redoStack.Pop();
                action.Execute();

                undoStack.Push(action);

                UpdateControlButtons();
            }
        }
    }
}
