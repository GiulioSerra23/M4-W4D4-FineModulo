
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Mover3D _mover;
    private AnimationParamHandler _animHandler;
    private Vector3 _direction;

    private float _horizontal;
    private float _vertical;

    private void Awake()
    {
        _mover = GetComponent<Mover3D>();
        _animHandler = GetComponent<AnimationParamHandler>();
    }

    private void Update()
    {
        if (UI_State.IsUIOpen) return;

        _horizontal = Input.GetAxis(Inputs.Horizontal);
        _vertical = Input.GetAxis(Inputs.Vertical);

        _direction = new Vector3(_horizontal, 0f, _vertical);

        _animHandler.SetForward(_direction.magnitude);

        if (Input.GetButtonDown(Inputs.Space))
        {
            _mover.Jump();
        }
    }

    private void FixedUpdate()
    {
        _mover.SetMovementInput(_direction);        
    }
}
