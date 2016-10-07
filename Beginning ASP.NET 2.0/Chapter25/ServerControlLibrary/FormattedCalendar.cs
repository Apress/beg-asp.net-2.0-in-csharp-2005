using System;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Drawing;

namespace CustomControls
{
	public class FormattedCalendar : Calendar
	{
		public FormattedCalendar()
		{
			// Configure the appearance of the calendar table.
			this.CellPadding = 8;
			this.CellSpacing = 8;
			this.BackColor = Color.LightYellow;
			this.BorderStyle = BorderStyle.Groove;
			this.BorderWidth = Unit.Pixel(2);
			this.ShowGridLines = true;

			// Configure the font.
			this.Font.Name = "Verdana";
			this.Font.Size = FontUnit.XXSmall;

			// Set sothis special calendar settings.
			this.FirstDayOfWeek = FirstDayOfWeek.Monday;
			this.PrevMonthText = "<--";
			this.NextMonthText = "-->";

			// Select the current date by default.
			this.SelectedDate = DateTime.Today;
		}
		protected override void OnDayRender(TableCell cell, CalendarDay day)
		{
			// Call the base Calendar.OnDayRender method.
			base.OnDayRender(cell, day);

			if (day.IsOtherMonth)
			{
				day.IsSelectable = false;
				cell.Text = "";
			}
			else
			{
				cell.Font.Bold = true;
			}
		}

	}
}