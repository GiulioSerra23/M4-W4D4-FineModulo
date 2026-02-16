using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTrap : PoolableObject
{
    [Header ("Slow Settings")]
    [SerializeField] private float _slowMultiplier = 0.5f;
    [SerializeField] private float _slowDuration = 5;
    [SerializeField] private float _lifeSpan = 5;

    private Mover3D _mover;

    private float _slowStartTime;
    private bool _isSlowing;
    private float _lifeStartTime;

    private bool IsSlowFinished() => Time.time - _slowStartTime >= _slowDuration;
    private bool IsLifeFinished() => Time.time - _lifeStartTime >= _lifeSpan;

    public override void OnSpawned()
    {
        _isSlowing = false;
        _mover = null;
        _lifeStartTime = Time.time;
        _slowStartTime = Time.time;
    }

    public override void OnDespawned()
    {
        if (_mover != null)
        {
            _mover.ResetSpeedMultiplier();
            _mover = null;
        }

        _isSlowing = false;
    }

    private void ApplySlow(Mover3D mover)
    {
        _mover = mover;
        _mover.SetSpeedMultiplier(_slowMultiplier);

        _slowStartTime = Time.time;
        _isSlowing = true;
    }

    private void Update()
    {
        if (IsLifeFinished())
        {
            Release();
            return;
        }

        if (!_isSlowing) return;

        if (!IsSlowFinished()) return;

        _mover.ResetSpeedMultiplier();
        _isSlowing = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<Mover3D>(out var mover)) return;

        if (_isSlowing) return;

        ApplySlow(mover);
    }
}
