using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform Player;

    public Vector3 Offset;

    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(Player.position.x + Offset.x, transform.position.y, Player.position.z + Offset.z);
        transform.position = newPosition;
    }
}

