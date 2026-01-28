using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace TShockAPI.Models.PlayerUpdate
{
	/// <summary>
	/// Model for the third set of misc data sent with a player update packet
	/// </summary>
	public struct MiscDataSet3
	{
		public BitsByte bitsbyte;

		/// <summary>
		/// Gets or Sets the Sleeping flag on the backing field
		/// </summary>
		public bool IsSleeping
		{
			get => bitsbyte[0];
			set => bitsbyte[0] = value;
		}

		public bool AutoReuseAllWeapons
		{
			get => bitsbyte[1];
			set => bitsbyte[1] = value;
		}
		public bool ControlDownHold
		{
			get => bitsbyte[2];
			set => bitsbyte[2] = value;
		}

		public bool IsOperatingAnotherEntity
		{
			get => bitsbyte[3];
			set => bitsbyte[3] = value;
		}
		public bool ControlUseTile
		{
			get => bitsbyte[4];
			set => bitsbyte[4] = value;
		}
		public bool HasNetCameraTarget
		{
			get => bitsbyte[5];
			set => bitsbyte[5] = value;
		}
		public bool LastItemUseAttemptSuccess
		{
			get => bitsbyte[6];
			set => bitsbyte[6] = value;
		}

		/// <summary>
		/// Constructs a new instance of MiscDataSet3 with the given backing BitsByte
		/// </summary>
		/// <param name="bitsbyte"></param>
		public MiscDataSet3(BitsByte bitsbyte)
		{
			this.bitsbyte = bitsbyte;
		}
	}
}
