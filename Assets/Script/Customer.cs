using UnityEngine;

public class Customer : MonoBehaviour
{
    public float waitTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Leave", waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

  

    void Leave()
    {
        Destroy(gameObject);
    }
}
