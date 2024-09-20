using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Resource : MonoBehaviour
{
    private Movement _movement;
    private Unit _followingUnit;
    private bool _isFollowing = false;

    private void Awake()
    {
        _movement = GetComponent<Movement>();   
    }

    private void Update()
    {
        if (_isFollowing)
        {
            transform.position = _followingUnit.transform.position - _followingUnit.MoveDirection.normalized;
        }
    }

    public void Follow(Unit unit)
    {
        _followingUnit = unit;
        _isFollowing = true;
        _movement.SetSpeed(_followingUnit.MoveSpeed);
    }
}