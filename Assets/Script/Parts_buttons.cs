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
    private Transform Robot_redHead;
    [SerializeField]
    private Transform Robot_redLeftArm;
    [SerializeField]
    private Transform Robot_redRightArm;
    [SerializeField]
    private Transform Robot_redRightLeg;
    [SerializeField]
    private Transform Robot_redLeftLeg;
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
    [SerializeField]
    private GameState currentState;
    [SerializeField]
    private GameObject ButtonUi;
    [SerializeField]
    private GameObject Head_MenuUI;
    [SerializeField]
    private GameObject Left_ArmUI;
    [SerializeField]
    private GameObject Right_ArmUI;
    [SerializeField]
     private GameObject Left_LegUI;
    [SerializeField]
    private GameObject Right_LegUI;

    void Start()
    {
        Robot_redHead.gameObject.SetActive(false);
        ButtonUi.SetActive(true);
        Head_MenuUI.SetActive(false);
        Right_ArmUI.SetActive(false);
       Left_ArmUI.SetActive(false);
       Right_LegUI.SetActive(false);
        Left_LegUI.SetActive(false);
    }
    public void HeadSwap_click()
    {
        print("Head swapping Button!");
        Robot_Head.gameObject.SetActive(false);
        ButtonUi.SetActive(false);
        Head_MenuUI.SetActive(true);
    }
    public void Body_click()
    {
        Robot_Body.gameObject.SetActive(false);
    }
    public void LeftArm_click()
    {
        Robot_LeftArm.gameObject.SetActive(false);
        ButtonUi.SetActive(false);
        Left_ArmUI.SetActive(true);
    }

    public void RightArm_click()
    {
        Robot_RightArm.gameObject.SetActive(false);
        ButtonUi.SetActive(false);
        Right_ArmUI.SetActive(true);
    }

    public void LeftLeg_click()
    {
        Robot_LeftLeg.gameObject.SetActive(false);
        ButtonUi.SetActive(false);
        Left_LegUI.SetActive(true);
    }
    public void RightLeg_click()
    {
        Robot_RightLeg.gameObject.SetActive(false);
        ButtonUi.SetActive(false);
        Right_LegUI.SetActive(true);
    }

    public void Head1_click()
    {
        print("Head swapping Button!");
        Robot_redHead.gameObject.SetActive(true);
        ButtonUi.SetActive(true);
        Head_MenuUI.SetActive(false);

    }
    public void Head2_click()
    {

    }
     
    

    // Update is called once per frame
    private void Update()
    {
        switch (currentState)
        {
            case GameState.MenuMode:
              //  state_menuMode();
                break;
            case GameState.PlayMode:
              //  state_playMode();
                break;
            case GameState.PauseMode:
              //  state_pauseMode();
                break;
            case GameState.ScoreMode:
             //   state_ScoreMode();
                break;
            default:
                Debug.LogError("This should never happen");
                break;
        }
    }
}
