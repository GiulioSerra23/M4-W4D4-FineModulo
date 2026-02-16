using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class LevelCompletedTriggerable : MonoBehaviour, ITriggerable
{
    [Header ("Level Settings")]
    [SerializeField] private int _indexLevel;

    [Header ("Events")]
    [SerializeField] private UnityEvent _onLevelCompleted;

    public void TriggerEnter()
    {
        LevelProgression.CompleteLevel(_indexLevel);
        _onLevelCompleted.Invoke();
    }

    public void TriggerExit() { }
}
