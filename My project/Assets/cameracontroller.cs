using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.fixedDeltaTime * speed) + offset; 
    }
}