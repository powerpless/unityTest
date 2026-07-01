using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Enemy enemy;

    private int kills = 0;
    void Start()
    {
        enemy.OnDied += HandleEnemyDeath;
        enemy.OnDied += MakeNoise;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MakeNoise()
    {
        Debug.Log("*проигрывается звук смерти врага*");
    }
    private void HandleEnemyDeath()
    {
        kills++;
        Debug.Log($"Враг повержен! Всего убийств: {kills}");
    }
}
