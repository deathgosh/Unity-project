using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text scoreText;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");         
    }
}
