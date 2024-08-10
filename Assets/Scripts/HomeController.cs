using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HomeController : MonoBehaviour
{
    [SerializeField] private GameObject PanelProfile;
    [SerializeField] private Image Avatar;
    [SerializeField] private Image AvatarProfile;
    [SerializeField] private TextMeshProUGUI NamePlayer;
    [SerializeField] private TMP_InputField Name;
    private int MaxLength = 10;
    public void SetProfile()
    {
        PanelProfile.SetActive(true);
        AvatarProfile.sprite = Avatar.sprite;
        Name.text = NamePlayer.text;
    }

    public void ExitProfile()
    {
        PanelProfile.SetActive(false);
    }

    public void SaveProfile()
    {
        PanelProfile.SetActive(false);
        NamePlayer.text = Name.text;
        Avatar.sprite = AvatarProfile.sprite;
    }

    public void SetAvatar()
    {
        Debug.Log(gameObject.ToString());
        AvatarProfile.sprite = gameObject.GetComponent<Image>().sprite;
    }
    public void OnValueChanged()
    {
        if(Name.text.Length > MaxLength)
        {
            Name.text  = Name.text.Substring(0, MaxLength);
        }
    }


}
