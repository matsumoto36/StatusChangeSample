using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// スピードが上がる
/// </summary>
public class SpeedUp : StatusModifierBase {

	private float multiplySpeed = .2f;

	public SpeedUp(float time) : base("Speed Up", time) {}

	public override void OnAttach(CharacterStatus status) {
		base.OnAttach(status);

		//スピードを20%上げる
		status.MoveSpeed.MultiplierValue += multiplySpeed;
	}

	public override void OnDetach(CharacterStatus status) {
		base.OnDetach(status);

		//上げたスピードを元に戻す
		status.MoveSpeed.MultiplierValue -= multiplySpeed;
	}
}
