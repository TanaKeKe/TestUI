using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePanel : MonoBehaviour
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
        for (int i = 0; i < 16; i++)
        {
            var obj = Instantiate(avatarPrefab, content);

            AvatarInfors avatarInfors = Resources.Load<AvatarInfors>("Avatars/" + (i + 1));
            obj.GetComponent<AvatarButton>().Init(avatarInfors);
        }
    }

    public void Close()
    {
        gameObject.SetActive(false);
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
