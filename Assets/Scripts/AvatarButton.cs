using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarButton : MonoBehaviour
{
    [SerializeField] private Image preview;
    private AvatarInfors avatarInfors;
    
   public void Init(AvatarInfors avatar)
    {
        avatarInfors = avatar;

        preview.sprite = avatarInfors.SpriteImage;
    }
    public void OnClick()
    {
        ProfilePanel.Instance.ChangeAvatar(avatarInfors);
    }
}   
