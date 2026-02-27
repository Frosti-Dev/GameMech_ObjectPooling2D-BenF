using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    [SerializeField] float flashDuration = 0.1f;

    int _currentHealth;
    SpriteRenderer _sprite;
    Color _originalColor;

    Coroutine flashRoutine;

    void Awake()
    {
   
        _sprite = GetComponent<SpriteRenderer>();
        _originalColor = _sprite.color;
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;

        if (flashRoutine != null)
            StopCoroutine(flashRoutine);

        flashRoutine = StartCoroutine(FlashRed());

       
    }

    System.Collections.IEnumerator FlashRed()
    {
        _sprite.color = Color.red;
        yield return new WaitForSeconds(flashDuration);
        _sprite.color = _originalColor;
        flashRoutine = null;
    }
}