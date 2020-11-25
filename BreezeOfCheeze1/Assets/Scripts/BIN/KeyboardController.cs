//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;
//using UnityEngine.InputSystem;

    // not very elegant. should be re-done after 1.0 ---- DONE
    // OBSOLETE

//public class KeyboardController : MonoBehaviour
//{
//    public List<GameObject> pressedButtons;
//    Keyboard keyboard;
//    bool isDeactivating = false;

//    public GameObject EngGerDiff;
//    public GameObject first_Key;  // not working
//    public GameObject numA1_Key;
//    public GameObject numA2_Key;
//    public GameObject numA3_Key;
//    public GameObject numA4_Key;
//    public GameObject numA5_Key;
//    public GameObject numA6_Key;
//    public GameObject numA7_Key;
//    public GameObject numA8_Key;
//    public GameObject numA9_Key;
//    public GameObject numA0_Key;
//    public GameObject numA10_Key; // not working on eng
//    public GameObject numA11_Key; // not working
//    public GameObject Q_Key;
//    public GameObject W_Key;
//    public GameObject E_Key;
//    public GameObject R_Key;
//    public GameObject T_Key;
//    public GameObject Z_Key;
//    public GameObject U_Key;
//    public GameObject I_Key;
//    public GameObject O_Key;
//    public GameObject P_Key;
//    public GameObject UE_Key;
//    public GameObject plus_Key;
//    public GameObject A_Key;
//    public GameObject S_Key;
//    public GameObject D_Key;
//    public GameObject F_Key;
//    public GameObject G_Key;
//    public GameObject H_Key;
//    public GameObject J_Key;
//    public GameObject K_Key;
//    public GameObject L_Key;
//    public GameObject OE_Key;
//    public GameObject AE_Key;
//    public GameObject hashtag_Key;
//    public GameObject pointing_Key;
//    public GameObject Y_Key;
//    public GameObject X_Key;
//    public GameObject C_Key;
//    public GameObject V_Key;
//    public GameObject B_Key;
//    public GameObject N_Key;
//    public GameObject M_Key;
//    public GameObject dot_Key;
//    public GameObject colon_Key;
//    public GameObject dash_Key;
//    public GameObject numB1_Key;
//    public GameObject numB2_Key;
//    public GameObject numB3_Key;
//    public GameObject numB4_Key;
//    public GameObject numB5_Key;
//    public GameObject numB6_Key;
//    public GameObject numB7_Key;
//    public GameObject numB8_Key;
//    public GameObject numB9_Key;
//    public GameObject numB0_Key;
//    public GameObject numEnter_Key;
//    public GameObject Enter_Key;
//    public GameObject Space_Key;


//    private void Awake()
//    {
//        if (!GameManager.Instance.keyboardLayoutLanguage)
//        {
//            EngGerDiff.GetComponent<TextMeshProUGUI>().text = ";";
//        }
//        pressedButtons = new List<GameObject>();
//        keyboard = Keyboard.current;
//    }

//    private void Update()
//    {
//        if (!isDeactivating)
//        {
//            StartCoroutine(KeyDeactivation());
//        }
//    }

//    protected void OnEnable()
//    {
//        Keyboard.current.onTextInput += KeyboardInput;
//    }
//    protected void OnDisable()
//    {
//        Keyboard.current.onTextInput -= KeyboardInput;
//    }

//    void KeyboardInput(char ch)
//    {
//        switch (ch)
//        {
//            case '1':
//                numA1_Key.SetActive(true);
//                numB1_Key.SetActive(true);
//                pressedButtons.Add(numA1_Key);
//                pressedButtons.Add(numB1_Key);
//                break;
//            case '2':
//                numA2_Key.SetActive(true);
//                numB2_Key.SetActive(true);
//                pressedButtons.Add(numA2_Key);
//                pressedButtons.Add(numB2_Key);
//                break;
//            case '3':
//                numA3_Key.SetActive(true);
//                numB3_Key.SetActive(true);
//                pressedButtons.Add(numA3_Key);
//                pressedButtons.Add(numB3_Key);
//                break;
//            case '4':
//                numA4_Key.SetActive(true);
//                numB4_Key.SetActive(true);
//                pressedButtons.Add(numA4_Key);
//                pressedButtons.Add(numB4_Key);
//                break;
//            case '5':
//                numA5_Key.SetActive(true);
//                numB5_Key.SetActive(true);
//                pressedButtons.Add(numA5_Key);
//                pressedButtons.Add(numB5_Key);
//                break;
//            case '6':
//                numA6_Key.SetActive(true);
//                numB6_Key.SetActive(true);
//                pressedButtons.Add(numA6_Key);
//                pressedButtons.Add(numB6_Key);
//                break;
//            case '7':
//                numA7_Key.SetActive(true);
//                numB7_Key.SetActive(true);
//                pressedButtons.Add(numA7_Key);
//                pressedButtons.Add(numB7_Key);
//                break;
//            case '8':
//                numA8_Key.SetActive(true);
//                numB8_Key.SetActive(true);
//                pressedButtons.Add(numA8_Key);
//                pressedButtons.Add(numB8_Key);
//                break;
//            case '9':
//                numA9_Key.SetActive(true);
//                numB9_Key.SetActive(true);
//                pressedButtons.Add(numA9_Key);
//                pressedButtons.Add(numB9_Key);
//                break;
//            case '0':
//                numA0_Key.SetActive(true);
//                numB0_Key.SetActive(true);
//                pressedButtons.Add(numA0_Key);
//                pressedButtons.Add(numB0_Key);
//                break;
//            case 'ß':
//                numA10_Key.SetActive(true);
//                pressedButtons.Add(numA10_Key);
//                break;
//            case 'q':
//                Q_Key.SetActive(true);
//                pressedButtons.Add(Q_Key);
//                break;
//            case 'w':
//                W_Key.SetActive(true);
//                pressedButtons.Add(W_Key);
//                break;
//            case 'e':
//                E_Key.SetActive(true);
//                pressedButtons.Add(E_Key);
//                break;
//            case 'r':
//                R_Key.SetActive(true);
//                pressedButtons.Add(R_Key);
//                break;
//            case 't':
//                T_Key.SetActive(true);
//                pressedButtons.Add(T_Key);
//                break;
//            case 'z':
//                Z_Key.SetActive(true);
//                pressedButtons.Add(Z_Key);
//                break;
//            case 'u':
//                U_Key.SetActive(true);
//                pressedButtons.Add(U_Key);
//                break;
//            case 'i':
//                I_Key.SetActive(true);
//                pressedButtons.Add(I_Key);
//                break;
//            case 'o':
//                O_Key.SetActive(true);
//                pressedButtons.Add(O_Key);
//                break;
//            case 'p':
//                P_Key.SetActive(true);
//                pressedButtons.Add(P_Key);
//                break;
//            case 'ü':
//                UE_Key.SetActive(true);
//                pressedButtons.Add(UE_Key);
//                break;
//            case '+':
//                plus_Key.SetActive(true);
//                pressedButtons.Add(plus_Key);
//                break;
//            case 'a':
//                A_Key.SetActive(true);
//                pressedButtons.Add(A_Key);
//                break;
//            case 's':
//                S_Key.SetActive(true);
//                pressedButtons.Add(S_Key);
//                break;
//            case 'd':
//                D_Key.SetActive(true);
//                pressedButtons.Add(D_Key);
//                break;
//            case 'f':
//                F_Key.SetActive(true);
//                pressedButtons.Add(F_Key);
//                break;
//            case 'g':
//                G_Key.SetActive(true);
//                pressedButtons.Add(G_Key);
//                break;
//            case 'h':
//                H_Key.SetActive(true);
//                pressedButtons.Add(H_Key);
//                break;
//            case 'j':
//                J_Key.SetActive(true);
//                pressedButtons.Add(J_Key);
//                break;
//            case 'k':
//                K_Key.SetActive(true);
//                pressedButtons.Add(K_Key);
//                break;
//            case 'l':
//                L_Key.SetActive(true);
//                pressedButtons.Add(L_Key);
//                break;
//            case 'ö':
//                OE_Key.SetActive(true);
//                pressedButtons.Add(OE_Key);
//                break;
//            case 'ä':
//                AE_Key.SetActive(true);
//                pressedButtons.Add(AE_Key);
//                break;
//            case '#':
//                hashtag_Key.SetActive(true);
//                pressedButtons.Add(hashtag_Key);
//                break;
//            case '<':
//                pointing_Key.SetActive(true);
//                pressedButtons.Add(pointing_Key);
//                break;
//            case 'y':
//                Y_Key.SetActive(true);
//                pressedButtons.Add(Y_Key);
//                break;
//            case 'x':
//                X_Key.SetActive(true);
//                pressedButtons.Add(X_Key);
//                break;
//            case 'c':
//                C_Key.SetActive(true);
//                pressedButtons.Add(C_Key);
//                break;
//            case 'v':
//                V_Key.SetActive(true);
//                pressedButtons.Add(V_Key);
//                break;
//            case 'b':
//                B_Key.SetActive(true);
//                pressedButtons.Add(B_Key);
//                break;
//            case 'n':
//                N_Key.SetActive(true);
//                pressedButtons.Add(N_Key);
//                break;
//            case 'm':
//                M_Key.SetActive(true);
//                pressedButtons.Add(M_Key);
//                break;
//            case ',':
//                colon_Key.SetActive(true);
//                pressedButtons.Add(colon_Key);
//                break;
//            case '.':
//                dot_Key.SetActive(true);
//                pressedButtons.Add(dot_Key);
//                break;
//            case '-':
//                dash_Key.SetActive(true);
//                pressedButtons.Add(dash_Key);
//                break;
//            case ' ':
//                Space_Key.SetActive(true);
//                pressedButtons.Add(Space_Key);
//                break;

//            default:
//                //Debug.Log("No Key");
//                break;
//        }
//    }

//    IEnumerator KeyDeactivation()
//    {
//        isDeactivating = true;
//        for (int i = 0; i < pressedButtons.Count; i++)
//        {
//            if (!keyboard.anyKey.isPressed)
//            {
//                pressedButtons[i].SetActive(false);
//                pressedButtons.Remove(pressedButtons[i]);
//            }
//        } 
//        isDeactivating = false;
//        yield return null;
//    }
//}
