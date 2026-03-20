using UnityEngine;

public class RoleSwitchManager : MonoBehaviour
{
    public CharacterRole player;
    public CharacterRole worker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.SetRole(Roles.Guard);
        worker.SetRole(Roles.Dealer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
  
    
    public void SwitchRole()
    {
        if (player.currentRole == Roles.Guard)
        {
            player.SetRole(Roles.Dealer);
            worker.SetRole(Roles.Guard);
        }
        else
        {
            player.SetRole(Roles.Guard);
            worker.SetRole(Roles.Dealer);
        }
    }
}
