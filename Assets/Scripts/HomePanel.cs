using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HomePanel : MonoBehaviour
{
    [SerializeField] private GameObject PanelProfile;
    [SerializeField] private Image Avatar;
    [SerializeField] private TextMeshProUGUI NamePlayer;
    private AvatarInfors avatarInfors;

    public static HomePanel Instance;

    private void Awake()
    {
        UpdateAvatar();
        Instance = this;
    }

    public void On()
    {
        PanelProfile.SetActive(true);
    }

    public void UpdateAvatar()
    {
        int idStart = PlayerPrefs.GetInt("AvatarId", 1);
        avatarInfors = Resources.Load<AvatarInfors>("Avatars/" + idStart);
        Avatar.sprite = avatarInfors.SpriteImage;
    }
}
