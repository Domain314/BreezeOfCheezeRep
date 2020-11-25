using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MatchInput : Singleton<MatchInput>
{
    public GameObject NeededInputGO;
    public TextMeshProUGUI NeededInput;

    public string text;
    public int textPosition = 0;
    public bool isInUse = false;

    public Action onTextTypedCorrectly;
    public Action onTextTypedIncorrectly;

    protected void OnEnable()
    {
        Keyboard.current.onTextInput += OnTextInput;
        EventManager.Instance.GameStart += SetupNewGame;
        EventManager.Instance.TargetWarningEnd += TargetEnd;
    }
    protected void OnDisable()
    {
        Keyboard.current.onTextInput -= OnTextInput;
        EventManager.Instance.GameStart -= SetupNewGame;
        EventManager.Instance.TargetWarningEnd -= TargetEnd;
    }

    void SetupNewGame()
    {
        NeededInputGO = GameObject.FindGameObjectWithTag("NeededInput");
        NeededInput = NeededInputGO.GetComponentInChildren<TextMeshProUGUI>();
        NeededInputGO.SetActive(false);
    }

    private void OnTextInput(char _ch)
    {
        if (text == null || textPosition >= text.Length)
            return;

        char ch = char.ToLower(_ch);
        if (text[textPosition] == ch)
        {
            ++textPosition;
            if (textPosition == text.Length)
            {
                textPosition = 0;
                NeededInputGO.SetActive(false);
                onTextTypedCorrectly?.Invoke();
            }
        }
        else
        {
            textPosition = 0;
            onTextTypedIncorrectly?.Invoke();
        }
    }

    public void NewText(string _text)
    {
        NeededInputGO.SetActive(true);
        NeededInput.text = _text;
        text = _text;
    }

    void TargetEnd()
    {
        textPosition = 0;
        NeededInputGO.SetActive(false);
        NeededInput.text = "";
        text = "";
    }
}
