using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    // create a coroutine that waits for a few seconds and then disables this gameobject.
    // in OnEnable you can start that coroutine. in OnDisable you can StopAllCoroutines! 
    // This will allow our bullet to get disabled after a few seconds if nothing was hit. 


    // every frame, update the bullet's position using transform.Translate 
    // You probably want to make a speed variable. 

    // OnTriggerEnter2D, please cause some damage if the other object is an IDamagable! 
   

}
