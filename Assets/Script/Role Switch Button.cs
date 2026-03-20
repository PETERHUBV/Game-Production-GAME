using UnityEngine;

public class RoleSwitchButton : MonoBehaviour
{
    public RoleSwitchManager roleManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    void OnMouseDown()
    {
        roleManager.SwitchRole();
    }
}
