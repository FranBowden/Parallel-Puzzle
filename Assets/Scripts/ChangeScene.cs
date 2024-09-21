using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public int sceneID;
    private TeleportActive teleportActivated;

    private void Start()
    {
        teleportActivated = FindObjectOfType<TeleportActive>();
       

    }
    public void moveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (teleportActivated == null)
        {
            Debug.LogError("teleportActivated is null!");
            return;
        }

        if (teleportActivated.isActive && collision.gameObject.CompareTag("Player")) {
            moveToScene(sceneID);
        }
       
    }


}
