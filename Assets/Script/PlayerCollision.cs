using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
   	private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="obstacle")
        {
            // Debug.Log("We hit target");
            GetComponent<playermove>().enabled = false;
            NewMethod();

        }
    }
    private static void NewMethod()
    {
        FindObjectOfType<GameManager>().GameEnd();
    }
}
