use QuanlyQuanAn

create table Ban
(
   IdBan int identity primary key,
   TinhTrang int default 1,
   GhiChu nvarchar(max),
   LoaiBan nvarchar(max),
)

create table Mon
(
   IdMon int identity primary key,
   TenMon nvarchar(max),
   GiaTien float,
   TinhTrang int default 1,
   GhiChu nvarchar(max),
   LoaiMon nvarchar(max)
)

create table NhanVien
(
   MaNV int identity primary key,
   TenNhanVien nvarchar(max),
   GioiTinh nvarchar(max),
   CCCD nvarchar(max),
   SDT nvarchar(max),
   DiaChi nvarchar(max),
   GhiChu nvarchar(max)
)

create table TaiKhoan
(
   IdTK int identity primary key,
   TenNV nvarchar(max),
   Username nvarchar(max),
   Matkhau nvarchar(max),
   LoaiTaiKhoan nvarchar(max),
   TinhTrang int default 1,
   GhiChu nvarchar(max),
)

create table HoaDon
(
   IdHD int identity primary key,
   SoBan int references Ban(idBan),
   IdTK int references TaiKhoan(IdTK),
   TinhTrang int default 1,
   ThoiGian datetime,
   GiaTien float,
   GhiChu nvarchar(max),
)

create table ChiTietHoaDon
(
   IdHoaDon int references HoaDon(IdHD),
   IdMon int references Mon(IdMon),
   primary key (IdHoaDon,IdMon)
)



--thêm bàn
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)

insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)
insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)

insert into LapTop values (N'Laptop ASUS Vivobook X515EA-BQ2351W',3,1,1)

-- thêm món ăn



--Thêm Tài khoản'



--Thêm nhân viên



---Thêm hóa đơn