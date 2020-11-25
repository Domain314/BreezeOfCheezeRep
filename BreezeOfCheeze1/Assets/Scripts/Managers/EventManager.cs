using System;
using UnityEngine;

public class EventManager : Singleton<EventManager>
{
    public event Action<float> MoveLeft;
    public event Action<float> MoveRight;
    public event Action<float> MoveUp;
    public event Action<float> MoveDown;

    public event Action PhaseOne;
    public event Action PhaseOneComplete;
    public event Action PhaseTwo;
    public event Action PhaseTwoComplete;
    public event Action<Vector3> Fire;

    public event Action<Vector3> TargetWarning;
    public event Action TargetWarningEnd;
   
    public event Action<int, int, int, int, int, int> UpdateStatsUI;
    public event Action<float> UpdateProgress;

    public event Action NuclearActivated;
    public event Action NuclearDamage;
    public event Action<float> AddScore;

    public event Action GameStart;
    public event Action EndOfTutorial;
    public event Action<bool> Pause;
    public event Action<bool> GameOver;

    public void OnMoveLeft(float speed)
    {
        MoveLeft?.Invoke(speed);
    }

    public void OnMoveRight(float speed)
    {
        MoveRight?.Invoke(speed);
    }

    public void OnMoveUp(float speed)
    {
        MoveUp?.Invoke(speed);
    }

    public void OnMoveDown(float speed)
    {
        MoveDown?.Invoke(speed);
    }

    public void OnTargetWarning(Vector3 pos)
    {
        TargetWarning?.Invoke(pos);
    }

    public void OnTargetWarningEnd()
    {
        TargetWarningEnd?.Invoke();
    }

    public void OnPhaseOne()
    {
        PhaseOne?.Invoke();
    }

    public void OnPhaseOneComplete()
    {
        PhaseOneComplete?.Invoke();
    }

    public void OnPhaseTwo()
    {
        PhaseTwo?.Invoke();
    }

    public void OnPhaseTwoComplete()
    {
        PhaseTwoComplete?.Invoke();
    }

    public void onFire(Vector3 pos)
    {
        Fire?.Invoke(pos);
    }

    public void onPause(bool isPaused)
    {
        Pause?.Invoke(isPaused);
    }

    public void onNuclearDamage()
    {
        NuclearDamage?.Invoke();
    }

    public void onUpdateStatsUI(int nA, int sA, int eu, int asia, int afr, int aus)
    {
        UpdateStatsUI?.Invoke(nA, sA, eu, asia, afr, aus);
    }

    public void onUpdateProgress(float prog)
    {
        UpdateProgress?.Invoke(prog);
    }

    public void onNuclearActivated()
    {
        NuclearActivated?.Invoke();
    }

    public void onAddScore(float score)
    {
        AddScore?.Invoke(score);
    }

    public void onGameStart()
    {
        GameStart?.Invoke();
    }

    public void onEndOfTutorial()
    {
        EndOfTutorial?.Invoke();
    }

    public void onGameOver(bool result)
    {
        GameOver?.Invoke(result);
    }
}
