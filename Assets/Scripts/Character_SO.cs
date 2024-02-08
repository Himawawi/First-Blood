using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_Character", menuName = "Characters/New_Character")]
public class Character_SO : ScriptableObject
{
    [SerializeField]
    float moveSpeed;

    [SerializeField]
    bool basicAttack;

    [SerializeField]
    bool chargedAttack;

    [SerializeField]
    bool projectileAttack;

    [SerializeField]
    bool defending;

    [SerializeField]
    bool dodge;

    [SerializeField]
    bool dash;

    [SerializeField]
    byte health;

    public LayerMask playerLayers;

    public Animator animator;

    public Transform attackPoint;
}
