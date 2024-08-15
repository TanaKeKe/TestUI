using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newAvatar", menuName = "AvatarInfors/Avatar", order = 1)]
public class AvatarInfors : ScriptableObject
{
    [SerializeField] private Sprite spriteImage;
    [SerializeField] private string name;
    [SerializeField] private int id;

    public Sprite SpriteImage
    {
        get { return spriteImage; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Id
    {
        get { return id; }
    }
    
}
