using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour
{
    #region singleton
    public static AvatarController Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public Image[] avatar;
    public void ChangeAvatar(Sprite sprite)
    {
        foreach (var item in avatar) {
            item.sprite = sprite;
        }
    }
}
