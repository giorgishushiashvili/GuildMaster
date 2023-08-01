using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGeneration : MonoBehaviour
{
    
    public int GetWood(int lumberjack)
    {
        return lumberjack * 10;
    }
    public int GetOre(int miner)
    {
        return miner * 10;
    }
    public int GetHide(int hunter)
    {
        return hunter * 10;
    }
    public int GetFlax(int gatherer)
    {
        return gatherer * 10;
    }
    public int GetStone(int stoneWorker)
    {
        return stoneWorker * 10;
    }
}
