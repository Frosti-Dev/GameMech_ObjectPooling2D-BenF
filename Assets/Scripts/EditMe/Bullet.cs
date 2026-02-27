using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    // create a coroutine that waits for a few seconds and then disables this gameobject.
    // in OnEnable you can start that coroutine. in OnDisable you can StopAllCoroutines! 
    // This will allow our bullet to get disabled after a few seconds if nothing was hit. 
    IEnumerator waitToDisable()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);

    }

    private void OnEnable()
    {
        StartCoroutine(waitToDisable());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    // every frame, update the bullet's position using transform.Translate 
    // You probably want to make a speed variable. 
    private void Update()
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    // OnTriggerEnter2D, please cause some damage if the other object is an IDamagable! 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<IDamagable>(out IDamagable damageableComponent))
        {
            gameObject.SetActive(false);
            damageableComponent.TakeDamage(1);
        }
        
    }

}
