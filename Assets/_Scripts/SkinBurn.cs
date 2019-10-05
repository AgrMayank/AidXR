
using GoogleARCore.Examples.HelloAR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinBurn : MonoBehaviour
{
    private GameObject panel;
    private GameObject to1;
    private GameObject to2;
    private GameObject to3;
    private GameObject target;

    public void Start()
    {
        target = GameObject.Find("Example Controller").GetComponent<HelloARController>().AndyHorizontalPlanePrefab;
    }
    public void backtomain()
    {
        SceneManager.LoadScene("00 Start Menu");
        Debug.Log("switched to 00 Start Menu");
    }
    public void infopanel()
    {
        GameObject originalGameObject = GameObject.Find("Canvass");
        panel = originalGameObject.transform.GetChild(6).gameObject;
        panel.SetActive(true);
        Debug.Log("panel poped up");
    }
    public void backtoarburnhand()
    {
       
        panel.SetActive(false);
        Debug.Log("panel poped up");
    }
    public void To1()
    {
        Debug.Log("entered to1");

        to1 = GameObject.FindGameObjectWithTag("washhand");
        Debug.Log("exit to1");
    }
    public void To2()
    {
        Debug.Log("entered to2");
        to2 = GameObject.FindGameObjectWithTag("burnthand");
        Debug.Log("exit to2");
    }
    public void To3()
    {
        Debug.Log("entered to3");
        to3 = GameObject.FindGameObjectWithTag("bandadehand");
        Debug.Log("exit to3");
    }
}
    
