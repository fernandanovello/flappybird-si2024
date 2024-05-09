using UnityEngine;

public class Points : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
       var GameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = GameObject.GetComponent<GameManager>();

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.Score++;
    }
}