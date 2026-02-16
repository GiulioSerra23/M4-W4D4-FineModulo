
using UnityEngine;

public class TimePickup : Pickup
{
    [Header ("References")]
    [SerializeField] private TimerManager _timeManager;

    [Header ("Time Settings")]
    [SerializeField] private float _timeAmount = 10f;

    public override void OnPick(GameObject player)
    {
        base.OnPick(player);

        _timeManager.AddTime(_timeAmount);
    }
}
