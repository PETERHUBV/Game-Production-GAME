using UnityEngine;

public class CharacterRole : MonoBehaviour
{
    public Roles currentRole;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRole(Roles r)
    {
        currentRole = r;
    }

    public bool IsGuard() => currentRole == Roles.Guard;
    public bool IsDealer() => currentRole == Roles.Dealer;
}