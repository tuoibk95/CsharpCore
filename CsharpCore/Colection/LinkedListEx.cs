namespace CsharpCore.Colection
{
	/// <summary>
	/// Giống như array, LinkedList là 1 cấu trúc dữ liệu tuyến tính.
	/// Không giống như mảng, các phần tử danh sách được liên kết không được lưu trữ tại một vị trí liền kề, các phần tử được liên kết bằng con trỏ.
	/// Chúng bao gồm các node được kết nối, tại đây mỗi node lưu trũ dữ liệu và địa chỉ của node tiếp theo
	/// 
	/// Sử dụng khi yêu cầu insert / delete rất nhiều (stack và queue thêm vào và bớt đi liên tục nên dùng linked list rất tốt)
	/// Các node nằm ở nhiều chỗ khác nhau và rãi rác khắp mọi nơi, và trong node có địa chỉ của node tiếp theo 
	/// => k nhất thiết nằm trên 1 thanh ghi(thoải mái thêm xóa sửa)
	/// 
	/// </summary>
	public class LinkedListEx
	{
		#region why linked list
		/*
		 * Why Linked List? 
		 * Mảng có thể được sử dụng để lưu trữ dữ liệu tuyến tính có kiểu tương tự. Nhưng mảng có những hạn chế sau:
			Kích thước của mảng là cố định. Vì vậy chúng ta phải biết được giới hạn trên của số phần tử (bộ nhớ đc phân bổ bằng giới hạn trên bất kể mức sử dụng)
			Chèn một phần tử mới/xóa 1 phần tử hiện có trong 1 mảng rất tốn kém
			Trong 1 hệ thống, nếu maintain 1 sorted list của IDs trong 1 mảng id[] = [1000, 1010, 1050, 2000, 2040].
			nếu muốn chèn mới ID 1005, sau đó giữ nguyên thứ tự sắp xếp, phải di chuyển tất cả các phần tử sau 1000 (k bao gồm 1000). 
			- Việc xóa 1010 in id[], mọi phần tử sau 1000 phải được di chuyển do có quá nhiều công việc đang được thực hiện ảnh hưởng đến hiệu quả của mã
		 */
		#endregion

		#region Ưu nhược điểm so với array
		// Ưu điểm so với array: Dynamic array, dễ chèn/xóa
		// Hạn chế: Truy cập ngẫu nhiên là không được phép. Chúng ta phải truy cập các phần tử một cách tuần tự bắt đầu từ node đầu tiên
		//		=> không thể thực hiện tìm binary search với các DS được liên kết một cách hiệu quả với cách triển khai mặc định của nó
		// Không gian bộ nhớ bổ sung cho một con trỏ được yêu cầu với mỗi phần tử của danh sách
		// Không thân thiện với cache, vì các phần tử mảng là các vị trí liền kề, nên có vị trí tham chiếu không có trong trường hợp danh sách được liên kết.
		#endregion

		#region Types of linked lists
		/*
		 * Simple linked list: Có thể di chuyển hoặc duyệt danh sách được liên kết theo 1 hướng duy nhất
		 * Double linked list: Có thể di chuyển hoặc duyệt danh sách qua 2 hướng (Forward and Backward)
		 * Circular linked list: node cuối cùng của linked list chứa liên kết của node đầu tiên/ 
		 *						node đầu tiên của linked list được liên kết trong con trỏ tiếp theo của nó và node đầu tiên
		 *						node đầu tiên chứa liên kết của node cuối cùng của linked list trong con trỏ trước của nó.
		 */
		#endregion

		// Node đầu tiên của linked list
		// Sẽ là 1 đối tượng kiểu node (defaut là null)
		Node head;
		class Node
		{
			int data;
			Node next;

			Node(int d)
			{
				// Constructor tạo 1 new node
				data = d;
			}
		}
	}
}
