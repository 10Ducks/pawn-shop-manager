--Bảng Admin
--kiểm tra đăng nhập, nếu không đúng mật khẩu thì trả về null
CREATE PROC getLogin(@ID varchar(50), @PASS varchar(256))
AS
BEGIN
	SELECT *
	FROM tbl_Admin
	WHERE Admin_Id = @ID
	AND Admin_Password = @PASS
END

EXEC getLogin 'admin', '123'