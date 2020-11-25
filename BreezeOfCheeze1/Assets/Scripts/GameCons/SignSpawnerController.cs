using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawnerController : MonoBehaviour
{
    public Transform WarningParent;

    public GameObject HungerSign;
    public GameObject NuclearSign;

    public List<List<Vector3>> StatesList;

    public List<Vector3> AfrikaSpawnPoints;
    public List<Vector3> AsiaSpawnPoints;
    public List<Vector3> AustraliaSpawnPoints;
    public List<Vector3> EuropeSpawnPoints;
    public List<Vector3> NAmericaSpawnPoints;
    public List<Vector3> SAmerikaSpawnPoints;

    public List<Vector3> NuclearSpawnPoints;

    public List<GameObject> WarningSigns;

    float tutorialEnd = 9f;

    private void Awake()
    {
        StatesList = new List<List<Vector3>>();
        StatesList.Add(AfrikaSpawnPoints);
        StatesList.Add(AsiaSpawnPoints);
        StatesList.Add(AustraliaSpawnPoints);
        StatesList.Add(EuropeSpawnPoints);
        StatesList.Add(NAmericaSpawnPoints);
        StatesList.Add(SAmerikaSpawnPoints);
        EventManager.Instance.Fire += PointClearedWithFire;
    }

    private void OnDisable()
    {
        EventManager.Instance.Fire -= PointClearedWithFire;
    }

    private void Start()
    {
        gameObject.GetComponent<ContinentalController>().fetchMaxAmounts(AfrikaSpawnPoints.Count, AsiaSpawnPoints.Count, AustraliaSpawnPoints.Count, EuropeSpawnPoints.Count, NAmericaSpawnPoints.Count, SAmerikaSpawnPoints.Count);
    }

    public void SpawnHungerPointA()
    {
        float totalProgress = GameManager.Instance.TotalProgress();
        if (StatesList.Count == 0 || totalProgress > 100)
        {
            EventManager.Instance.onGameOver(true);
            return;
        }
        
        if (totalProgress < tutorialEnd)
        {
            SpawnHungerPointB(StatesList[0]);
        } 
        else
        {
            int rnd = Random.Range(0, StatesList.Count);
            if (StatesList[rnd].Count == 0)
            {
                StatesList.RemoveAt(rnd);
                SpawnHungerPointA();
            }
            else
            {
                SpawnHungerPointB(StatesList[rnd]);
            }           
        }      
    }

    public void SpawnHungerPointB(List<Vector3> SpawnPoints)
    {
        int rnd = Random.Range(0, SpawnPoints.Count);
        Instantiate(HungerSign, SpawnPoints[rnd], Quaternion.identity, WarningParent);
    }

    public void SpawnNuclearPoint()
    {
        int rnd = Random.Range(0, NuclearSpawnPoints.Count);
        Instantiate(NuclearSign, NuclearSpawnPoints[rnd], Quaternion.identity, WarningParent);
    }

    void PointClearedWithFire(Vector3 pos)
    {
        for (int i = 0; i < StatesList.Count; i++)
        {
            for (int j = 0; j < StatesList[i].Count; j++)
            {
                if (StatesList[i][j] == pos)
                {
                    StatesList[i].RemoveAt(j);
                    if(StatesList.Count == 0)
                    {
                        EventManager.Instance.onPause(true);    // GAME OVER
                    }
                    UpdateStatsUI();
                }
            }
        }
    }

    void UpdateStatsUI()
    {
        EventManager.Instance.onUpdateStatsUI(NAmericaSpawnPoints.Count, SAmerikaSpawnPoints.Count, EuropeSpawnPoints.Count, AsiaSpawnPoints.Count, AfrikaSpawnPoints.Count, AustraliaSpawnPoints.Count);
    }

    //void SpawnAllPoints()
    //{
    //    for (int i = 0; i < StatesList.Count; i++)
    //    {
    //        for (int j = 0; j < StatesList[i].Count; j++)
    //        {
    //            Instantiate(HungerSign, StatesList[i][j], Quaternion.identity, WarningParent);
    //        }
    //    }
    //    for (int k = 0; k < NuclearSpawnPoints.Count; k++)
    //    {
    //        Instantiate(NuclearSign, NuclearSpawnPoints[k], Quaternion.identity, WarningParent);
    //    }
    //}
}
