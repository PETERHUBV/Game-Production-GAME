using System.Collections;
using UnityEngine;

public class NPCClickGuardSystem : MonoBehaviour
{
    public NPCData npc;
    public NPCMovement move;
    bool done;
    public CharacterRole playerRole;
    public Transform insidePoint;
    public Transform cashierPoint;
    bool processed = false;
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
        if (done) return;
        if (!playerRole.IsGuard()) return;

        done = true;

        if (npc.ObtainedCard)
            MoveInside();
        else
            Destroy(gameObject);
    }

    void MoveInside()
    {
        move.canMove = false;
        transform.position = insidePoint.position;
        StartCoroutine(MoveToCashier());
    }

    IEnumerator MoveToCashier()
    {
        yield return new WaitForSeconds(0.3f);

        while (Vector3.Distance(transform.position, cashierPoint.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                cashierPoint.position,
                2f * Time.deltaTime
            );
            yield return null;
        }

        gameObject.AddComponent<Customer>();
    }
}