using UnityEngine;

public class ProyectileTracking : MonoBehaviour
{
    Vector3 StartPosition;
    float distanceTravelled = 0f;
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            distanceTravelled = Vector3.Distance(StartPosition, transform.position);
        }
    }
}
