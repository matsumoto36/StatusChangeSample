using UnityEngine;
using System.Collections;

/// <summary>
/// 取ったら一定時間速度が上がるアイテム
/// </summary>
public class ItemSpeedUp : MonoBehaviour, IItem {

	public void OnUse(Character user) {

		//10秒間速度が上がる効果を付与
		user.AttachStatus(new SpeedUp(10.0f));
	}
}
