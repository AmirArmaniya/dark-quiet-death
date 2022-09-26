using UnityEngine;

public class gameObjectDestruction : MonoBehaviour
{
    [SerializeField] GameObject gameObjects;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.LogWarning(" Collider Trigger with Player");
            gameObjects.SetActive(false);
        }
    }

}
