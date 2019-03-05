using UnityEngine;
using System.Collections;

/// <summary>
/// アイテムとして使える
/// </summary>
public interface IItem {

	//使った時
	void OnUse(Character user);

}
