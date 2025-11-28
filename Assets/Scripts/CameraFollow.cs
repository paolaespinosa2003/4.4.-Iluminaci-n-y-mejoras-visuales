
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offsetZ = -10f;

    void LateUpdate()
    {
        if (player == null) return;
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z + offsetZ);
    }
}
