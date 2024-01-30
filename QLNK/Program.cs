namespace QLNK
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Hiển thị message box để chọn phiên bản
            DialogResult result = MessageBox.Show("Chọn phiên bản: Yes cho phiên bản chuẩn, No cho phiên bản lỗi!", "Chọn Phiên Bản",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý sự lựa chọn từ message box
            switch (result)
            {
                case DialogResult.Yes:
                    ConnectionManager.SelectedVersion = "ValidatedVersion";
                    break;
                case DialogResult.No:
                    ConnectionManager.SelectedVersion = "FalseVersion";
                    break;
                case DialogResult.Cancel:
                    ConnectionManager.SelectedVersion = "Default";
                    break;
                default:
                    // Xử lý trường hợp khác nếu cần thiết
                    break;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}