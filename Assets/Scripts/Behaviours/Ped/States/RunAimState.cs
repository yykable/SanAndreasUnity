using UnityEngine;
using SanAndreasUnity.Utilities;
using SanAndreasUnity.Importing.Animation;

namespace SanAndreasUnity.Behaviours.Peds.States
{

	public class RunAimState : BaseAimState
	{
		public override AnimId aimWithArm_LowerAnim { get { return m_ped.CurrentWeapon.RunAnim; } }


		public override void OnBecameActive ()
		{
			base.OnBecameActive ();
		//	m_ped.PlayerModel.PlayAnim (AnimGroup.Gun, AnimIndex.run_armed);
		}

	}

}
