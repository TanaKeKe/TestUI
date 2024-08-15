using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newAvatar", menuName = "AvatarInfors/Avatar", order = 1)]
public class AvatarInfors : ScriptableObject
{
    [SerializeField] private Sprite spriteImage;
    [SerializeField] private int id;

    private void OnValidate()
    {
        id = int.Parse(name);
    }
}
