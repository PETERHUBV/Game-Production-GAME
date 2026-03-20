using UnityEngine;

public class DealerSystem : MonoBehaviour
{
    public PlayerData player;
    public CharacterRole playerRole;
    public int earnAmount = 21;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {





        if (!playerRole.IsDealer()) return;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(
                Camera.main.ScreenToWorldPoint(Input.mousePosition),
                Vector2.zero
            );

            if (hit.collider != null && hit.collider.GetComponent<Customer>())
            {
                player.AddMoney(earnAmount);
                Destroy(hit.collider.gameObject);
                Debug.Log("Sold Gun!");
            }
        }
    }
}