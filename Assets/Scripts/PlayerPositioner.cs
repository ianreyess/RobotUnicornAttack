using UnityEngine;

public class PlayerPositioner : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform startingPosition;
    public void SetPlayePosition()
    {
        player.position = startingPosition.position;
    }
}
