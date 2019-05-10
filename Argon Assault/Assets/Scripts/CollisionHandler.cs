using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")] [SerializeField] float loadLevelDelay = 1f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;
    void OnTriggerEnter(Collider other)
    {
        StartDeathSequnce();
        deathFX.SetActive(true);
        Invoke("ReloadScene", loadLevelDelay);
    }

    private void StartDeathSequnce()
    {
        SendMessage("OnPlayerDeath");      
    }

    private void ReloadScene() // string referenced
    {
        SceneManager.LoadScene(1);
    }
}
