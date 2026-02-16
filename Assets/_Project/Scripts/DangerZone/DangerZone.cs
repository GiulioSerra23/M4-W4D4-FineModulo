
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] private int _damageAmount;
    [SerializeField] private float _interval = 1f;

    private float _timer;

    private bool CanDamage() => Time.time - _timer >= _interval;

    private void Update()
    {
        if (CanDamage())
        {
            _timer = Time.time;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.collider.TryGetComponent<LifeController>(out var lifeController)) return;

        if (!CanDamage()) return;

        lifeController.TakeDamage(_damageAmount);
    }
}
