using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportScript : MonoBehaviour
{   
    public InputActionReference action;
    public Transform teleport;
    public int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teleport = GetComponent<Transform>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (counter == 0) {
                transform.position = new Vector3(25, 0.5f, 25);
                counter = 1;
            } else {
                transform.position = new Vector3(0, 0.5f, 0);
                counter = 0;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
