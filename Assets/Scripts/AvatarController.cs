using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour
{
    [SerializeField] private AvatarInfors avatarInfors;
    [SerializeField] private Image imageAvatar;
    [SerializeField] private string nameAvatar;
    [SerializeField] private int idAvatar;
    public void SetUI()
    {
        imageAvatar.sprite = avatarInfors.SpriteImage;
        idAvatar = avatarInfors.Id;
    }
}
