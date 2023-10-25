using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace
using StarterAssets;

public class LevelComplete : MonoBehaviour
{
    public TextMeshProUGUI levelcomplete; // Reference to your TextMeshPro Text

    private GameObject cylinder;
    private float distanceToCylinder;
    public ThirdPersonController thirdPersonControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        levelcomplete.text = "";
        cylinder = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        distanceToCylinder = Vector3.Distance(cylinder.transform.position, transform.position);

        print("Distance to cylinder: " + distanceToCylinder);
        if (distanceToCylinder < 5f && thirdPersonControllerScript.Grounded == true)
        {
            Debug.Log("Level Complete!");
            levelcomplete.text = "Level Complete!";
        }
    }
}
