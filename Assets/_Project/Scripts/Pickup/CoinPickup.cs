using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : Pickup
{
    [Header("References")]
    [SerializeField] private CoinsManager _coinsManager;

    [Header ("Coins Settings")]
    [SerializeField] private int _coinsAmount;

    public override void OnPick(GameObject picker)
    {
        base.OnPick(picker);

        _coinsManager.AddCoins(_coinsAmount);
    }
}
