using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Player 2")
        {
            Destroy(gameObject);
		}
    }

}
