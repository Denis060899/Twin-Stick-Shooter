using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : Entity
{
    Vector2 m_directionInput;
    
    void Start()
    {
        
    }

    void Update()
    {
        MoveEntity(Vector2.ClampMagnitude(m_directionInput, 1));
    }

    public override void OnDeath()
    {
        Destroy(gameObject);
    }

    public void OnMove(InputValue value)
    {
        m_directionInput = value.Get<Vector2>();
            
    }
}
