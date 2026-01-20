using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public float range = 100;
    public float time_between_shots = 0.2f;
    public GameObject hit_marker;
    protected Timer timer;

    void Start()
    {
        timer = GetComponent<Timer>();
    }

    void Update()
    {
        
    }

    public virtual void Shoot()
    {
        Debug.Log("Shoot function for " + gameObject.name + " needs to be defined.");
    }

    public void GetLeftClickInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Shoot();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.parent.position, transform.parent.forward * range);
    }
}
