using UnityEngine;
using UnityEngine.InputSystem;

public class LightScript : MonoBehaviour
{
    public Light lightComp;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightComp = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            lightComp.color = new Color(2.5f, 2.0f, 2.5f);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
