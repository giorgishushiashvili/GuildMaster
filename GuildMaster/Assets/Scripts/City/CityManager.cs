using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    public GameObject population;
    public GameObject resourceGeneration;
    public GameObject inventory;
    public GameObject itemList;


    public void EndOfDay()
    {
        ResourceGeneration();
        PopulationCalculation();
    }

    private void ResourceGeneration()
    {
        // Wood 
        int lumberjack = population.GetComponent<PopulationCalculator>().GetLumberjackAmount();
        int woodAmount = resourceGeneration.GetComponent<ResourceGeneration>().GetWood(lumberjack);
        Item wood = itemList.GetComponent<ItemsList>().wood;
        inventory.GetComponent<InventorySystem>().AddItem(wood, woodAmount);

        //flax
        int gatherer = population.GetComponent<PopulationCalculator>().GetGathererAmount();
        int flaxAmount = resourceGeneration.GetComponent<ResourceGeneration>().GetFlax(gatherer);
        Item flax = itemList.GetComponent<ItemsList>().flax;
        inventory.GetComponent<InventorySystem>().AddItem(flax, flaxAmount);

        //hide
        int hunter = population.GetComponent<PopulationCalculator>().GetHunterAmount();
        int hideAmount = resourceGeneration.GetComponent<ResourceGeneration>().GetHide(hunter);
        Item hide = itemList.GetComponent<ItemsList>().hide;
        inventory.GetComponent<InventorySystem>().AddItem(hide, hideAmount);

        //ore
        int miner = population.GetComponent<PopulationCalculator>().GetMinerAmount();
        int oreAmount = resourceGeneration.GetComponent<ResourceGeneration>().GetOre(miner);
        Item ore = itemList.GetComponent<ItemsList>().ore;
        inventory.GetComponent<InventorySystem>().AddItem(ore, oreAmount);

        //flax
        int stoneWorker = population.GetComponent<PopulationCalculator>().GetStoneWorkerAmount();
        int stoneAmount = resourceGeneration.GetComponent<ResourceGeneration>().GetStone(stoneWorker);
        Item stone = itemList.GetComponent<ItemsList>().stone;
        inventory.GetComponent<InventorySystem>().AddItem(flax, stoneAmount);
    }

    private void PopulationCalculation()
    {
        population.GetComponent<PopulationCalculator>().PopulationGrowth();
    }
}
