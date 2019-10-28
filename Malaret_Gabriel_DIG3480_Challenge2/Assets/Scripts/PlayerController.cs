using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Text countText;
    public Text livesText;
    public Text winText;
    public Text loseText;
    public Transform TP;

    private Rigidbody2D rb2d;
    private int count;
    private int lives;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();


        count = 0;

        lives = 3;

        winText.text = "";

        loseText.text = "";

        SetCountText();

        SetLivesText();
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        // This should affect the players lives
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);

            lives = lives - 1;

            SetCountText();
            SetLivesText();
        }
        // Intended to have player be turned off
        if (lives <= 0)
            player.gameObject.SetActive(false);

        if (other.gameObject.tag == "Teleport")
        {
            transform.position = TP.position;
        }

        // This needs the tp to spawn at location
        // if (count <= 11)
        // {
            //other.gameObject.CompareTag("Teleport");
            //other.gameObject.SetActive(false);

            //if (count >= 12)
            //{

              //  other.gameObject.CompareTag("Teleport");
              //  other.gameObject.SetActive(true);
            //}
        //}

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Pickup")
        {
            count += 1;
            countText.text = count.ToString();
            Destroy(collision.collider.gameObject);
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 5)
            winText.text = "You Win! Game Created" +
                "By Gabriel Malaret";

    }
    // Text should be display after lives counter goes to 0
    void SetLivesText() {
        livesText.text = "Lives: " + lives.ToString();

        if (lives <= 0)
            loseText.text = "You Lose!";
       

    }
    

    







}

