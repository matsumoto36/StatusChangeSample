using UnityEngine;
using System.Collections;

/// <summary>
/// 一定時間ステータス変更ができるベースクラス
/// </summary>
public abstract class StatusModifierBase : IStatusModifiable {

	public string ModifierName { get; private set; }
	public float RemainingTime { get; protected set; }

	public StatusModifierBase(string name, float time) {
		ModifierName = name;
		RemainingTime = time;
	}

	public virtual void OnAttach(CharacterStatus status) { }
	public virtual void OnDetach(CharacterStatus status) { }

	public virtual void Update(CharacterStatus status) {
		RemainingTime = Mathf.Max(RemainingTime - Time.deltaTime, 0.0f);
	}
}
