using UnityEngine;
public class Bounds : MonoBehaviour
{

    public Camera mainCamera;
    public Transform P1; //player one
    public Transform P2; //player two
   
    // Update is called once per frame
    void Update()
    {

        float x = (P1.position.x + P2.position.x) / 2; //calculate average distance of both players
        transform.position = new Vector2(x, 1); //keep Y = 1, update X;

        inCameraView();
    }


    void inCameraView()
    {
        Plane[] cameraPlanes = GeometryUtility.CalculateFrustumPlanes(mainCamera);

        bool isPlayer1InCameraView = GeometryUtility.TestPlanesAABB(cameraPlanes, P1.GetComponent<CircleCollider2D>().bounds);
        bool isPlayer2InCameraView = GeometryUtility.TestPlanesAABB(cameraPlanes, P2.GetComponent<CircleCollider2D>().bounds);

        if(!isPlayer1InCameraView || !isPlayer2InCameraView) //if one is not in camera view
        {
            Debug.Log("RETURN BACK TO PLAYER!!! ");
        } else
        {
            //do nothing
        }

        if (mainCamera == null || P1 == null || P2 == null)
        {
            Debug.LogWarning("Camera or player references not set.");
        }
    }
}
