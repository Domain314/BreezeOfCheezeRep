using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    // true = ger, false = eng
    public bool keyboardLayoutLanguage;

    //true = normal, false = easy
    public bool difficulty = false;

    public bool isPaused = false;
    public bool isAdvanced = false;
    public bool isTutorial = true;
    public bool isWin = false;

    public GameObject PauseGO;
    public GameObject WorldGO;
    SignSpawnerController signSpawnerCon;
    public GameObject GameOverScreen;

    public TextMeshProUGUI PlayerLife;

    float hungerTimer = 9f;
    float hungerSpawningTimer = 10f;
    float nuclearTimer = 43f;
    float nuclearSpawningTimer = 50f;

    int playerLife = 3;
    float totalProgress;
    float playerScore;


    private void Awake()
    {       
        EventManager.Instance.NuclearDamage += LoseLife;
        EventManager.Instance.UpdateProgress += UpdateTotalProgress;
        EventManager.Instance.AddScore += ScoreUpdate;
        EventManager.Instance.GameStart += NewGameSetup;
        EventManager.Instance.EndOfTutorial += EndTutorial;
        EventManager.Instance.GameOver += GameOver;

        // Application.systemLanguage == SystemLanguage.English || Application.systemLanguage == SystemLanguage.German

        switch (PlayerPrefs.GetInt("language"))
        {
            case 0:
                keyboardLayoutLanguage = false;
                break;
            case 1:
                keyboardLayoutLanguage = true;
                break;

            default:
                Debug.Log("No language found");
                break;
        }

        switch (PlayerPrefs.GetInt("difficulty"))
        {
            case 0:
                difficulty = false;
                break;
            case 1:
                difficulty = true;
                break;

            default:
                Debug.Log("No difficulty found");
                break;
        }
    }

    void NewGameSetup()
    {
        PauseGO = GameObject.FindGameObjectWithTag("PauseGO");
        PauseGO.SetActive(false);
        WorldGO = GameObject.FindGameObjectWithTag("World");
        signSpawnerCon = WorldGO.GetComponent<SignSpawnerController>();
        PlayerLife = GameObject.FindGameObjectWithTag("PlayerLife").GetComponent<TextMeshProUGUI>();
        GameOverScreen = GameObject.FindGameObjectWithTag("GameOver");
        GameOverScreen.SetActive(false);
        isPaused = true;
    }

    private void OnDisable()
    {
        EventManager.Instance.NuclearDamage -= LoseLife;
        EventManager.Instance.UpdateProgress -= UpdateTotalProgress;
        EventManager.Instance.AddScore -= ScoreUpdate;
        EventManager.Instance.GameStart -= NewGameSetup;
        EventManager.Instance.EndOfTutorial -= EndTutorial;
        EventManager.Instance.GameOver -= GameOver;
    }

    private void Update()
    {
        if (!isPaused)
        {
            hungerTimer += Time.deltaTime;

            if (isAdvanced)
            {
                nuclearTimer += Time.deltaTime;
            }
        }
       
        if (hungerTimer >= hungerSpawningTimer)
        {
            signSpawnerCon.SpawnHungerPointA();
            hungerTimer = 0;
        }

        if(nuclearTimer >= nuclearSpawningTimer)
        {
            signSpawnerCon.SpawnNuclearPoint();
            if (nuclearSpawningTimer > 25)
            {
                nuclearSpawningTimer--;
            }           
            nuclearTimer = 0;
        }
    }

    void EndTutorial()
    {
        isTutorial = false;
        isPaused = false;
    }

    public void PauseGame()
    {
        if (isTutorial)
        {
            return;
        }
        isPaused = !isPaused;
        PauseGO.SetActive(isPaused);
    }

    void LoseLife()
    {
        playerLife--;
        PlayerLife.text = playerLife.ToString();
        if (playerLife <= 0)
        {
            EventManager.Instance.onGameOver(false);
        }
    }

    void UpdateTotalProgress(float prog)
    {
        totalProgress = prog * 100;
        if (totalProgress >= 30f && !isAdvanced)
        {
            isAdvanced = true;
            EventManager.Instance.onNuclearActivated();
        }
    }

    public float TotalProgress()
    {
        return totalProgress;
    }

    void ScoreUpdate(float score)
    {
        playerScore += score * 100;
    }

    public float TotalScore()
    {
        return playerScore;
    }

    void GameOver(bool result)
    {
        isWin = result;
        isPaused = true;
        isTutorial = true;
        hungerTimer = 0;
        nuclearTimer = 0;
        GameOverScreen.SetActive(true);
        GameOverScreen.GetComponent<GameOverController>().SetupDisplay();
    }
}
