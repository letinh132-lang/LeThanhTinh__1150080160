IF OBJECT_ID('dbo.SinhVien', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.SinhVien
    (
        MaSV    NVARCHAR(20)  NOT NULL PRIMARY KEY,
        TenSV   NVARCHAR(100) NOT NULL,
        GioiTinh NVARCHAR(10) NOT NULL, -- 'Nam'/'Nữ'
        NgaySinh DATE NOT NULL,
        QueQuan NVARCHAR(100) NOT NULL,
        MaLop   NVARCHAR(20)  NOT NULL
    );
END
