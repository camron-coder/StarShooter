using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Gun Settings")]
    public float shootDistance = 100f;

    [Header("References")]
    public Camera playerCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Left Click
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(playerCamera.transform.position,
                            playerCamera.transform.forward,
                            out hit,
                            shootDistance))
        {
            // Only print if the hit object has the correct tag
            if (hit.collider.CompareTag("Wall"))
            {
                Debug.Log("I was Hit");
            }
        }
    }
}
