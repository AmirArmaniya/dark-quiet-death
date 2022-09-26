
using UnityEngine;

public class lightScript : MonoBehaviour
{
    [SerializeReference] float time = 30;
    [SerializeReference] Light lightPrefab_1;
    [SerializeReference] GameObject lightPrefab_2;

    private void Start()
    {
        lightPrefab_1.enabled = false;
        lightPrefab_2.SetActive(false);
    }

    void Update()
    {
        if (lightPrefab_1.enabled == true && Input.GetMouseButtonDown(0))
        {
            lightPrefab_1.enabled = false;
            lightPrefab_2.SetActive(false);
        }
        else if (lightPrefab_1.enabled == false && Input.GetMouseButtonDown(0))
        {
            lightPrefab_1.enabled = true;
            lightPrefab_2.SetActive(true);
        }

        if (lightPrefab_1.enabled == true)
        {
            time -= Time.deltaTime;
            Debug.Log(time);

            if (time <= 25)
            {
                lightPrefab_1.intensity = 0.8f;
            }
            if (time <= 20)
            {
                lightPrefab_1.intensity = 0.6f;
            }
            if (time <= 15)
            {
                lightPrefab_1.intensity = 0.4f;
            }
            if (time <= 10)
            {
                lightPrefab_1.intensity = 0.2f;
            }
            if (time <= 5)
            {
                lightPrefab_1.intensity = 0.2f;
            }
            if (time <= 0)
            {
                lightPrefab_1.intensity = 0.0f;
                lightPrefab_2.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("battery"))
        {
            time = 30;
            lightPrefab_1.intensity = 1f;
            Debug.LogWarning("OnTriggerEnter XDXDXDXD");
        }
    }

}

