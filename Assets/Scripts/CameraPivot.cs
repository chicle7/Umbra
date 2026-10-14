using UnityEngine;
using StarterAssets;

public class CameraPivot : MonoBehaviour
{
    [SerializeField] private float yOffset = 180f;

    [Header("Mouse")]
    [SerializeField] private StarterAssetsInputs input;
    [SerializeField] private float mouseSensitivity = 1f;
    [SerializeField] private float topClamp = 30f;
    [SerializeField] private float bottomClamp = -30f;
    [SerializeField] private float sideClamp = 40f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    private void Start()
    {
        rotationY = yOffset;
        if (input == null)
        {
            input = GetComponentInParent<StarterAssetsInputs>();
        }
    }

    private void LateUpdate()
    {
        if (input == null) return;

        float mouseX = input.look.x * mouseSensitivity;
        float mouseY = input.look.y * mouseSensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}