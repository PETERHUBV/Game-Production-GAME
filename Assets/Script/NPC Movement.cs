using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class NPCMovement : MonoBehaviour
{
    public Transform target;

    public float speed = 2f;
    public bool canMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove || target == null) return;
        {


            transform.position = Vector3.MoveTowards(
           transform.position,
           target.position,
           speed * Time.deltaTime
       );
        }
    }
   
}
