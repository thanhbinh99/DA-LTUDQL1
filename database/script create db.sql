﻿use master
go
if db_ID('QLTTN') is not null
begin
	drop database QLTTN
end
create database QLTTN
go
use QLTTN

/* ============================= TẠO BẢNG VÀ KHÓA CHÍNH =============================*/
create table KyThi(
	maKT varchar(10) primary key,
	NgayThi datetime
)

create table Thi(
	maKT varchar(10), 
	maDT int, 
	maHS int,
	Diem decimal,
	primary key (maKT, maDT, maHS)
)

create table DeThi(
	maDT int primary key identity not null,
	maMH varchar(10),
	maCH int
)

create table CauHoi(
	maCH int primary key identity not null,
	NoiDung nvarchar(1000),
	maCD int,
	maMH varchar(10),	-- chưa tạo khóa ngoại
	maKhoi int		-- chưa tạo khóa ngoại
)

create table CapDo(
	maCD int primary key identity not null,
	NoiDung nvarchar(1000)
)

create table DapAn(
	maCH int,
	maDA int identity not null,
	NoiDung nvarchar(1000),
	DungSai bit,
	primary key (maCH, maDA)
)

create table MonHoc(
	maMH varchar(10) primary key,
	tenMH nvarchar(1000),
	maKhoi int
)

create table KhoiLop(
	maKhoi int primary key identity not null
)

create table LopHoc(
	maKhoi int,
	maLop int identity not null
	primary key (maKhoi, maLop)
)

create table NguoiDung(
	maND int primary key identity not null,
	TenND varchar(1000),
	MatKhau varchar(1000),
	LoaiND varchar(10)
)

create table HocSinh(
	maHS int primary key,
	maND int,
	HoTen nvarchar(1000),
	NgaySinh datetime,
	maKhoi int,
	maLop int
)

create table GiaoVien(
	maGV int primary key,
	maND int,
	HoTen nvarchar(1000),
	NgaySinh datetime,
	maMH varchar(10)
)

create table CT_GiangDay(
	maGV int,
	maKhoi int,
	maLop int,
	primary key (maGV, maKhoi, maLop)
)
go

/*====================== Cập nhật khóa ngoại =====================*/
alter table HocSinh
add 
	constraint fk_hs_nd
	foreign key (maHS)
	references NguoiDung(maND)

alter table GiaoVien
add 
	constraint fk_gv_nd
	foreign key (maGV)
	references NguoiDung(maND)

alter table CT_GiangDay
add
	constraint fk_ctgd_gv
	foreign key (maGV)
	references GiaoVien(maGV),
	constraint fk_ctgd_lh
	foreign key (maKhoi, maLop)
	references LopHoc(maKhoi, maLop)

alter table Thi
add
	constraint fk_t_kt
	foreign key (maKT)
	references KyThi(maKT),
	constraint fk_t_dt
	foreign key (maDT)
	references DeThi(maDT),
	constraint fk_t_hs
	foreign key (maHS)
	references HocSinh(maHS)
alter table DeThi
add
	constraint fk_dt_mh
	foreign key (maMH)
	references MonHoc(maMH),
	constraint fk_dt_ch
	foreign key (maCH)
	references CauHoi(maCH)
alter table CauHoi
add 
	constraint fk_ch_cd
	foreign key (maCD)
	references CapDo(maCD)
alter table DapAn
add 
	constraint fk_da_ch
	foreign key (maCH)
	references CauHoi(maCH)
alter table MonHoc
add
	constraint fk_mh_kl
	foreign key (maKhoi)
	references KhoiLop(maKhoi)
alter table LopHoc
add
	constraint fk_lh_kl
	foreign key (maKhoi)
	references KhoiLop(maKhoi)
alter table HocSinh
add
	constraint fk_hs_lh
	foreign key (maKhoi, maLop)
	references LopHoc(maKhoi, maLop)
go

insert into NguoiDung(TenND, MatKhau, LoaiND) values ('nguyenthily', '123', 'hs')
insert into NguoiDung(TenND, MatKhau, LoaiND) values ('phanxieuthien', '123', 'hs')
insert into NguoiDung(TenND, MatKhau, LoaiND) values ('trankhoi', '123', 'hs')
insert into NguoiDung(TenND, MatKhau, LoaiND) values ('lethanhbbinh', '123', 'gv')
go

insert into HocSinh(maHS, HoTen) values(1, N'Nguyễn Thị Lý')
insert into HocSinh(maHS, HoTen) values(2, N'Phan Xiêu Thiên')
insert into HocSinh(maHS, HoTen) values(3, N'Trần Khôi')
insert into GiaoVien(maGV, HoTen) values(4, N'Lê Thanh Bình')
go

insert into CapDo values
(N'Trứng cút'),
(N'Gà con'),
(N'Diều hâu'),
(N'Đại bàng')
go

insert into CauHoi(maCD, NoiDung) values
(1, N'Trong hệ Mặt Trời, hai hành tinh nào không có vệ tinh? '),
(1, N'Trọng lực bề mặt Trái Đất nặng gấp mấy lần trọng lực bề mặt Mặt Trăng? '),
(1, N'Mất bao lâu để tia sáng từ Mặt Trời đến Trái Đất? '),
(2, N'Anh hùng Phạm Tuân của Việt Nam đã bay lên vũ trụ năm 1980 trong một chương trình của nước nào? '),
(2, N'Con tàu đầu tiên đưa người lên Mặt Trăng là con tàu mang tên gì? '),
(2, N'Vũ trụ hình thành từ đâu? '),
(3, N'Sự nở ra của vũ trụ được phát hiện bởi nhà thiên văn nào? '),
(3, N'Vũ trụ giãn nở mà không co lại do đâu? '),
(3, N'Giả thuyết đến nay đã được khẳng định về vũ trụ giãn nở vĩnh viễn có tên là gì? '),
( 4, N'Sự sống đã hình thành trên trái đất như thế nào? '),
( 4, N'Cái gì gây ra trọng lực? ')
go

insert into DapAn(maCH, NoiDung, DungSai) values
(1,  N'Sao Thủy và sao Kim', 1),
(1,  N'Sao Hỏa và sao Mộc', 0),
(1,  N'Sao Thổ và sao Thiên Vương', 0),
(1,  N'Sao Hải Dương và sao Diêm Vương', 0),
(2,  N'Gấp 4 lần', 0),
(2,  N'Gấp 5 lần', 0),
(2,  N'Gấp 6 lần', 1),
(2,  N'Gấp 7 lần', 0),
(3,  N'Mất 5 phút', 0),
(3,  N'Mất 6 phút', 0),
(3,  N'Mất 7 phút', 0),
(3,  N'Mất 8 phút', 1),
(4,  N'Mỹ', 0),
(4,  N'Châu Âu', 0),
(4,  N'Liên Xô', 1),
(5,  N'Apolo 9', 0),
(5,  N'Apolo 11', 1),
(5,  N'Apolo 13', 0),
(5,  N'Apolo 15', 0),
(6,  N'Một vụ nổ lớn tạo nên không gian và thời gian', 1),
(6,  N'Một đám khí và bụi tập hợp và hệ thống lại', 0),
(6,  N'Hậu quả của sự biến đổi nhiệt độ và áp suất', 0),
(7,  N'Arthur Eddington', 0),
(7,  N'Edwin Hubble', 1),
(7,  N'Harley Davidson', 0),
(7,  N'Galileo Galilei', 0),
(8,  N'Gia tốc ban đầu và tốc độ giản nở', 0),
(8,  N'Vật chất tối', 0),
(8,  N'Năng lượng tối', 0),
(8,  N'Khoa học chưa có lời giải thích', 1),
(9,  N'Vũ trụ phẳng', 0),
(9,  N'Vũ trụ mở', 1),
(9,  N'Vũ trụ đóng', 0),
(10, N'Thời xưa, Adam gặp Eva và sinh ra vạn vật', 0),
(10, N'Nhiều giả thuyết về nguồn gốc sự sống đã được nêu ra, nhưng vì rất khó để chứng minh hay bác bỏ chúng nên không tồn tại bất kỳ giả thuyết nào được chấp nhận hoàn toàn', 1),
(10, N'Đây là câu đúng', 0),
(11, N'Trọng lực là yếu nhất trong tất cả dạng lực đã biết trong vũ trụ và mô hình vật lý tiêu chuẩn hiện nay cũng không giải thích được cách thức hoạt động của nó. Các nhà vật lý lý thuyết cho rằng, trọng lực có thể liên quan đến những hạt rất nhỏ, không có khối lượng gọi là graviton. Những hạt này đã toả ra các từ trọng trường.', 0),
(11, N'Khoa học vẫn chưa tìm ra được', 1),
(11, N'Trọng lực hoàn toàn khác các lực còn lại được mô tả trong vật lý tiêu chuẩn', 0),
(11, N'Tôi không biết', 0)
go

use QLTTN
select * from CauHoi
select * from DapAn
select * from CapDo
select * from NguoiDung
select * from HocSinh
select * from GiaoVien
select IDENT_CURRENT('dbo.CauHoi')

/*
-- xóa những câu hỏi mà chưa có đáp án
delete from CauHoi
where not exists (select * from DapAn
				where DapAn.maCH = CauHoi.maCH)

delete from DapAn where maCH > 50
delete from CauHoi where maCH > 50

delete from DapAn
delete from CauHoi
delete from CapDo

1,  
2,  
3,  
4,  
5,  
6,  
7,  
8,  
9,  
10, 
11, 
12, 
13, 
14, 
15, 
16, 
17, 
18, 
19, 
20, 
21, 
22, 
23, 
24, 
25, 
26, 
27, 
28, 
29, 
30, 
31, 
32, 
33, 
34, 
35, 
36, 
37, 
38, 
39, 
40, 
*/