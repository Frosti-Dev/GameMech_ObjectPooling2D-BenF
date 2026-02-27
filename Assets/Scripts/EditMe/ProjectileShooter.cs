using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileShooter : MonoBehaviour
{
    
    // create fields for the bullet prefab and the firePoint (where the bullet should spawn)
    
    // TODO: After you get your bullets working, set up the ObjectPool class
    // Then create an ObjectPool type field here. The bullet prefab will be referenced
    // in the object pool rather than here. 

    void OnAttack(InputValue value)
    {
        Shoot();
    }

    void Shoot()
    {
       //instantiate your bullet here
       //Make sure it has the right position and rotation. 

    }


}
