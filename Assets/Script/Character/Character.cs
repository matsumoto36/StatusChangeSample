using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 適当なキャラクター
/// </summary>
public class Character : MonoBehaviour {

	private CharacterStatus _status;
	private List<IStatusModifiable> _attachStatusList;

	public void Start() {
		//初期ステータスを作成
		_status = new CharacterStatus(100, 5, 10);
		_attachStatusList = new List<IStatusModifiable>();
	}

	public void Update() {
		UpdateStatusModfier();
	}

	/// <summary>
	/// ステータス変化を適用する
	/// </summary>
	/// <param name="modifier"></param>
	public void AttachStatus(IStatusModifiable modifier) {
		modifier.OnAttach(_status);
		_attachStatusList.Add(modifier);
	}

	/// <summary>
	/// ステータス変化を更新する
	/// </summary>
	private void UpdateStatusModfier() {

		foreach(var item in _attachStatusList) {
			item.Update(_status);
		}

		//効果が切れたものを取り出す
		var detachList = _attachStatusList
			.Where(item => item.RemainingTime <= 0.0f);

		//取り外し処理
		foreach(var item in detachList) {
			item.OnDetach(_status);
			_attachStatusList.Remove(item);
		}
	}
}
