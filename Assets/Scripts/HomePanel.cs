using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HomePanel : Panel
{
    [SerializeField] private Image Avatar;
    [SerializeField] private TextMeshProUGUI NamePlayer;
    private AvatarInfors avatarInfors;

    public static HomePanel Instance;

    private void Awake()
    {
        UpdateAvatar();
        Instance = this;
    }

    public void OpenProfile()
    {
        //PanelManager.OpenPanel("name");
        PanelManager.Instance.OpenPanel("ProfilePanel");
    }

    public void UpdateAvatar()
    {
        int idStart = PlayerPrefs.GetInt("AvatarId", 1);
        avatarInfors = Resources.Load<AvatarInfors>("Avatars/" + idStart);
        Avatar.sprite = avatarInfors.SpriteImage;
    }
    public override void Open()
    {
        base.Open();
        //Animation, load data
    }
    public void OpenSetting()
    {
        PanelManager.Instance.OpenPanel("SettingPanel");
    }
}
