using UnityEngine;

public class Goblin : MonoBehaviour
{
    public delegate void message(Vector3 player);
    public event message OnGoblin;
    public GameObject player;

    void OnPointerEnter()
    {
        OnGoblin(player.transform.position);
    }

    void OnPointerExit() {}
}
