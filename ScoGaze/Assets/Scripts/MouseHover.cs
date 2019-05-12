using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MouseHover : MonoBehaviour
{

    //[SerializeField] private float duration = 10f;
    [SerializeField] private float redTimer = 0f;
    [SerializeField] private float blueTimer = 0f;
    [SerializeField] private GameObject BlueGameObject;
    [SerializeField] private GameObject RedGameObject;
    [SerializeField] private GameObject JokeGameObject;
    
    Ray ray;
    RaycastHit hit;
    
    

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Red")
        {
            redTimer += Time.deltaTime;
            RedGameObject.GetComponent<TextMeshProUGUI>().text = hit.collider.name + "Timer: " + System.Math.Round(redTimer, 2);
        }
        

        else if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Blue")
        {
            blueTimer += Time.deltaTime;
            BlueGameObject.GetComponent<TextMeshProUGUI>().text = hit.collider.name + "Timer: " + System.Math.Round(blueTimer, 2);
        }
        

        if (redTimer >= 10f)
        {
            JokeGameObject.GetComponent<TextMeshProUGUI>().text = "You stared at the Red Cube for 10 seconds!";
        }
        else if (blueTimer >= 10f)
        {
            JokeGameObject.GetComponent<TextMeshProUGUI>().text = "You stared at the Blue Cube for 10 seconds!";
        }
        
    }

    
}
