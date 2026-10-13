using UnityEngine;

public class CameraRootFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 1.5f, 0f);

    void LateUpdate()
    {
        if (target != null)
            transform.position = target.position + offset;
    }
}