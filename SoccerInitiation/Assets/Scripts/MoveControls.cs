using UnityEngine;

public class MoveControls : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A)) { 
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
