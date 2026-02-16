
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [Header ("References")]
    [SerializeField] private CheckPointManager _checkPointManager;

    private LifeController _lifeController;
    private AttachableMovement _attachableMovement;
    private Mover3D _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover3D>();
        _lifeController = GetComponent<LifeController>();
        _attachableMovement = GetComponent<AttachableMovement>();
    }
     
    public void Respawn()
    {
        if (!_checkPointManager.HasCheckPoint()) return;

        transform.position = _checkPointManager.GetCheckPoint();
        _lifeController.RestoreFullHp();
        _attachableMovement.ForceDetach();
        _mover.ResetMoveAndRotate();
        _mover.ResetSpeedMultiplier();
    }
}
