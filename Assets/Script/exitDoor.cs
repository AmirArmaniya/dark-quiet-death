using UnityEngine;

public class exitDoor : MonoBehaviour
{
    [SerializeField] GameObject Door;
    void Start()
    {
        spawnDoor();
    }

    public void spawnDoor()
    {

        int doorPositionLeft_Z = Random.Range(215, 265);
        int doorPositionFront_Z = Random.Range(497, 498);
        int doorPositionBack_Z = Random.Range(2, 3);
        int doorPositionRight_Z = Random.Range(203, 273);

        int[] doorPosition_Z = { 0, 1, 2, 3 };

        doorPosition_Z[0] = doorPositionLeft_Z;
        doorPosition_Z[1] = doorPositionFront_Z;
        doorPosition_Z[2] = doorPositionBack_Z;
        doorPosition_Z[3] = doorPositionRight_Z;


        int doorPositionLeft_X = Random.Range(3, 4);
        int doorPositionFront_X = Random.Range(90, 150);
        int doorPositionBack_X = Random.Range(100, 165);
        int doorPositionRight_X = Random.Range(247, 248);

        int[] doorPosition_X = { 0, 1, 2, 3 };

        doorPosition_X[0] = doorPositionLeft_X;
        doorPosition_X[1] = doorPositionFront_X;
        doorPosition_X[2] = doorPositionBack_X;
        doorPosition_X[3] = doorPositionRight_X;

        int randomDirection_Z = Random.Range(0, 3);
        int z = doorPosition_Z[randomDirection_Z];

        int randomDirection_X = randomDirection_Z;
        int x = doorPosition_X[randomDirection_X];


        Vector3 myVector = new Vector3(x, 2, z);


        Debug.LogWarning("Direction Z = " + randomDirection_Z + " Direction X = " + randomDirection_X  + " z = " + z + " , x = " + x); //Direction x and z must be like each other
        Debug.LogWarning("door Left_Z " + doorPositionLeft_Z + " door Front_Z " + doorPositionFront_Z + " door Back_Z " + doorPositionBack_Z + " door Right_Z " + doorPositionRight_Z);
        Debug.LogWarning("door Left_X " + doorPositionLeft_X + " door Front_X " + doorPositionFront_X + " door Back_X " + doorPositionBack_X + " door Right_X " + doorPositionRight_X);
        

        /*
        int doorPosition_Z_InAllOfMap = Random.Range(125, 490); // for all of map
        int doorPosition_X_InAllOfMap = Random.Range(5, 238); // for all of map
        Vector3 myVector = new Vector3(doorPosition_X_InAllOfMap, 3, doorPosition_Z_InAllOfMap);
        */

        Door.transform.SetPositionAndRotation(myVector, Quaternion.identity);
    }

    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.LogWarning("DOOR Collider Trigger with Player");
            Door.SetActive(false);
            System.Environment.Exit(0); //exit from game
        }
    }

}
