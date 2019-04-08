using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfiguration.asset", menuName = "TowerDragon/EnemyDragon Configuration", order = 1)]
public class EnemyConfiguration : ScriptableObject
{
    /// <summary>
    /// The name of the enemy dragon
    /// </summary>
    public string enemyDragonName;

    /// <summary>
    /// Short summary of the enemy dragon
    /// </summary>
    [Multiline]
    public string enemyDragonDescription;

    /// <summary>
    /// The dragon prefab that will be used on instantiation
    /// </summary>
    public EnemyDragon enemyPrefab;
}
    
