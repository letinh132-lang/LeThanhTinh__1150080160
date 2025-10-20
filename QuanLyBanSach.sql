create proc XoaDuLieu
    @maXB char(10)
as
begin
    delete from NhaXuatBan where MaXB = @maXB;
end
