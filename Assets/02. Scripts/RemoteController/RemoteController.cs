using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;

    public VideoClip[] clips;
    private VideoPlayer videoPlayer;

    //public bool isOn = false;
    public bool isMute = false;
    public int curruntClipIndex = 0;

    void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0];
    }

    void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnPrevChannel);
        buttonUI[3].onClick.AddListener(OnNextChannel);
    }

    public void OnScreenPower()
    {

        //isOn = !isOn;
        //videoScreen.SetActive(isOn);

        videoScreen.SetActive(!videoScreen.activeSelf);

        /*if (!isOn)
        {
            videoScreen.SetActive(true);
            isOn = true;
        }
        else
        {
            videoScreen.SetActive(false);
            isOn = false;
        }*/
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoScreen.GetComponent<VideoPlayer>().SetDirectAudioMute(0, isMute); // 영상 소리 음소거 기능

        // 현재 영상의 Mute 관련 함수를 활용한 방법
        //videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0));
    }

    public void OnNextChannel()
    {
        curruntClipIndex++;
        if (curruntClipIndex > clips.Length - 1)
            curruntClipIndex = 0;

        videoPlayer.clip = clips[curruntClipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel()
    {
        curruntClipIndex--;
        if (curruntClipIndex < 0)
            curruntClipIndex = clips.Length - 1;

        videoPlayer.clip = clips[curruntClipIndex];
        videoPlayer.Play();
    }


    // 버튼 통합본 > 지금 활용 X
    public void OnChangeChannel(bool isNext)
    {
        if (isNext)
        {
            curruntClipIndex++;
            if (curruntClipIndex > clips.Length - 1)
                curruntClipIndex = 0;
        }
        else
        {
            curruntClipIndex--;
            if (curruntClipIndex < 0)
                curruntClipIndex = clips.Length - 1;
        }

        videoPlayer.clip = clips[curruntClipIndex];
        videoPlayer.Play();
    }
}