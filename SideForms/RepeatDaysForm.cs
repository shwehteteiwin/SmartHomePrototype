using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class RepeatDaysForm : Form
{
    private CheckedListBox chkDays;
    public string SelectedDays { get; private set; } = "";

    public RepeatDaysForm()
    {
        this.Text = "Repeat Days";
        this.Size = new System.Drawing.Size(300, 200);

        chkDays = new CheckedListBox
        {
            Items = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" },
            Location = new System.Drawing.Point(20, 20),
            Size = new System.Drawing.Size(200, 100)
        };

        Button btnOk = new Button { Text = "OK", Location = new System.Drawing.Point(80, 130) };
        btnOk.Click += (s, e) =>
        {
            SelectedDays = string.Join(",", chkDays.CheckedItems.Cast<string>());
            this.DialogResult = DialogResult.OK;
            this.Close();
        };

        this.Controls.Add(chkDays);
        this.Controls.Add(btnOk);
    }
}

