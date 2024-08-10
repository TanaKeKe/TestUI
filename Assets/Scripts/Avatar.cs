using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar : MonoBehaviour
{
    [SerializeField] private Button BTN1;
    [SerializeField] private Button BTN2;
    [SerializeField] private Button BTN3;
    [SerializeField] private Button BTN4;
    [SerializeField] private Button BTN5;
    [SerializeField] private Button BTN6;
    [SerializeField] private Button BTN7;
    [SerializeField] private Button BTN8;
    [SerializeField] private Button BTN9;
    [SerializeField] private Button BTN10;
    [SerializeField] private Button BTN11;
    [SerializeField] private Button BTN12;
    [SerializeField] private Button BTN13;
    [SerializeField] private Button BTN14;
    [SerializeField] private Button BTN15;
    [SerializeField] private Button BTN16;
    [SerializeField] private Image AvatarProfile;
    private Image SpriteBTN1;
    private Image SpriteBTN2;
    private Image SpriteBTN3;
    private Image SpriteBTN4;
    private Image SpriteBTN5;
    private Image SpriteBTN6;
    private Image SpriteBTN7;
    private Image SpriteBTN8;
    private Image SpriteBTN9;
    private Image SpriteBTN10;
    private Image SpriteBTN11;
    private Image SpriteBTN12;
    private Image SpriteBTN13;
    private Image SpriteBTN14;
    private Image SpriteBTN15;
    private Image SpriteBTN16;

    private void Awake()
    {
        SpriteBTN1 = BTN1.GetComponent<Image>();
        SpriteBTN2 = BTN2.GetComponent<Image>();
        SpriteBTN3 = BTN3.GetComponent<Image>();
        SpriteBTN4 = BTN4.GetComponent<Image>();
        SpriteBTN5 = BTN5.GetComponent<Image>();
        SpriteBTN6 = BTN6.GetComponent<Image>();
        SpriteBTN7 = BTN7.GetComponent<Image>();
        SpriteBTN8 = BTN8.GetComponent<Image>();
        SpriteBTN9 = BTN9.GetComponent<Image>();
        SpriteBTN10 = BTN10.GetComponent<Image>();
        SpriteBTN11 = BTN11.GetComponent<Image>();
        SpriteBTN12 = BTN12.GetComponent<Image>();
        SpriteBTN13 = BTN13.GetComponent<Image>();
        SpriteBTN14 = BTN14.GetComponent<Image>();
        SpriteBTN15 = BTN15.GetComponent<Image>();
        SpriteBTN16 = BTN16.GetComponent<Image>();
    }
    private void Update()
    {

        BTN1.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN1.sprite;
        });

        BTN2.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN2.sprite;
        });

        BTN3.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN3.sprite;
        });

        BTN4.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN4.sprite;
        });

        BTN5.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN5.sprite;
        });

        BTN6.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN6.sprite;
        });

        BTN7.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN7.sprite;
        });

        BTN8.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN8.sprite;
        });

        BTN9.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN9.sprite;
        });

        BTN10.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN10.sprite;
        });

        BTN11.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN11.sprite;
        });

        BTN12.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN12.sprite;
        });

        BTN13.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN13.sprite;
        });

        BTN14.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN14.sprite;
        });

        BTN15.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN15.sprite;
        });

        BTN16.onClick.AddListener(() =>
        {
            AvatarProfile.sprite = SpriteBTN16.sprite;
        });
    }


}
