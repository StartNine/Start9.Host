﻿using System.Windows;
using System.Windows.Automation;
//using Start9.Api.Modules; //Why did this break
using Start9.Windows;

namespace Start9
{
	/// <summary>
	///     Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			Globals.SettingsWindow = new SettingsWindow();
            //Module.Poke(); //Why did this also break

            Exit += (sender, args) => { Automation.RemoveAllEventHandlers(); };
		}
	}

	public static class TaskbarTools
	{
		public enum TaskbarGroupingMode
		{
			Combine,
			CombineWhenFull,
			NeverCombine
		}

		public enum TaskbarGroupSideTabMode
		{
			None,
			GroupTabSingle,
			GroupTabDouble,
			JumpListButton
		}

		public enum TaskbarGroupStatus
		{
			Idle,
			Running,

			/// <summary>
			///     Look at me, I'm orange!
			/// </summary>
			LookAtMeImOrange,
			Progress,
			ProgressPaused,
			ProgressRekt,
			ProgressIdekAnymore
		}

		public const System.Int32 SwShownormal = 1;
		public const System.Int32 SwShowminimized = 2;
		public const System.Int32 SwShowmaximized = 3;

		public const System.Int32 GwlStyle = -16;
		public const System.Int32 GwlExstyle = -20;
		public const System.Int32 Taskstyle = 0x10000000 | 0x00800000;
		public const System.Int32 WsExToolwindow = 0x00000080;
	}
}