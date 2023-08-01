using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

/// <summary>
/// this script will deal with population of the game
/// </summary>
public class PopulationCalculator : MonoBehaviour
{
    //Type of people living in the City
    //numbers in absolute
    [SerializeField] private int commonPeople;
    [SerializeField] private int maxCommonPeople;
    [SerializeField] private int minCommonPeople;

    // this will be calculate based on common people
    // in % of the people
    [SerializeField] private int governors;
    [SerializeField] private int noble;

    [SerializeField] private int populationGrowthRateMax;
    [SerializeField] private int populationGrowthRateMin;
    //share of common people in 3 different directions
    //sum of those 3 will be 100
    [SerializeField] private int militaryShare;
    [SerializeField] private int nonMilitaryShare;
    [SerializeField] private int joblessShare;


    // Military professions
    //sum of them should be 100
    [SerializeField] private int soldier;

    //Non Military professions
    //sum of them should be 100
    [SerializeField] private int lumberjack;
    [SerializeField] private int miner;
    [SerializeField] private int gatherer;
    [SerializeField] private int hunter;
    [SerializeField] private int stoneWorker;

    private int PeopleMilitaryShare()
    {
        return commonPeople * militaryShare / 100;
    }
    private int PeopleNonMilitaryShare()
    {
        return commonPeople * nonMilitaryShare / 100;
    }
    private int PeopleJoblessShare()
    {
        return commonPeople* joblessShare / 100;
    }


    public void PopulationGrowth()
    {
        int growthRate = Random.Range(populationGrowthRateMin, populationGrowthRateMax+1);
        int NewPopulation = commonPeople * growthRate / 100;
        if (NewPopulation <= maxCommonPeople && NewPopulation >= minCommonPeople)
        {
            commonPeople = NewPopulation;
        }
        else if (NewPopulation > maxCommonPeople)
        {
            commonPeople = maxCommonPeople;
        }
        else if (NewPopulation < minCommonPeople)
        {
            commonPeople = minCommonPeople;
        }
    }

    public void ModifyGrowthRate(int Min, int Max)
    {
        minCommonPeople = Min;
        maxCommonPeople = Max;
    }
    public int GetCommonPeople()
    {
        return commonPeople;
    }
    public int GetGovernors()
    {
        return commonPeople * governors / 100;
    }
    public int GetNobles()
    {
        return commonPeople * noble / 100;
    }
    //Military professions
    public int GetSoldiersAmount()
    {
        return PeopleMilitaryShare() * soldier / 100;
    }

    //Non Military professions
    public int GetLumberjackAmount()
    {
        return PeopleNonMilitaryShare() * lumberjack / 100; 
    }
    public int GetMinerAmount()
    {
        return PeopleNonMilitaryShare() * miner / 100;
    }
    public int GetGathererAmount()
    {
        return PeopleNonMilitaryShare() * gatherer / 100;
    }
    public int GetHunterAmount()
    {
        return PeopleNonMilitaryShare() * hunter / 100;
    }
    public int GetStoneWorkerAmount()
    {
        return PeopleNonMilitaryShare() * stoneWorker / 100;
    }
}
