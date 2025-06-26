namespace OtpInput
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string enteredOtp = OtpInput.Value;
            if (string.IsNullOrEmpty(enteredOtp))
            {
                DisplayFeedback("OTP cannot be empty.");
                OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Warning;
            }
            else if (enteredOtp != "123456")
            {
                DisplayFeedback("Incorrect OTP. Please try again.");
                OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Error;
            }
            else
            {
                DisplayFeedback("OTP verified successfully!", true);
                OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Success;
            }
        }

        private void DisplayFeedback(string message, bool isSuccess = false)
        {
            FeedbackLabel.Text = message;
            FeedbackLabel.TextColor = isSuccess ? Colors.Green : Colors.Red;
            FeedbackLabel.IsVisible = true;
        }
    }
}
