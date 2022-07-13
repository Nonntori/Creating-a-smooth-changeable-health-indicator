using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;

    private float _maxHealth = 100;
    private float _damage = 10;
    private float _heal = 10;

    public UnityAction ChangingBar;
    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void TakeDamage()
    {
        if(_health > 0)
        {
            _health -= _damage;
        }

        ChangingBar?.Invoke();
    }

    public void TakeHeal()
    {
        if (_health < _maxHealth)
        {
            _health += _heal;
        }

        ChangingBar?.Invoke();
    }
}
