using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OtherObject"))
        {
            Debug.Log("Collision detected between this object and OtherObject!");
        }
    }
}
