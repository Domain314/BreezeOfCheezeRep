using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardCon : MonoBehaviour
{
    public GameObject qKey;
    public GameObject wKey;
    public GameObject eKey;
    public GameObject rKey;
    public GameObject tKey;
    public GameObject yKey;
    public GameObject uKey;
    public GameObject iKey;
    public GameObject oKey;
    public GameObject pKey;
    public GameObject ueKey;
    public GameObject ue2Key;
    public GameObject aKey;
    public GameObject sKey;
    public GameObject dKey;
    public GameObject fKey;
    public GameObject gKey;
    public GameObject hKey;
    public GameObject jKey;
    public GameObject kKey;
    public GameObject lKey;
    public GameObject semicKey;
    public GameObject aposKey;
    public GameObject backslKey;
    public GameObject zKey;
    public GameObject xKey;
    public GameObject cKey;
    public GameObject vKey;
    public GameObject bKey;
    public GameObject nKey;
    public GameObject mKey;
    public GameObject colonKey;
    public GameObject dotKey;
    public GameObject slashKey;
    public GameObject zeroKey;
    public GameObject zeroNumKey;
    public GameObject oneKey;
    public GameObject oneNumKey;
    public GameObject twoKey;
    public GameObject twoNumKey;
    public GameObject threeKey;
    public GameObject threeNumKey;
    public GameObject forKey;
    public GameObject forNumKey;
    public GameObject fiveKey;
    public GameObject fiveNumKey;
    public GameObject sixKey;
    public GameObject sixNumKey;
    public GameObject sevenKey;
    public GameObject sevenNumKey;
    public GameObject eightKey;
    public GameObject eightNumKey;
    public GameObject nineKey;
    public GameObject nineNumKey;

    public Keyboard keyboard;

    private void Awake()
    {
        keyboard = Keyboard.current;
    }

    //Thanks to the new InputSystem, pressing and releasing a button, fires two times and sets isPressed to true/false. Turning on/off the display with one command.
    public void QKey()
    {
        qKey.SetActive(keyboard.qKey.isPressed);
    }
    public void WKey()
    {
        wKey.SetActive(keyboard.wKey.isPressed);
    }
    public void EKey()
    {
        eKey.SetActive(keyboard.eKey.isPressed);
    }
    public void RKey()
    {
        rKey.SetActive(keyboard.rKey.isPressed);
    }
    public void TKey()
    {
        tKey.SetActive(keyboard.tKey.isPressed);
    }
    public void YKey()
    {
        yKey.SetActive(keyboard.yKey.isPressed);
    }
    public void UKey()
    {
        uKey.SetActive(keyboard.uKey.isPressed);
    }
    public void IKey()
    {
        iKey.SetActive(keyboard.iKey.isPressed);
    }
    public void OKey()
    {
        oKey.SetActive(keyboard.oKey.isPressed);
    }
    public void PKey()
    {
        pKey.SetActive(keyboard.pKey.isPressed);
    }
    public void UEKey()
    {
        ueKey.SetActive(keyboard.leftBracketKey.isPressed);
    }
    public void UE2Key()
    {
        ue2Key.SetActive(keyboard.rightBracketKey.isPressed);
    }
    public void AKey()
    {
        aKey.SetActive(keyboard.aKey.isPressed);
    }
    public void SKey()
    {
        sKey.SetActive(keyboard.sKey.isPressed);
    }
    public void DKey()
    {
        dKey.SetActive(keyboard.dKey.isPressed);
    }
    public void FKey()
    {
        fKey.SetActive(keyboard.fKey.isPressed);
    }
    public void GKey()
    {
        gKey.SetActive(keyboard.gKey.isPressed);
    }
    public void HKey()
    {
        hKey.SetActive(keyboard.hKey.isPressed);
    }
    public void JKey()
    {
        jKey.SetActive(keyboard.jKey.isPressed);
    }
    public void KKey()
    {
        kKey.SetActive(keyboard.kKey.isPressed);
    }
    public void LKey()
    {
        lKey.SetActive(keyboard.lKey.isPressed);
    }
    public void SemiColKey()
    {
        semicKey.SetActive(keyboard.semicolonKey.isPressed);
    }
    public void AposKey()
    {
        aposKey.SetActive(keyboard.quoteKey.isPressed);
    }
    public void BackslaKey()
    {
        backslKey.SetActive(keyboard.backslashKey.isPressed);
    }
    public void ZKey()
    {
        zKey.SetActive(keyboard.zKey.isPressed);
    }
    public void XKey()
    {
        xKey.SetActive(keyboard.xKey.isPressed);
    }
    public void CKey()
    {
        cKey.SetActive(keyboard.cKey.isPressed);
    }
    public void VKey()
    {
        vKey.SetActive(keyboard.vKey.isPressed);
    }
    public void BKey()
    {
        bKey.SetActive(keyboard.bKey.isPressed);
    }
    public void NKey()
    {
        nKey.SetActive(keyboard.nKey.isPressed);
    }
    public void MKey()
    {
        mKey.SetActive(keyboard.mKey.isPressed);
    }
    public void ColonKey()
    {
        colonKey.SetActive(keyboard.commaKey.isPressed);
    }
    public void DotKey()
    {
        dotKey.SetActive(keyboard.periodKey.isPressed);
    }
    public void SlashKey()
    {
        slashKey.SetActive(keyboard.slashKey.isPressed);
    }

    public void ZeroKey()
    {
        zeroKey.SetActive(keyboard.digit0Key.isPressed || keyboard.numpad0Key.isPressed);
        zeroNumKey.SetActive(keyboard.digit0Key.isPressed || keyboard.numpad0Key.isPressed);
    }
    public void OneKey()
    {
        oneKey.SetActive(keyboard.digit1Key.isPressed || keyboard.numpad1Key.isPressed);
        oneNumKey.SetActive(keyboard.digit1Key.isPressed || keyboard.numpad1Key.isPressed);
    }
    public void TwoKey()
    {
        twoKey.SetActive(keyboard.digit2Key.isPressed || keyboard.numpad2Key.isPressed);
        twoNumKey.SetActive(keyboard.digit2Key.isPressed || keyboard.numpad2Key.isPressed);
    }
    public void ThreeKey()
    {
        threeKey.SetActive(keyboard.digit3Key.isPressed || keyboard.numpad3Key.isPressed);
        threeNumKey.SetActive(keyboard.digit3Key.isPressed || keyboard.numpad3Key.isPressed);
    }
    public void ForKey()
    {
        forKey.SetActive(keyboard.digit4Key.isPressed || keyboard.numpad4Key.isPressed);
        forNumKey.SetActive(keyboard.digit4Key.isPressed || keyboard.numpad4Key.isPressed);
    }
    public void FiveKey()
    {
        fiveKey.SetActive(keyboard.digit5Key.isPressed || keyboard.numpad5Key.isPressed);
        fiveNumKey.SetActive(keyboard.digit5Key.isPressed || keyboard.numpad5Key.isPressed);
    }
    public void SixKey()
    {
        sixKey.SetActive(keyboard.digit6Key.isPressed || keyboard.numpad6Key.isPressed);
        sixNumKey.SetActive(keyboard.digit6Key.isPressed || keyboard.numpad6Key.isPressed);
    }
    public void SevenKey()
    {
        sevenKey.SetActive(keyboard.digit7Key.isPressed || keyboard.numpad7Key.isPressed);
        sevenNumKey.SetActive(keyboard.digit7Key.isPressed || keyboard.numpad7Key.isPressed);
    }
    public void EightKey()
    {
        eightKey.SetActive(keyboard.digit8Key.isPressed || keyboard.numpad8Key.isPressed);
        eightNumKey.SetActive(keyboard.digit8Key.isPressed || keyboard.numpad8Key.isPressed);
    }
    public void NineKey()
    {
        nineKey.SetActive(keyboard.digit9Key.isPressed || keyboard.numpad9Key.isPressed);
        nineNumKey.SetActive(keyboard.digit9Key.isPressed || keyboard.numpad9Key.isPressed);
    }

}
