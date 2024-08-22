using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePanel : Panel
{
    #region SingleTon
    public static ProfilePanel Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public Image avatar;
    public TMP_InputField txtField;
    [Space(10)]
    public GameObject avatarPrefab;
    public Transform content;
    [Space(10)]
    private int idSelecting;
    private void Start()
    {
        LoadCurrentAvatar();
        GenerateAvatar();
    }

    private void LoadCurrentAvatar()
    {
        idSelecting = PlayerPrefs.GetInt("AvatarId",1);
        Debug.Log(idSelecting);
        AvatarInfors avatarInfors = Resources.Load<AvatarInfors>("Avatars/" + idSelecting);
        avatar.sprite = avatarInfors.SpriteImage;

    }

    private void GenerateAvatar()
    {
        AvatarInfors[] avatarLists = Resources.LoadAll<AvatarInfors>("Avatars");
        foreach(AvatarInfors avatar in avatarLists)
        {
            var obj = Instantiate(avatarPrefab, content);
            obj.GetComponent<AvatarButton>().Init(avatar);
        }
    }
  
    public void Save()
    {
        PlayerPrefs.SetInt("AvatarId", idSelecting);

        HomePanel.Instance.UpdateAvatar();
        Close();

        //notice to avatar outside panel
    }
    public void ChangeAvatar(AvatarInfors avatarInfo)
    {
        idSelecting = avatarInfo.Id;
        avatar.sprite = avatarInfo.SpriteImage;
    }
    public void ValidateName()
    {

    }
}
