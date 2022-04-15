namespace CsharpCore.AccessModifier
{
	// Không chỉ định từ khóa cụ thể nên class có phạm vi truy cập là internal
	class SinhVien : AbstractClass
	{
		/*
		 *  Các thuộc tính đều mang phạm vi là private
		 *  => chỉ sử dụng ở trong nội bộ class (không sử dụng ở bên ngoài đc)
		 */
		#region Private Field
		private string maSV;
		private string hoTen;
		private double diemToan;
		private double diemVan;
		#endregion

		#region
		public string MaSV
		{
			get { return this.maSV; }
			set { this.maSV = ValidateString("Luc Van Tien", value, false, 4); }
		}
		#endregion
		/*
		 * Phương thức có phạm vi là public nên có thể sử dụng được ở bên ngoài
		 */
		public void PrintTTDiemTB()
		{
			double DTB = (diemToan + diemVan) / 2;
			Console.WriteLine("Sinh vien " + hoTen + " có điểm TB là: " + DTB);
		}
	}
}
