ỨNG DỤNG HỆ THỐNG TÌM ĐƯỜNG ĐI NGẮN NHẤT TRONG TRUNG TÂM THƯƠNG MẠI
Thuật toán Floyd-Warshall được áp dụng để xây dựng một ứng dụng mô phỏng hệ thống tìm đường đi ngắn nhất trong trung tâm thương mại. Ứng dụng cho phép người dùng xác định và lựa chọn hai gian hàng bất kỳ, từ đó hệ thống sẽ tự động tính toán và hiển thị lộ trình tối ưu nhất dựa trên vị trí thực tế của các gian hàng trong không gian hai chiều.

CẤU TRÚC
Dự án được xây dựng theo mô hình tách biệt giữa logic xử lý dữ liệu và giao diện người dùng, giúp mã nguồn dễ quản lý, dễ mở rộng và thuận tiện cho việc bảo trì. Cụ thể, cấu trúc chương trình gồm các thành phần chính sau:
1. Lớp MAPNODE: Lớp này dùng để lưu trữ thông tin cơ bản của một địa điểm dựa trên tên cửa hàng, tọa độ x, tọa độ y. Xây dựng dưới dạng Properties để đảm bảo tính đóng gói và an toàn dữ liệu.
2. Lớp MAP (Đồ thị và thuật toán): Lớp này chịu trách nhiệm việc quản lý danh sách các nút và ma trận kề. Triển khai thuật toán Floyd-Warshall và các logic tính toán chính của hệ thống.
3. Lớp Form1 (Giao diện): Lớp này đảm nhiệm việc xử lý các sự kiện từ người dùng như chọn điểm bắt đầu, điểm đến và nhấn nút tìm đường. Hiển thị giao diện một cách trực quan qua việc vẽ các đường đi thông qua các gian hàng tương ứng lên PictureBox dựa trên tọa độ đã xác định.


HƯỚNG DẪN CÀI ĐẶT VÀ SỬ DỤNG
1. Chuẩn bị.
Phần mềm: Visual Studio 2022
Công nghệ sử dụng: .NET Framework (Windows Forms)
Ngôn ngữ: C#
2. Chạy chương trình.
-Mở tệp solution MALLMAP.sln của dự án trong Visual Studio 2022.
-Tiến hành chạy chương trình bằng cách nhấn nút Start hoặc phím F5.
3. Sử dụng ứng dụng.
Sau khi khởi động chương trình, giao diện chính sẽ hiển thị với các thành phần sau:
	+START: ComboBox cho phép người dụng lựa chọn gian hàng để xuất phát.
	+END: ComboBox cho phép người dùng lựa chọn gian hàng mà người dùng muốn đi đến.
	+FIND: Nút thực hiện chức năng tìm đường đi ngắn nhất giữa hai gian hàng đã chọn.
4. Kết quả hiển thị.
Sau khi nhấn nút FIND, hệ thống sẽ:
-Tính toán đường đi ngắn nhất bằng thuật toán Floyd–Warshall
-Trực quan hóa kết quả bằng cách vẽ một đường màu đỏ nối giữa các gian hàng tạo thành một đường đi tối ưu nhất cho người dùng.
