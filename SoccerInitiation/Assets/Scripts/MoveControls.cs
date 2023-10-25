using UnityEngine;

public class MoveControls : MonoBehaviour
{
    [SerializeField]
    private KeyCode Foward = KeyCode.W;
    [SerializeField]
    private KeyCode Backward = KeyCode.S;
    [SerializeField]
    private KeyCode Left = KeyCode.A;
    [SerializeField]
    private KeyCode Right = KeyCode.D;
    [SerializeField]
    private float speed = 2.0f;
    
    void Update()
    {
        if (Input.GetKey(Foward))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(Backward))
        { 
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(Left)) { 
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(Right))
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
