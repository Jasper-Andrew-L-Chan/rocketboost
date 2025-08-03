using UnityEngine;
using UnityEngine.InputSystem;



public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;

    private void OnEnable()
    {
        thrust.Enable();
    }
    void Update()
    {
        if (thrust.triggered)
        {
            Debug.Log("Thrust is pressed");
            
        }
    }

}