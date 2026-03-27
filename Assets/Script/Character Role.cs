using UnityEngine;

public class CharacterRole : MonoBehaviour
{
    public Roles currentRole;


    public Sprite guardSprite;
    public Sprite dealerSprite;


    private SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        UpdateSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRole(Roles r)
    {
        currentRole = r;
        UpdateSprite();
    }

    void UpdateSprite()
    {
        if (sr == null) return;

        if (currentRole == Roles.Guard)
            sr.sprite = guardSprite;
        else
            sr.sprite = dealerSprite;
    }

    public bool IsGuard() => currentRole == Roles.Guard;
    public bool IsDealer() => currentRole == Roles.Dealer;
}