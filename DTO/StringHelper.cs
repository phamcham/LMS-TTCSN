using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {

	public class StringHelper {
		public static string serverName = "";

		public class KeyDisplayPair {
			public string Key { get; }
			public string Display { get; }

			public KeyDisplayPair() {
			}

			public KeyDisplayPair(string key, string display) {
				Key = key;
				Display = display;
			}

			public override bool Equals(object obj) {
				if (obj == null) {
					return false;
				}

				return Key == Parse(obj).Key && Display == Parse(obj).Display;
			}

			public override int GetHashCode() {
				return base.GetHashCode();
			}

			public static KeyDisplayPair Parse(object obj) {
				if (obj.Equals(DBNull.Value)) return new KeyDisplayPair();
				return (KeyDisplayPair)obj;
			}
		}

		static public class Availability {

			public static KeyDisplayPair Enable {
				get => new KeyDisplayPair("enable", "Cấp phép");
			}

			public static KeyDisplayPair Disable {
				get => new KeyDisplayPair("disable", "Vô hiệu hoá");
			}

			public static KeyDisplayPair GetByKey(string availability) {
				if (Enable.Key.Equals(availability)) return Enable;
				return Disable;
			}
		}

		static public class ActionStatus {

			public static KeyDisplayPair Active {
				get => new KeyDisplayPair("active", "Hoạt động");
			}

			public static KeyDisplayPair Blocked {
				get => new KeyDisplayPair("blocked", "Bị khoá");
			}

			public static KeyDisplayPair GetByKey(string actionStatus) {
				if (Active.Key.Equals(actionStatus)) return Active;
				return Blocked;
			}
		}

		static public class IsExist {

			public static KeyDisplayPair Yes {
				get => new KeyDisplayPair("exist", "Còn");
			}

			public static KeyDisplayPair No {
				get => new KeyDisplayPair("lost", "Bị Mất");
			}

			public static KeyDisplayPair GetByKey(string isExist) {
				if (Yes.Key.Equals(isExist)) return Yes;
				return No;
			}
		}

		static public class IsLent {

			public static KeyDisplayPair Yes {
				get => new KeyDisplayPair("lent", "Đã được mượn");
			}

			public static KeyDisplayPair No {
				get => new KeyDisplayPair("notlent", "Chưa được mượn");
			}

			public static KeyDisplayPair GetByKey(string isLent) {
				if (Yes.Key.Equals(isLent)) return Yes;
				return No;
			}
		}

		static public class Gender {

			public static KeyDisplayPair Male {
				get => new KeyDisplayPair("male", "Nam");
			}

			public static KeyDisplayPair Female {
				get => new KeyDisplayPair("female", "Nữ");
			}

			public static KeyDisplayPair GetByKey(string gender) {
				if (Male.Key.Equals(gender)) return Male;
				return Female;
			}
		}

		static public class Role {

			public static KeyDisplayPair Admin {
				get => new KeyDisplayPair("admin", "Quản trị viên");
			}

			public static KeyDisplayPair Librarian {
				get => new KeyDisplayPair("librarian", "Thủ thư");
			}

			public static KeyDisplayPair GetByKey(string role) {
				if (Admin.Key.Equals(role)) return Admin;
				return Librarian;
			}
		}

		static public class Notification {
			public static string Success = "Thành công";
			public static string SomethingWentWrong = "Có lỗi xảy ra";
		}

		static public class HistoryStatus {

			public static KeyDisplayPair Add {
				get => new KeyDisplayPair("add", "Thêm");
			}

			public static KeyDisplayPair Update {
				get => new KeyDisplayPair("update", "Cập nhật");
			}

			public static KeyDisplayPair All {
				get => new KeyDisplayPair("all", "Tất cả");
			}

			public static KeyDisplayPair Lend {
				get => new KeyDisplayPair("lend", "Cho mượn");
			}

			public static KeyDisplayPair Return {
				get => new KeyDisplayPair("return", "Trả sách");
			}

			public static KeyDisplayPair GetByKey(string historyStatus) {
				if (Add.Key.Equals(historyStatus)) return Add;
				if (Update.Key.Equals(historyStatus)) return Update;
				if (All.Key.Equals(historyStatus)) return All;
				if (Lend.Key.Equals(historyStatus)) return Lend;
				return Return;
			}
		}
	}
}