using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelLastSpikes : MonoBehaviour
{
    CameraFollow activeFunction;
    [SerializeField] GameObject manager;
    public GameObject amazingCamera;

    public GameObject spikeOne;
    public GameObject spikeTwo;
    public GameObject spikeThree;

    public GameObject levelText;

    private bool isOne = true;
    private bool isTwo = false;
    private bool isThree = false;
    private bool isPlayActive = false;
    private bool isDownActive = false;
    // Start is called before the first frame update
    void Start()
    {
        activeFunction = manager.GetComponent<CameraFollow>();
        levelText.SetActive(true);
        activeFunction.isActive = false;
        StartCoroutine(timer1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            amazingCamera.transform.position = new Vector3(29.78f, 0f, -10f);
            isOne = true;
            isTwo = false;
            isThree = false;
        }
        else if (Input.GetKey(KeyCode.Alpha2)) 
        {
            amazingCamera.transform.position = new Vector3(45.3f, 0f, -10f);
            isOne = false;
            isTwo = true;
            isThree = false;
        }
        else if (Input.GetKey(KeyCode.Alpha3)) 
        {
            amazingCamera.transform.position = new Vector3(58.3f, 0f, -10f);
            isOne = false;
            isTwo = false;
            isThree = true;
        }
        if (isPlayActive == true) 
        {
            if (Input.GetKey(KeyCode.DownArrow)) 
            {
                isDownActive = true;
            }
            if (isDownActive == true) 
            {
                if(Input.GetKey(KeyCode.Space))
                {
                    if (isOne == true) 
                    {
                        spikeOne.SetActive(true);
                    }
                    else if (isTwo == true) 
                    {
                        spikeTwo.SetActive(true);
                    }
                    else if (isThree == true) 
                    {
                        spikeThree.SetActive(true);
                    }
                }
            }
            
        }
    }
    IEnumerator timer1() 
    {
        yield return new WaitForSeconds(10.0f);
        levelText.SetActive(false);
        activeFunction.isActive = true;
        isPlayActive = true;
    }
}
