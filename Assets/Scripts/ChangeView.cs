using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeView : MonoBehaviour
{
    InputMaster switchInputMaster;
    public GameObject[] cubePlanes = new GameObject[5];
    public Material originMaterial;
    public Material transparentMaterial;

    private float _originAlpha;
    private float _transparentAlpha;

    [SerializeField] private float fadeSpeed = 5;

    public bool doFade;

    void Start()
    {
        switchInputMaster = new InputMaster();
        switchInputMaster.SwitchPlayer.Enable();
        switchInputMaster.SwitchPlayer.Transparency.started += SwitchTransparency;

        _originAlpha = originMaterial.color.a;
        _transparentAlpha = transparentMaterial.color.a;
    }

    // Update is called once per frame
    void Update()
    { 
        if (doFade)
        {
            FadeOut();
        }
        else
        {
            fadeIn();
        }
    }


    private void FadeOut()
    {
        foreach(var plane in cubePlanes)
        {
           Color planeMaterialColor = plane.GetComponent<Renderer>().material.color;
            Color smoothColor = new Color(planeMaterialColor.r, planeMaterialColor.g, planeMaterialColor.b,
                Mathf.Lerp(planeMaterialColor.a, _transparentAlpha, fadeSpeed * Time.deltaTime));
            plane.GetComponent<Renderer>().material.color = smoothColor;
        }
    }

    private void fadeIn()
    {
        foreach (var plane in cubePlanes)
        {
            Color planeMaterialColor = plane.GetComponent<Renderer>().material.color;
            Color smoothColor = new Color(planeMaterialColor.r, planeMaterialColor.g, planeMaterialColor.b,
                Mathf.Lerp(planeMaterialColor.a, _originAlpha, fadeSpeed * Time.deltaTime));
            plane.GetComponent<Renderer>().material.color = smoothColor;
        }
    }

    private void SwitchTransparency(InputAction.CallbackContext context)
    {
        if (doFade == true)
            doFade = false;
        else if (doFade == false)
            doFade = true;
    }

    private void OnEnable()
    {
       
    }

    private void OnDisable()
    {
        switchInputMaster.SwitchPlayer.Disable();
    }

}
