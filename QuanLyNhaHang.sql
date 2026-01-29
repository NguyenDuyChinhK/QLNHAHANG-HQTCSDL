CREATE Database QuanLyNhaHang

Use QuanLyNhaHang


	CREATE TABLE tb_BANAN
	(
		idBan INT IDENTITY PRIMARY KEY,
		TenBan NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
		TrangThai NVARCHAR(100) NOT NULL DEFAULT N'Trống'	
	)

	CREATE TABLE tb_TAIKHOAN
	(
	
		TenDangNhap NVARCHAR(100) PRIMARY KEY,	
		MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
		TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'Ten',
		LoaiTK INT NOT NULL  DEFAULT 0 
	)


	CREATE TABLE tb_LOAIMON
	(
		idLM INT IDENTITY PRIMARY KEY,
		TenLoai NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
	)


	CREATE TABLE tb_MONAN
	(
		idMa INT IDENTITY PRIMARY KEY,
		TenMon NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
		idLM INT NOT NULL,
		Gia FLOAT NOT NULL DEFAULT 0
	
		FOREIGN KEY (idLM) REFERENCES tb_LOAIMON(idLM)
	)


	CREATE TABLE tb_HOADON
	(
		idHD INT IDENTITY PRIMARY KEY,
		Ngay DATE NOT NULL DEFAULT GETDATE(),
		idBan INT NOT NULL,
		TrangThai INT NOT NULL DEFAULT 0,
		GiamGia int DEFAULT 0,
		FOREIGN KEY (idBan) REFERENCES tb_BANAN(idBan)
	)


	CREATE TABLE tb_TTHOADON
	(
		id INT IDENTITY PRIMARY KEY,
		idHD INT NOT NULL,
		idMA INT NOT NULL,
		SoLuong INT NOT NULL DEFAULT 0,
		FOREIGN KEY (idHD) REFERENCES tb_HOADON(idHD),
		FOREIGN KEY (idMA) REFERENCES tb_MONAN(idMA)
	)


DROP TABLE tb_TTHOADON;
DROP TABLE tb_HOADON;
DROP TABLE tb_MONAN;
DROP TABLE tb_LOAIMON;
DROP TABLE tb_BANAN;
DROP TABLE tb_TAIKHOAN;

Insert into tb_TAIKHOAN (TenDangNhap, MatKhau, TenHienThi, LoaiTK) VALUES
('Admin1', 'admin123', 'Yasuo', 1),
('Staff1', 'staff123', 'Mei', 0);


DECLARE @i int = 1
WHILE @i <= 20 
begin
	Insert into tb_BANAN (TenBan) VALUES (N'Bàn ' + CAST(@i as char(2)))
	SET @i+=1
end


INSERT INTO tb_LOAIMON (TenLoai) VALUES 
(N'Hải sản'), 
(N'Đồ nướng'), 
(N'Chay'), 
(N'Món lẩu'), 
(N'Bánh ngọt'), 
(N'Đồ uống'), 
(N'Gà'), 
(N'Mì - Phở'), 
(N'Cơm'), 
(N'Pizza'), 
(N'Kem tráng miệng'), 
(N'Món Âu');

INSERT INTO tb_MONAN (TenMon, idLM, Gia) VALUES 
(N'Tôm hùm hấp', 1, 300000), 
(N'Ghẹ rang me', 1, 250000), 
(N'Cua sốt ớt', 1, 270000),
(N'Bò nướng tảng', 2, 320000), 
(N'Mực nướng sa tế', 2, 220000), 
(N'Sườn nướng BBQ', 2, 280000),
(N'Đậu hũ chiên xù', 3, 60000), 
(N'Lẩu nấm chay', 3, 150000), 
(N'Rau củ xào chay', 3, 80000),
(N'Lẩu thái hải sản', 4, 350000), 
(N'Lẩu bò nhúng dấm', 4, 300000), 
(N'Lẩu gà lá é', 4, 320000),
(N'Bánh tiramisu', 5, 50000), 
(N'Bánh cupcake', 5, 40000), 
(N'Bánh bông lan trứng muối', 5, 45000),
(N'Cà phê sữa đá', 6, 30000), 
(N'Trái cây dầm', 6, 45000), 
(N'Sinh tố xoài', 6, 40000),
(N'Gà nướng muối ớt', 7, 260000), 
(N'Gà luộc lá chanh', 7, 220000), 
(N'Chân gà sả tắc', 7, 120000),
(N'Phở bò đặc biệt', 8, 60000), 
(N'Mì cay cấp độ 7', 8, 55000), 
(N'Bún chả Hà Nội', 8, 65000),
(N'Cơm gà xối mỡ', 9, 55000), 
(N'Cơm sườn nướng', 9, 60000), 
(N'Cơm chiên Dương Châu', 9, 50000),
(N'Pizza hải sản', 10, 250000), 
(N'Pizza bò sốt BBQ', 10, 260000), 
(N'Pizza thập cẩm', 10, 240000),
(N'Kem dừa', 11, 45000), 
(N'Kem sầu riêng', 11, 50000), 
(N'Kem socola', 11, 40000),
(N'Mì Ý sốt bò bằm', 12, 180000), 
(N'Steak bò Mỹ', 12, 350000), 
(N'Gà cuộn phô mai', 12, 280000);

INSERT INTO tb_HOADON (Ngay, idBan, TrangThai, GiamGia)
VALUES
('2024-01-03', 1, 1, 5),
('2024-02-15', 2, 0, 10),
('2024-03-20', 3, 1, 15),
('2024-04-25', 4, 1, 20),
('2024-05-30', 5, 0, 25),
('2024-06-10', 1, 1, 5),
('2024-07-15', 2, 1, 0),
('2024-08-20', 3, 0, 30),
('2024-09-25', 4, 1, 10),
('2024-10-30', 5, 0, 15),
('2024-01-05', 6, 1, 10),
('2024-02-10', 7, 1, 5),
('2024-02-20', 8, 0, 15),
('2024-03-15', 9, 1, 20),
('2024-03-25', 10, 0, 10),
('2024-04-10', 11, 1, 5),
('2024-04-15', 12, 1, 25),
('2024-05-01', 13, 0, 0),
('2024-05-20', 14, 1, 30),
('2024-06-05', 15, 0, 15),
('2024-06-18', 16, 1, 20),
('2024-07-10', 17, 1, 10),
('2024-07-25', 18, 0, 5),
('2024-08-05', 19, 1, 20),
('2024-08-18', 20, 1, 0),
('2024-09-10', 6, 1, 10),
('2024-09-25', 7, 0, 15),
('2024-10-05', 8, 1, 20),
('2024-10-18', 9, 1, 5),
('2024-11-10', 10, 0, 10),
('2024-11-25', 11, 1, 0),
('2024-12-05', 12, 1, 30),
('2024-12-20', 13, 0, 15),
('2025-01-05', 14, 1, 20),
('2025-01-10', 15, 0, 10),
('2025-01-15', 16, 1, 5),
('2025-01-20', 17, 1, 25),
('2025-01-25', 18, 0, 0),
('2025-01-30', 19, 1, 10),
('2025-01-31', 20, 1, 15);


INSERT INTO tb_TTHOADON (idHD, idMA, SoLuong)
VALUES
(31, 1, 2), (31, 2, 3), (31, 4, 1),
(32, 2, 5), (32, 3, 2), (32, 5, 3),
(33, 1, 3), (33, 3, 4), (33, 6, 1),
(34, 4, 5), (34, 5, 2), (34, 7, 3),
(35, 1, 2), (35, 2, 3), (35, 3, 4),
(36, 5, 1), (36, 6, 2), (36, 7, 3),
(37, 1, 4), (37, 2, 5), (37, 3, 2),
(38, 4, 3), (38, 5, 1), (38, 6, 4),
(39, 7, 2), (39, 1, 3), (39, 2, 5),
(40, 3, 4), (40, 4, 3), (40, 5, 1),
(1, 1, 3), (1, 2, 2), (1, 3, 4),
(2, 1, 5), (2, 4, 2), (2, 5, 3),
(3, 2, 1), (3, 3, 2), (3, 6, 3), (3, 7, 4),
(4, 1, 2), (4, 2, 3), (4, 4, 5),
(5, 3, 1), (5, 5, 2), (5, 6, 3),
(6, 1, 4), (6, 2, 1), (6, 7, 5),
(7, 3, 2), (7, 4, 3), (7, 5, 4),
(8, 6, 1), (8, 7, 2), (8, 1, 5),
(9, 2, 3), (9, 3, 4), (9, 5, 1),
(10, 6, 2), (10, 7, 3), (10, 1, 4),
(11, 2, 1), (11, 3, 2), (11, 4, 3),
(12, 5, 5), (12, 6, 2), (12, 7, 1),
(13, 1, 3), (13, 2, 4), (13, 5, 2),
(14, 6, 1), (14, 7, 3), (14, 4, 2),
(15, 5, 4), (15, 6, 2), (15, 7, 5),
(16, 1, 1), (16, 2, 3), (16, 3, 4),
(17, 4, 2), (17, 5, 1), (17, 6, 5),
(18, 7, 3), (18, 1, 2), (18, 2, 4),
(19, 3, 5), (19, 4, 1), (19, 5, 3),
(20, 6, 4), (20, 7, 2), (20, 1, 3),
(21, 2, 4), (21, 3, 5), (21, 4, 2),
(22, 5, 1), (22, 6, 3), (22, 7, 4),
(23, 1, 5), (23, 2, 2), (23, 3, 4),
(24, 4, 3), (24, 5, 5), (24, 6, 1),
(25, 7, 3), (25, 1, 4), (25, 2, 2),
(26, 3, 1), (26, 4, 5), (26, 5, 2),
(27, 6, 4), (27, 7, 2), (27, 1, 3),
(28, 2, 5), (28, 3, 4), (28, 4, 3),
(29, 5, 1), (29, 6, 2), (29, 7, 5),
(30, 1, 4), (30, 2, 3), (30, 3, 2);

-- thủ tục đăng nhập
CREATE proc PROC_DangNhap
@TenDangNhap nvarchar(100),
@MatKhau nvarchar (100)
as begin
	select * from tb_TaiKhoan where TenDangNhap =@TenDangNhap AND MatKhau = @MatKhau
END

exec PROC_DangNhap 'Admin1', 'admin123'
drop proc PROC_DangNhap



-- proc hiển thị danh sách món trong hóa đơn hiện tại của bàn
create proc proc_DSMonAn
@idBan int
as
select TenMon, soluong, Gia, dbo.f_ThanhTien(tthd.idHD,tthd.idMA) as ThanhTien from tb_TTHOADON tthd
join tb_HOADON hd on hd.idHD = tthd.idHD
join tb_MONAN ma on tthd.idMa = ma.idma
where TrangThai = 0 and idBan = @idBan
 
exec proc_DSMonAn '1'
drop proc proc_DSMonAn


-- thủ tục tạo hóa đơn theo bàn
create proc proc_TaoHoaDon
@idBan int
as
begin
	Insert tb_HOADON (Ngay, idBan, TrangThai) VALUES (Getdate(), @idBan, 0)
end

drop proc_TaoHoaDon

-- thủ thục tạo thông tin hóa đơn
create proc proc_TaoTTHoaDon
@idHD int, @idMA int, @soLuong int
as begin
	DECLARE @isexistsTTHoaDon int
	DECLARE @sl int = 1
	select @isexistsTTHoaDon = id, @sl = SoLuong  from tb_TTHOADON where idHD = @idHD and idMA = @idMA
	if(@isexistsTTHoaDon >0 )
	begin
		DECLARE @slMoi int = @soLuong + @sl
		IF(@slMoi >0)
			Update tb_TTHOADON set SoLuong = @slMoi where idMA = @idMA
		ELSE
			DELETE tb_TTHOADON where idHD = @idHD and idMA = @idMA
	end
	else
	begin
		if(@soLuong >0)
			Insert tb_TTHOADON (idHD , idMA, SoLuong) VALUES (@idHD, @idMA, @soLuong)
	end
end

drop proc proc_TaoTTHoaDon

-- thủ tục thay đổi mật khẩu
create proc proc_ThayDoiMatKhau
@TenDangNhap Nvarchar(100), @TenHienThi Nvarchar(100), @MatKhau Nvarchar(100), @MatKhauMoi Nvarchar(100)
as begin 
	declare @ktMatKhau int = 0
	select @ktMatKhau = count(*) from tb_TAIKHOAN where TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau

	if (@ktMatKhau = 1)
	begin
		iF(@MatKhauMoi = Null or @MatKhauMoi = '')
			Update tb_TaiKhoan set TenHienThi = @TenHienThi where TenDangNhap =@TenDangNhap
		else
			UPDATE tb_TaiKhoan set TenHienThi = @TenHienThi, MatKhau = @MatKhauMoi where TenDangNhap = @TenDangNhap
	end
end

select * from tb_monan	
drop proc proc_ThayDoiMatKhau


-- hàm tính thành tiền của 1 món trong trong hóa đơn
create function f_ThanhTien (@idHD int, @idMA int)
returns float
as begin
	declare @ThanhTien float
	select @ThanhTien = Gia * SoLuong from tb_HOADON hd
	join tb_TTHOADON tthd on hd.idHD = tthd.idHD
	join tb_MONAN ma on tthd.idMA = ma.idMA
	where ma.idMA = @idMA and @idHD = @idHD
	return @ThanhTien
end

drop function f_ThanhTien

-- hàm tính tổng tiền của 1 hóa đơn
create function f_TongTien(@idHD int)
returns float
as begin 
	declare @TongTien float
	declare @GiamGia float
	select @GiamGia = 0.01 * GiamGia from tb_HOADON where idHD = @idHD
	select @TongTien = SUM(dbo.f_ThanhTien(idHD,idMA)) *  (1-@GiamGia) from tb_TTHOADON 
	where idHD = @idHD 
	group by idHD 
	return @TongTien
end

select * from tb_LoaiMon

drop function f_TongTIen

-- view hiển thị thông tin của hóa đơn 
CREATE VIEW view_ThongKeDoanhThuTheoHoaDon 
AS
	SELECT hd.idHD ,hd.Ngay,hd.GiamGia,dbo.f_TongTien(hd.idHD) AS TongTien
	FROM tb_HOADON hd

drop view view_ThongKeDoanhThuTheoHoaDon


-- view hiển thị doanh thu theo ngay
CREATE VIEW view_ThongKeDoanhThuTheoNgay 
AS
	SELECT hd.Ngay,SUM(dbo.f_TongTien(hd.idHD)) AS TongDoanhThu FROM tb_HOADON hd
	WHERE hd.TrangThai = 1 
	GROUP BY hd.Ngay;

drop view view_ThongKeDoanhThuTheoNgay 

-- view hiển thị doanh thu theo Ban
CREATE VIEW view_ThongKeDoanhThuTheoBan 
AS
	SELECT b.idBan,b.TenBan,SUM(dbo.f_TongTien(hd.idHD)) AS TongDoanhThu
	FROM tb_BANAN b JOIN tb_HOADON hd ON b.idBan = hd.idBan
	WHERE hd.TrangThai = 1
	GROUP BY b.idBan, b.TenBan;

	drop view view_ThongKeDoanhThuTheoBan 

-- tạo trigger cập nhật trạng thái bàn
create trigger trig_CapNhatBanCoHoaDon
on tb_TTHOADON FOR INSERT, UPDATE
as begin
	Declare @idHD int
	SELECT @idHD = idHD from inserted
	DECLARE @idBan int	
	select @idBan = idBan from tb_HOADON where idHD = @idHD and Trangthai = 0
	UPDATE tb_BANAN set TRANGTHAI = N'Có người' where idBan = @idBan
end

drop trigger trig_CapNhatBanCoHoaDon

CREATE PROCEDURE dbo.ThongKeDoanhThuTheoMonAn
AS
BEGIN
    -- Trả kết quả thống kê doanh thu cho từng món ăn, bao gồm giảm giá
    SELECT m.TenMon,
           SUM(t.SoLuong * m.Gia * (1 - ISNULL(h.GiamGia, 0) / 100.0)) AS TongDoanhThu
    FROM tb_MONAN m
    JOIN tb_TTHOADON t ON m.idMa = t.idMA
    JOIN tb_HOADON h ON t.idHD = h.idHD
    GROUP BY m.TenMon
    ORDER BY TongDoanhThu DESC;
END;
drop proc dbo.ThongKeDoanhThuTheoMonAn
exec dbo.ThongKeDoanhThuTheoMonAn

create trigger trig_CapNhatHoaDon
on tb_HoaDon for UPDATE
AS BEGIN
	 DECLARE @idHD INT
	 SELECT @idHD = idHD from inserted

	 DECLARE @idBan int
	 SELECT @idBan = idBan from tb_HOADON where idHD = @idHD

	 DECLARE @sl int
	 SELECT @sl = count(*) from tb_HOADON	where idBan = @idBan and TrangThai = 0
	 if(@sl = 0 )
		UPDATE tb_BANAN set TrangThai = N'Trống' where idBan = @idBan
END
	
drop trigger trig_CapNhatHoaDon


select * from tb_taikhoan

-- cursor thống kê số lượng món ăn bán được theo tháng
CREATE PROC  proc_ThongKeSoLuongMonAnTheoThang
AS BEGIN
    DECLARE @Thang INT;
    DECLARE @Nam INT;
    DECLARE @TenMon NVARCHAR(100);
    DECLARE @SoLuong INT;
    DECLARE @idMA INT;
    DECLARE @ThanhTien FLOAT;

    DECLARE SoLuongMonAnCursor CURSOR FOR
    SELECT MONTH(h.Ngay), YEAR(h.Ngay), t.idMA, m.TenMon, SUM(t.SoLuong)
    FROM tb_HOADON h
    JOIN tb_TTHOADON t ON h.idHD = t.idHD
    JOIN tb_MONAN m ON t.idMA = m.idMA
    GROUP BY MONTH(h.Ngay), YEAR(h.Ngay), t.idMA, m.TenMon;

    OPEN SoLuongMonAnCursor;

    FETCH NEXT FROM SoLuongMonAnCursor INTO @Thang, @Nam, @idMA, @TenMon, @SoLuong;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @ThanhTien = dbo.f_ThanhTien((SELECT TOP 1 idHD FROM tb_HOADON WHERE idBan IN (SELECT idBan FROM tb_HOADON )), @idMA);

        PRINT N'Tháng: ' + CAST(@Thang AS NVARCHAR(2)) + N' | Năm: ' + CAST(@Nam AS NVARCHAR(4)) + 
              N' | Món ăn: ' + @TenMon + N' | Số lượng: ' + CAST(@SoLuong AS NVARCHAR(50)) + 
              N' | Thành tiền: ' + CAST(@ThanhTien AS NVARCHAR(50));

        FETCH NEXT FROM SoLuongMonAnCursor INTO @Thang, @Nam, @idMA, @TenMon, @SoLuong;
    END

    CLOSE SoLuongMonAnCursor;
    DEALLOCATE SoLuongMonAnCursor;
END;
exec proc_ThongKeSoLuongMonAnTheoThang
drop proc  proc_ThongKeSoLuongMonAnTheoThang


-- cursor lấy danh sách các món ăn theo loại món
CREATE PROC proc_LayDanhSachMonAnTheoLoai
AS BEGIN
    DECLARE @idLM INT;
    DECLARE @TenLoai NVARCHAR(100);
    DECLARE @idMa INT;
    DECLARE @TenMon NVARCHAR(100);
    DECLARE @Gia FLOAT;
    DECLARE @LastTenLoai NVARCHAR(100) = N'';

    DECLARE MonAnTheoLoaiCursor CURSOR FOR
    SELECT l.idLM, l.TenLoai, m.idMa, m.TenMon, m.Gia
    FROM tb_LOAIMON l
    JOIN tb_MONAN m ON l.idLM = m.idLM;

    OPEN MonAnTheoLoaiCursor;

    FETCH NEXT FROM MonAnTheoLoaiCursor INTO @idLM, @TenLoai, @idMa, @TenMon, @Gia;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        IF @TenLoai <> @LastTenLoai
        BEGIN
            PRINT N'Loại món: ' + @TenLoai + N'| Món ăn: ' + @TenMon + N' | Giá: ' + CAST(@Gia AS NVARCHAR(50));
            SET @LastTenLoai = @TenLoai;
		
        END
		else
			PRINT N'                | Món ăn: ' + @TenMon + N' | Giá: ' + CAST(@Gia AS NVARCHAR(50));

        FETCH NEXT FROM MonAnTheoLoaiCursor INTO @idLM, @TenLoai, @idMa, @TenMon, @Gia;
    END

    CLOSE MonAnTheoLoaiCursor;
    DEALLOCATE MonAnTheoLoaiCursor;
end 
exec proc_LayDanhSachMonAnTheoLoai
drop proc proc_LayDanhSachMonAnTheoLoai


-Phân quyền 

sp_addlogin 'Admin1', 'admin123'
sp_addlogin 'Staff1', 'staff123'

sp_grantdbaccess 'Admin1', 'Yasuo'
sp_grantdbaccess  'Staff1', 'Mei'

sp_addrolemember 'quanly', 'Yasuo'
sp_addrolemember 'nhanvien', 'Mei'

sp_addrole quanly
sp_addrole nhanvien


grant select, insert, delete, update on tb_TaiKhoan to quanly
grant select, insert, delete, update on tb_MonAn to quanly
grant select, insert, delete, update on tb_LoaiMon to quanly
grant select, insert, delete, update on tb_HoaDon to quanly
grant select, insert, delete, update on tb_ttHoaDon to quanly
grant select, insert, delete, update on tb_BanAn to quanly

grant select, insert, update on tb_HoaDon to nhanvien
grant select, insert, update on tb_ttHoaDon to nhanvien
grant select, insert, update on tb_BanAn to nhanvien

select * from tb_TaiKhoan where TenDangNhap = '' or 1=1--'
