
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header ("References")]
    [SerializeField] private GameObject _objectPrefab;

    [Header ("Spawn Settings")]
    [SerializeField] private float _spawnInterval = 2f;

    private float _lastSpawn;
    private bool _canSpawn;

    protected bool CanSpawnNow()
    {
        return Time.time - _lastSpawn >= _spawnInterval && _canSpawn;
    }

    private void InstantiateObject()
    {
        GameObject objectClone = Instantiate(_objectPrefab, transform.position, transform.rotation);
    }

    private void SpawnObject()
    {
        if (!CanSpawnNow()) return;

        InstantiateObject();
        _lastSpawn = Time.time;
    }

    private void Update()
    {
        SpawnObject();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(Tags.Player)) return;

        _canSpawn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag(Tags.Player)) return;

        _canSpawn = false;
    }
}
