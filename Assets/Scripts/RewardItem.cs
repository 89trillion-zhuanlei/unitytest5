using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.UI;
public class RewardItem : MonoBehaviour
{
	[SerializeField] private Text levelNum;
	[SerializeField] private Text clickBtnText;
	[SerializeField] private Text showText;
	[SerializeField] private GameObject[] showObj;//两种状态。1：可点击 2：不可点击
	private int idx;//标记当前数据索引
	void ScrollCellIndex (int idx)
	{
		this.idx = idx;
		int num = idx * 200 + 4200;
		levelNum.text = num.ToString();
		if ((idx + 1) % 5 != 0)//不是1000的倍数
		{
			if (GlobalChampData.score >= num)//可以领取了
			{
				showObj[0].SetActive(true);
				if (GlobalChampData.globalData[idx] != 0)//已经被领取
				{
					ClickBtn();
				}
			}
			else
			{
				showObj[1].SetActive(true);
				showText.text = "暂未达到领取条件！";
			}
			
		}
		else
		{
			showObj[1].SetActive(true);
			if (GlobalChampData.score < num)
			{
				showText.text = "未达到新段位！";
			}
		}
	}

	/// <summary>
	/// 点击领取了奖励
	/// </summary>
	public void ClickBtn()
	{
		clickBtnText.text = "已领取！";
		GlobalChampData.globalData[idx] = 1;
	}
}
