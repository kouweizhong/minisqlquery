using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniSqlQuery.Core.Commands
{
	public class ConvertTextToLowerCaseCommand
		: CommandBase
	{
		public ConvertTextToLowerCaseCommand()
			: base("Convert to 'lower case' text")
		{
			ShortcutKeys = Keys.Control | Keys.U;
			//SmallImage = ImageResource.;
		}

		public override bool Enabled
		{
			get
			{
				return HostWindow.ActiveChildForm as IEditor != null;
			}
		}

		public override void Execute()
		{
			IEditor editor = ActiveFormAsEditor;
			if (Enabled && editor.SelectedText.Length > 0)
			{
				editor.InsertText(editor.SelectedText.ToLower());
			}
		}
	}
}