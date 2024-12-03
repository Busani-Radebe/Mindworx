using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace MindworxLaptopTrackingApp
{
    public partial class notification : Form
    {
        private DateTime reminderDateTime; // Variable to store the reminder time
        private System.Timers.Timer reminderTimer; // Timer for notifications

        public notification()
        {
            InitializeComponent();

            // Configure the DateTimePicker for 24-hour time and detailed date
            dateTimePickerReminder.Format = DateTimePickerFormat.Custom;
            dateTimePickerReminder.CustomFormat = "dddd, dd MMMM yyyy, HH:mm"; // 24-hour time format with day and date
            dateTimePickerReminder.ShowUpDown = true; // Spinner for time selection

            // Change the form background to OrangeRed
            this.BackColor = Color.OrangeRed;
        }

        // Event triggered when the "Set Reminder" button is clicked
        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            // Capture the selected date and time from the DateTimePicker
            reminderDateTime = dateTimePickerReminder.Value;

            // Ensure the date and time is in the future
            if (reminderDateTime > DateTime.Now)
            {
                MessageBox.Show($"Reminder set for: {reminderDateTime:dddd, dd MMMM yyyy, HH:mm}", "Notification Reminder");
                InitializeReminder(); // Initialize the reminder timer
            }
            else
            {
                MessageBox.Show("Please select a date and time in the future.", "Notification Reminder");
            }
        }

        // Initialize the reminder timer
        private void InitializeReminder()
        {
            try
            {
                // Stop and dispose of any existing timer
                if (reminderTimer != null)
                {
                    reminderTimer.Stop();
                    reminderTimer.Dispose();
                }

                // Initialize a new timer that ticks every second
                reminderTimer = new System.Timers.Timer(1000);
                reminderTimer.Elapsed += CheckReminder; // Event when timer elapses
                reminderTimer.AutoReset = true; // The timer will keep running until stopped
                reminderTimer.Start();

                MessageBox.Show("Reminder timer initialized successfully!", "Notification Reminder");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing the reminder: {ex.Message}", "Notification Reminder");
            }
        }

        // Check if the current time matches or exceeds the reminder time
        private void CheckReminder(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (DateTime.Now >= reminderDateTime)
                {
                    reminderTimer.Stop(); // Stop the timer after the reminder triggers
                    DisplayNotification(); // Show the notification
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during reminder check: {ex.Message}", "Notification Reminder");
            }
        }

        // Display a notification to the user
        private void DisplayNotification()
        {
            try
            {
                // Ensure the UI thread is used
                Invoke(new Action(() =>
                {
                    MessageBox.Show("REMINDER: YOUR LAPTOP IS DUE!", "Notification Reminder");
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying the notification: {ex.Message}", "Notification Reminder");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

       }

       private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}