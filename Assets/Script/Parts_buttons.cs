using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Parts_buttons : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform Robot_Head;
    [SerializeField]
    private Transform Robot_LeftArm;
    [SerializeField]
    private Transform Robot_RightArm;
    [SerializeField]
    private Transform Robot_Body;
    [SerializeField]
    private Transform Robot_RightLeg;
    [SerializeField]
    private Transform Robot_LeftLeg;

    public void HeadSwap_click()
    {
        print("Head swapping Button!");
        Robot_Head.gameObject.SetActive(false);
    }
    public void Body_click()
    {
        Robot_Body.gameObject.SetActive(false);
    }
    public void LeftArm_click()
    {
        Robot_LeftArm.gameObject.SetActive(false);
    }

    public void RightArm_click()
    {
        Robot_RightArm.gameObject.SetActive(false);
    }

    public void LeftLeg_click()
    {
        Robot_LeftLeg.gameObject.SetActive(false);
    }
    public void RightLeg_click()
    {
        Robot_RightLeg.gameObject.SetActive(false);
    }
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
