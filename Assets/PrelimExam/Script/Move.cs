using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "ScriptableObjects/Move")]
public class Move : ScriptableObject
{
    [SerializeField] string pokeName;
    [SerializeField] int damage;
    [SerializeField] Types type;
}
