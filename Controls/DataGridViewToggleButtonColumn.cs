using System;
using System.Drawing;
using System.Windows.Forms;
using SmartHomeSideMenubar.DBQuery;
using static SmartHomeSideMenubar.DBQuery.DbDevicesHelper;

namespace SmartHomeSideMenubar.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    namespace SmartHomeSideMenubar.Controls
    {
        public class DataGridViewToggleButtonColumn : DataGridViewColumn
        {
            public DataGridViewToggleButtonColumn() : base(new DataGridViewToggleButtonCell()) { }
        }

        public class DataGridViewToggleButtonCell : DataGridViewCell
        {




            protected override void Paint(
              Graphics graphics, Rectangle clipBounds, Rectangle cellBounds,
              int rowIndex, DataGridViewElementStates elementState,
              object value, object formattedValue, string errorText,
              DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
              DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

                if (DataGridView == null || rowIndex < 0) return;

                // Remove existing toggle button to prevent duplicates
                foreach (Control control in DataGridView.Controls)
                {
                    if (control is ToggleButton existingButton && existingButton.Tag != null && (int)existingButton.Tag == rowIndex)
                    {
                        DataGridView.Controls.Remove(existingButton);
                        existingButton.Dispose();
                    }
                }

                // 🟢 Get status value from DataGridView and convert to bool
                bool isChecked = value is bool boolValue && boolValue;

                // Debugging Log
                Console.WriteLine($"[DEBUG] Row {rowIndex}: Loaded Status = {(isChecked ? "ON" : "OFF")} (Checked={isChecked})");

                // 🟢 Create toggle button
                ToggleButton toggleButton = new ToggleButton
                {
                    Checked = isChecked,
                    Width = cellBounds.Width - 10,
                    Height = cellBounds.Height - 5,
                    Tag = rowIndex // Store row index
                };

                toggleButton.CheckedChanged += (sender, e) =>
                {
                    bool newStatus = toggleButton.Checked;
                    DeviceStatus updatedStatus = newStatus ? DeviceStatus.ON : DeviceStatus.OFF;

                    // Update DataGridView Cell
                    DataGridView.Rows[rowIndex].Cells[ColumnIndex].Value = newStatus;

                    // Get DeviceID
                    int deviceID = Convert.ToInt32(DataGridView.Rows[rowIndex].Cells["columnDeviceID"].Value);

                    // Update Database
                    DbDevicesHelper.UpdateDeviceStatus(deviceID, updatedStatus);

                    // Debugging Log
                    Console.WriteLine($"[DEBUG] Device {deviceID} Status Updated: {updatedStatus}");

                    DataGridView.Refresh(); // Refresh UI
                };
                toggleButton.Location = new Point(cellBounds.X + 5, cellBounds.Y + 5);
                DataGridView.Controls.Add(toggleButton);
            }

        }

        }

    }

