using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActionBasedOnCoins : TriggerAction
{
    [Header ("References")]
    [SerializeField] private CoinsManager _coinsManager;

    [Header ("Coin Settings")]
    [SerializeField] private int _requiredCoins;

    protected override void OnTriggerEnter(Collider other)
    {
        if (!_coinsManager.HasReachedCoins(_requiredCoins)) return;

        base.OnTriggerEnter(other);
    }
}
