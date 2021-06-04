using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int StarCost = 100;
    [SerializeField] int starsToEarn = 2;

    public int GetStarCost() { return StarCost; }

    public void AddStars(int amount)
    {
        FindObjectOfType<StarsCounter>().AddStars(starsToEarn);
    }
}
