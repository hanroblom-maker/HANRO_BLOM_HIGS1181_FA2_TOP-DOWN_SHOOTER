using UnityEngine;

using UnityEngine.SceneManagement;



public class Enemy : MonoBehaviour

{

    void OnTriggerEnter2D(Collider2D collision)

    {

        // Bullet destroys enemy

        if (collision.CompareTag("Bullet"))

        {

            Destroy(collision.gameObject);

            Destroy(gameObject);



            Debug.Log("Enemy Destroyed");

        }



        // Enemy destroys player

        if (collision.CompareTag("Player"))

        {

            Debug.Log("Player Destroyed");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }

}