using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTriggerable : MonoBehaviour, ITriggerable
{
    [Header("References")]
    [SerializeField] private CheckPointManager _checkPointManager;

    public void TriggerEnter()
    {
        _checkPointManager.SetCheckPoint(transform.position);
    }

    public void TriggerExit() { }
}
