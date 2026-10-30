using UnityEngine;

public class collectable : MonoBehaviour
{
    private bool collected = false;
    private bool move = false;
    private Vector3 target;
    private Collider col;
    private Renderer rd;

    public Goblin notifier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        col = GetComponent<Collider>();
        rd = GetComponent<Renderer>();
        notifier.OnGoblin += ReturnMoney;
    }

    void Update()
    {
        if (move) {
            Vector3 direction = (target - transform.position).normalized;
            transform.Translate(direction * Time.deltaTime, Space.World);
        }
    }

    void OnPointerEnter() 
    {
        if (!collected) {
            collected = true;
            rd.enabled = false;
            col.enabled = false;
        }
    }

    void OnPointerExit() {}

    void ReturnMoney(Vector3 player) {
        if (collected && !move) {
            rd.enabled = true;
            col.enabled = true;
            target = player;
            move = true;
        }
    }
}
