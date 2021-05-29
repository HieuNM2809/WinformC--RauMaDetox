using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class Constants
    {
        #region THÔNG BÁO

        public static string MESSAGE_TITLE = "Thông báo";
        public static string ERR_REQUIRED = "Vui lòng điền đủ thông tin!";
        public static string ERR_MAIL_FORMAT = "Email chưa đúng định dạng!";
        public static string LOGIN_SUCESS = "Đăng nhập thành công!";
        public static string LOGIN_FAIL = "Đăng nhập thất bại!";
        public static string PASSWORD_DIF = "Mật khẩu không trung khớp!";

        public static string MESSAGE_CONFIRM_DELETE = "Bạn có chắc muốn xóa";

        public static string DELETE_SUCESS = "Xóa thành công!";
        public static string DELETE_FAIL = "Xóa thất bại!";

        public static string ADD_SUCESS = "Thêm thành công!";
        public static string ADD_FAIL = "Thêm thất bại!";

        public static string UPDATE_SUCESS = "Cập nhật thành công!";
        public static string UPDATE_FAIL = "Cập nhật thất bại!";

        public static string IDNV_EXIST = "IDNV đã tồn tại!";

        public static string ACCOUNT_EXIST = "Tài khoản đã tồn tại!";
        public static string ACCOUNT_NOT_EXIST = "Tài khoản không tồn tại!";
        public static string ACCOUT_SUCESS = "Đăng kí thành công!";
        public static string ACCOUT_FAIL = "Đăng kí thât bại";

        public static string PASSWORD_SUCESS = "Đổi mật khẩu thành công!";
        public static string PASSWORD_FAIL = "Đổi mật khẩu thất bại!";
        public static string PASSWORD_INCORRECT = "Mật khẩu không đúng!";

        public static string LOGIN_ADMIN_SUCESS = "Đăng nhập admin thành công!";
        public static string LOGIN_NV_SUCESS = "Đăng nhập nhân viên thành công!";

        #endregion
    }
}
