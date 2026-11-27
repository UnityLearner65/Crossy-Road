using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float carSpeed = 5f;
    public Vector3 startPos;
    public Rigidbody myRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        myRB.linearVelocity = new Vector3(carSpeed, 0, 0);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        transform.position = startPos;
    //    }
    //}
}
