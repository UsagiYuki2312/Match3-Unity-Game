using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NormalItem;

[CreateAssetMenu(fileName = "itemNormal", menuName = "ScriptableObjects/ItemTableObject", order = 1)]
public class ItemTableObject : ScriptableObject
{
    public eNormalType ItemType;
    public Sprite ItemRenderer;
}
