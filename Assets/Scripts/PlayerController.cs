using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _gravity;

    public float LineDistance;

    private CharacterController _controller;
    private Vector3 _direction;
    private Animator _animator;

    private int _lineToMove = 1;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (SwipeController.SwipeLeft)
        {
            if (_lineToMove > 0)
            {
                _lineToMove--;
            }
        }

        if (SwipeController.SwipeRight)
        {
            if (_lineToMove < 2)
            {
                _lineToMove++;
            }
        }

        if (SwipeController.SwipeUp)
        {
            if(_controller.isGrounded)  
                Jump();
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(_lineToMove == 0)
        {
            targetPosition += Vector3.left * LineDistance;
        }
        else if (_lineToMove == 2)
        {
            targetPosition += Vector3.right * LineDistance;
        }

        if (transform.position == targetPosition)
        {
            return;
        }

        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDirection = diff.normalized * 25 * Time.deltaTime;

        if (moveDirection.sqrMagnitude < diff.sqrMagnitude)
        {
            _controller.Move(moveDirection);
        }
        else
        {
            _controller.Move(diff);
        }
    }

    private void Jump()
    {
        _direction.y = _jumpForce;
        _animator.SetTrigger("Jump");
    }
    void FixedUpdate()
    {
        _direction.z = _speed;
        _direction.y += _gravity * Time.fixedDeltaTime;
        _controller.Move(_direction * Time.fixedDeltaTime);
    }
}
