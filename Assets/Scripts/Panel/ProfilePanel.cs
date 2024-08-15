using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePanel : MonoBehaviour
{
    public Image avatar;
    public TMP_InputField txtField;
    [Space(10)]
    public GameObject avatarPrefab;
    public Transform content;
    private void Start()
    {
        GenerateAvatar();
    }

    private void GenerateAvatar()
    {
        for (int i = 0; i < 16; i++)
        {
            var obj = Instantiate(avatarPrefab, content);

            AvatarInfors avatarInfors = Resources.Load<AvatarInfors>("Avatars/" + (i + 1));
            obj.GetComponent<AvatarButton>().SetImage(avatarInfors);
        }
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }    
    public void Save()
    {
        //
    }
}
