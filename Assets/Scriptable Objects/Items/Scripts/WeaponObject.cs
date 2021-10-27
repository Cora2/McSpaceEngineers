using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon")]
public class WeaponObject : ItemObject
{
    public int BaseProductionTime; // seconds
    public int RateOfFire; // Rounds Per Minute (RPM)
    public float ShotSpread; // Degrees
    public int DamageToPlayer = 24;
    public int DamageToBlocks = 30;
    public int MagazineSize = 30; // rounds
    public int MuzzleVelocity = 300; // meters per second
    public int MaximumRange = 800; // meters
    public float Impulse = 3.2f; // N
    public MaterialArray[] Materials;
    public void Awake()
    {
        type = ItemType.Tool;
    }
}
