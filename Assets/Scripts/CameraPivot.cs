using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    [Header("Rotación inicial de la cámara")]
    [SerializeField] private float yOffset = 180f;

    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, yOffset, 0f);
    }
}