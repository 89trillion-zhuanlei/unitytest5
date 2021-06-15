using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChamptionPanel : MonoBehaviour
{
    [SerializeField] private Text scorText;
    [SerializeField] private GameObject showReward;//奖励界面列表
    [SerializeField] private GameObject outPanel;//查看，加分等UI界面
    [SerializeField] private GameObject closeBtn;
    private GameObject newShowReward;//奖励列表展示UI
    /// <summary>
    /// 点击事件监听 加分按钮点击事件
    /// </summary>
    public void ClickAddScoreBtn()
    {
        GlobalChampData.score += 100;
        scorText.text = Mathf.Clamp(GlobalChampData.score, 0, 6000).ToString();
    }

    /// <summary>
    /// 点击事件监听 查看段位按钮事件监听
    /// </summary>
    public void ClickShowBtn()
    {
        newShowReward = Instantiate(showReward, transform);
        outPanel.SetActive(false);
        closeBtn.SetActive(true);
    }

    /// <summary>
    /// 点击事件监听 关闭返回按钮事件监听
    /// </summary>
    public void ClickCloseBtn()
    {
        Destroy(newShowReward);
        outPanel.SetActive(true);
        closeBtn.SetActive(false);
    }

    /// <summary>
    /// 刷新赛季按钮事件监听
    /// </summary>
    public void RefreshSeason()
    {
        if (GlobalChampData.score > 4000)
        {
            GlobalChampData.score=GlobalChampData.score/2;
            scorText.text = GlobalChampData.score.ToString();
            for (int i = 0; i < GlobalChampData.globalData.Length; i++)
            {
                GlobalChampData.globalData[i] = 0;
            }
        }
    }
}
