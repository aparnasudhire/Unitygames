    using UnityEngine;
    using UnityEngine.SceneManagement;
    using TMPro;

    public class CollisionHandler : MonoBehaviour
    {
        public TMP_Text lostText; // Reference to the Text Mesh Pro object.
        public float restartDelay = 2f; // Delay before restarting the scene after a loss.

        private bool hasLost = false;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player") && !hasLost)
            {
                hasLost = true;
                lostText.text = "Lost";
                Invoke("Restarting", restartDelay);
                // Call a method to restart the scene after a delay.
                Invoke("RestartScene", restartDelay);
            }
        }
        private void Restarting()
        {
            lostText.text = "Restarting..";
        }
        private void RestartScene()
        {
            // Restart the current scene.
            hasLost = false;
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }



