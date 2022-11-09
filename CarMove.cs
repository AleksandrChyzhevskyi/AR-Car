using UnityEngine;

public class CarMove : MonoBehaviour
{
    public GameObject butForward, butBack, butStap;
    private float speed = 5f;

    private void Update()
    {
        Forward();
        Back();
        Stop();
    }

    public void Forward()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }
    public void Back()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
    }
    public void Stop()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
