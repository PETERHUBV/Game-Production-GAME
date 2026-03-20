using UnityEngine;

public class GunShop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerData player;
    public CharacterRole playerRole;

    public int price = 20;

    void OnMouseDown()
    {
        if (!playerRole.IsDealer()) return;

        Customer customer = FindObjectOfType<Customer>();

        if (customer != null)
        {
            SellGun(customer);
        }
    }

    void SellGun(Customer customer)
    {
        player.AddMoney(price);

        Debug.Log("Gun Sold!");

        Destroy(customer.gameObject);
    }
}