/*
 * Struct phù hợp khi muốn gom một lượng nhỏ các biến có kiểu nguyên thủy (int , float...) thuộc tính lại với nhau. (đóng gói dữ liệu)
 * có thể dùng khai báo biến mà không cần thao tác đối tượng
 * biến kiểu tham trị
 * lưu ở bộ nhớ stack
 */

public struct Product
{
	public enum HocLuc
	{
		Kem,
		TrungBinh,
		Kha,
		Gioi
	}

	private string name;
	public decimal price;

	public string Name { get => name; set => name = value; }
	public string Description { get; set; }

	public Product(string _name)
	{
		// Trong cấu trúc có bao nhiêu trường dữ liệu, thuộc tính
		// phải khởi tạo hết trong hàm (Thiếu sẽ lỗi)
		name = _name;
		price = 1000;
		Description = "FPT shop";
	}
	public override string ToString()
	{
		return $"{Name} : {price}$";
	}
}