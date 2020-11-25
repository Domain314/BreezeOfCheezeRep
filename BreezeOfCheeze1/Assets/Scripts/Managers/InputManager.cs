using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class InputManager : Singleton<InputManager>, ITextInputReceiver
{
    public string lastInput = "#";
    public string numpadInput = "#";
    Keyboard keyboard;
    float normSpeed = 0.08f;
    float maxSpeed = 0.5f;

    private void Awake()
    {
        keyboard = Keyboard.current;
    }

    public void MoveLeft()
    {
        if (keyboard.fKey.wasPressedThisFrame && lastInput != "F")
        {
            ChangeLastInPut("F");
            EventManager.Instance.OnMoveLeft(maxSpeed);
        }
        if (keyboard.gKey.wasPressedThisFrame && lastInput != "G")
        {
            ChangeLastInPut("G");
            EventManager.Instance.OnMoveLeft(maxSpeed);
        }
        else if (keyboard.fKey.wasPressedThisFrame || keyboard.gKey.wasPressedThisFrame)
        {
            EventManager.Instance.OnMoveLeft(normSpeed);
        }
    }

    public void MoveRight()
    {
        if (keyboard.hKey.wasPressedThisFrame && lastInput != "H")
        {
            ChangeLastInPut("H");
            EventManager.Instance.OnMoveRight(maxSpeed);
        }
        if (keyboard.jKey.wasPressedThisFrame && lastInput != "J")
        {
            ChangeLastInPut("J");
            EventManager.Instance.OnMoveRight(maxSpeed);
        }
        else if(keyboard.hKey.wasPressedThisFrame || keyboard.jKey.wasPressedThisFrame)
        {
            EventManager.Instance.OnMoveRight(normSpeed);
        }
    }

    public void MoveUp()
    {
        if (keyboard.tKey.wasPressedThisFrame && lastInput != "T")
        {
            ChangeLastInPut("T");
            EventManager.Instance.OnMoveUp(maxSpeed);
        }
        if (keyboard.uKey.wasPressedThisFrame && lastInput != "U")
        {
            ChangeLastInPut("U");
            EventManager.Instance.OnMoveUp(maxSpeed);
        }
        else if (keyboard.tKey.wasPressedThisFrame || keyboard.uKey.wasPressedThisFrame)
        {
            EventManager.Instance.OnMoveUp(normSpeed);
        }
    }

    public void MoveDown()
    {
        if (keyboard.vKey.wasPressedThisFrame && lastInput != "V")
        {
            ChangeLastInPut("V");
            EventManager.Instance.OnMoveDown(maxSpeed);
        }
        if (keyboard.nKey.wasPressedThisFrame && lastInput != "N")
        {
            ChangeLastInPut("N");
            EventManager.Instance.OnMoveDown(maxSpeed);
        }
        else if (keyboard.vKey.wasPressedThisFrame || keyboard.nKey.wasPressedThisFrame)
        {
            EventManager.Instance.OnMoveDown(normSpeed);
        }
    }

    void ChangeLastInPut(string _lastInput)
    {
        lastInput = _lastInput;
    }

    public void OnTextInput(char character)
    {
        ((ITextInputReceiver)keyboard).OnTextInput(character);
        numpadInput += character;
    }

    public void OnIMECompositionChanged(IMECompositionString compositionString)
    {
        ((ITextInputReceiver)keyboard).OnIMECompositionChanged(compositionString);
    }
}