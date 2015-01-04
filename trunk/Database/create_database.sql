CREATE SCHEMA dbo;

CREATE TABLE dbo.Logs ( 
	Log_Id               int NOT NULL   IDENTITY,
	Log_Staff_Id         int NOT NULL   ,
	Log_Status_Id        int NOT NULL   ,
	Log_Table            varchar(50) NOT NULL   ,
	Log_Customer_Id      int    ,
	Log_Item_Id          int    ,
	Log_Order_Id         int    ,
	Log_Create_Date      datetime NOT NULL   ,
	Log_Note             ntext    ,
	Log_Delete_Flag      bit NOT NULL CONSTRAINT defo_Logs_Log_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Logs PRIMARY KEY ( Log_Id ),
	CONSTRAINT Pk_Logs_0 UNIQUE ( Log_Customer_Id ) ,
	CONSTRAINT Pk_Logs_1 UNIQUE ( Log_Staff_Id ) ,
	CONSTRAINT Pk_Logs_2 UNIQUE ( Log_Order_Id ) ,
	CONSTRAINT Pk_Logs_3 UNIQUE ( Log_Item_Id ) ,
	CONSTRAINT Pk_Logs_4 UNIQUE ( Log_Status_Id ) 
 );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Bang ghi nhat ky' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Id cua bang Log' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ai ghi log?' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Staff_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Trang thai cua log 
vd: them sua xoa ...' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Status_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Bang nao duoc su dung' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Table';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'khach hang nao?' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Customer_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'mat hang nao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Item_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Hoa don nao?' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Order_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ngay tao log' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Create_Date';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ghi chu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Note';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Co xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Logs', @level2type=N'COLUMN',@level2name=N'Log_Delete_Flag';

CREATE TABLE dbo.Orders ( 
	Order_Id             int NOT NULL   IDENTITY,
	Customer_Id          int NOT NULL   ,
	Order_Create_Date    datetime NOT NULL   ,
	Order_Cost           money    ,
	Order_Expiration_Date datetime    ,
	Order_Payment_Date   datetime    ,
	Order_Note           ntext    ,
	Order_Delete_Flag    bit NOT NULL CONSTRAINT defo_Orders_Order_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Orders PRIMARY KEY ( Order_Id ),
	CONSTRAINT Pk_Orders_0 UNIQUE ( Customer_Id ) 
 );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Bang don dat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Id cua bang dat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'id cua khach hang da dat' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Customer_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ngay tao hoa don' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Create_Date';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Gia cua hoa don' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Cost';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ngay het han' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Expiration_Date';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ngay tra tien' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Payment_Date';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ghi chu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Note';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Co xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Order_Delete_Flag';

CREATE TABLE dbo.Roles ( 
	Role_Id              int NOT NULL   IDENTITY,
	Role_Name            nvarchar(20) NOT NULL   ,
	Role_Note            ntext    ,
	Role_Delete_Flag     bit NOT NULL CONSTRAINT defo_Roles_Role_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Roles PRIMARY KEY ( Role_Id )
 );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Chuc vu cua nhan vien
1: Admin - Boss
2: Ke toan
3: Nhan vien ban hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Id cua chuc vu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Role_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ten cua chuc vu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Role_Name';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ghi chu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Role_Note';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Co xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Roles', @level2type=N'COLUMN',@level2name=N'Role_Delete_Flag';

CREATE TABLE dbo.Status_Log ( 
	Status_Id            int NOT NULL   IDENTITY,
	Status_Name          varchar(20) NOT NULL   ,
	Status_Description   nvarchar(100)    ,
	Status_Note          ntext    ,
	Status_Delete_Flag   bit NOT NULL CONSTRAINT defo_Status_Log_Status_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Statu PRIMARY KEY ( Status_Id )
 );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'trang thai' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Status_Log';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Mo ta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Status_Log', @level2type=N'COLUMN',@level2name=N'Status_Description';

CREATE TABLE dbo.Customers ( 
	Customer_Id          int NOT NULL   IDENTITY,
	Customer_Name        nvarchar(50) NOT NULL   ,
	Customer_Identity_Card varchar(20) NOT NULL   ,
	Customer_Address     nvarchar(100)    ,
	Customer_Phone       varchar(20)    ,
	Customer_Email       varchar(50)    ,
	Customer_Image       varchar(50)    ,
	Customer_Note        text    ,
	Customer_Delete_Flag bit NOT NULL CONSTRAINT defo_Customers_Customer_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Customer PRIMARY KEY ( Customer_Id )
 );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Bang Khach hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'ID cua khach hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ten khach hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Name';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Chung minh nhan dan cua Khach hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Identity_Card';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Dia chi khach hang
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Address';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Dien thoai Khach hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Phone';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Email cua Khach Hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Email';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Hinh chup cua Khach Hang (hinh anh luu tren may, CSDL chi luu ten cua tam hinh)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Image';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ghi chu ve khach hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'Customer_Note';

CREATE TABLE dbo.Order_Detail ( 
	Order_Detail_Id      int NOT NULL   IDENTITY,
	Order_Id             int NOT NULL   ,
	Item_Id              int NOT NULL   ,
	Order_Detail_Amount  int    ,
	Order_Detail_Create_Date datetime NOT NULL   ,
	Order_Detail_Note    ntext    ,
	Order_Detail_Staff_Id int NOT NULL   ,
	Order_Detail_Delete_Flag bit NOT NULL CONSTRAINT defo_Order_Detail_Order_Detail_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Order_Detail PRIMARY KEY ( Order_Detail_Id ),
	CONSTRAINT Pk_Order_Detail_0 UNIQUE ( Item_Id ) ,
	CONSTRAINT Pk_Order_Detail_1 UNIQUE ( Order_Detail_Staff_Id ) 
 );

CREATE INDEX idx_Order_Detail ON dbo.Order_Detail ( Order_Id );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Chi tiet dat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Id chi tiet dat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Detail_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Khoa ngoai voi bang Orders' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Khoa ngoai voi bang Items' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Item_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'So luong mat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Detail_Amount';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ngay tao' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Detail_Create_Date';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ghi chu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Detail_Note';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Nhan vien ban hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Detail_Staff_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Co xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order_Detail', @level2type=N'COLUMN',@level2name=N'Order_Detail_Delete_Flag';

CREATE TABLE dbo.Staffs ( 
	Staff_Id             int NOT NULL   IDENTITY,
	Staff_Account        varchar(50) NOT NULL   ,
	Staff_Password       varchar(256) NOT NULL   ,
	Staff_Name           nvarchar(100) NOT NULL   ,
	Staff_Address        nvarchar(100)    ,
	Staff_Email          varchar(50)    ,
	Staff_Phone          varchar(20)    ,
	Staff_Role_Id        int NOT NULL   ,
	Staff_Image          varchar(50)    ,
	Staff_Note           ntext    ,
	Staff_Delete_Flag    bit NOT NULL CONSTRAINT defo_Staffs_Staff_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Staffs PRIMARY KEY ( Staff_Id ),
	CONSTRAINT Pk_Staffs_0 UNIQUE ( Staff_Role_Id ) ,
	CONSTRAINT Idx_Staffs UNIQUE ( Staff_Account ) 
 );

CREATE TABLE dbo.Items ( 
	Item_Id              int NOT NULL   IDENTITY,
	Item_Name            nvarchar(100) NOT NULL   ,
	Item_Cost            money NOT NULL   ,
	Item_Amount          int NOT NULL   ,
	Item_Unit            varchar(10) NOT NULL   ,
	Item_Image           varchar(100)    ,
	Item_Delete_Flag     bit NOT NULL CONSTRAINT defo_Items_Item_Delete_Flag DEFAULT 0  ,
	CONSTRAINT Pk_Items PRIMARY KEY ( Item_Id )
 );

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Cac mat hang duoc cam' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items';;

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Id cua mat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Id';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Ten cua mat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Name';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Gia tien cua mat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Cost';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'So luong cua mat hang' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Amount';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Don vi tinh' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Unit';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Hinh cua mat hang, luu duong dan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Image';

exec sp_addextendedproperty  @name=N'MS_Description', @value=N'Co xoa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Items', @level2type=N'COLUMN',@level2name=N'Item_Delete_Flag';

ALTER TABLE dbo.Customers ADD CONSTRAINT Fk_Customers FOREIGN KEY ( Customer_Id ) REFERENCES dbo.Orders( Customer_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Customers ADD CONSTRAINT Fk_Customers_0 FOREIGN KEY ( Customer_Id ) REFERENCES dbo.Logs( Log_Customer_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Items ADD CONSTRAINT Fk_Items FOREIGN KEY ( Item_Id ) REFERENCES dbo.Order_Detail( Item_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Items ADD CONSTRAINT Fk_Items_0 FOREIGN KEY ( Item_Id ) REFERENCES dbo.Logs( Log_Item_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Order_Detail ADD CONSTRAINT Fk_Order_Detail FOREIGN KEY ( Order_Id ) REFERENCES dbo.Orders( Order_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Orders ADD CONSTRAINT Fk_Orders FOREIGN KEY ( Order_Id ) REFERENCES dbo.Logs( Log_Order_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Staffs ADD CONSTRAINT Fk_Staffs FOREIGN KEY ( Staff_Id ) REFERENCES dbo.Logs( Log_Staff_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE dbo.Staffs ADD CONSTRAINT Fk_Staffs_0 FOREIGN KEY ( Staff_Id ) REFERENCES dbo.Order_Detail( Order_Detail_Staff_Id ) ON DELETE NO ACTION ON UPDATE NO ACTION;

INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1087, 0, 0, 'Mike watches football. ', 0, 0, 0, '2008-09-24 11:14:49.983', 'net.sourceforge.jtds.jdbc.ClobImpl@153d528', 1 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1088, 1, 1, 'Mike watches football. Rudi watches football. ', 1, 1, 1, '2008-05-15 05:44:07.937', 'net.sourceforge.jtds.jdbc.ClobImpl@5d9d41', 1 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1089, 2, 2, 'Mike watches football. I watches football. ', 2, 2, 2, '2008-07-31 03:25:39.2', 'net.sourceforge.jtds.jdbc.ClobImpl@1ff2e2f', 1 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1090, 3, 3, 'I like sports. Mike watches football. ', 3, 3, 3, '2008-03-17 07:45:56.737', 'net.sourceforge.jtds.jdbc.ClobImpl@3111b5', 0 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1091, 4, 4, 'Mike watches football. Rudi watches football. ', 4, 4, 4, '2008-10-11 18:03:35.807', 'net.sourceforge.jtds.jdbc.ClobImpl@181b67d', 0 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1092, 5, 5, 'Mike like swimming. I watches football. ', 5, 5, 5, '2008-10-06 09:52:56.833', 'net.sourceforge.jtds.jdbc.ClobImpl@f3d8b3', 0 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1093, 6, 6, 'Rudi watches football. ', 6, 6, 6, '2008-02-12 02:08:03.84', 'net.sourceforge.jtds.jdbc.ClobImpl@1180fdb', 1 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1094, 7, 7, 'Mike watches football. Rudi watches football. ', 7, 7, 7, '2008-03-14 11:11:35.423', 'net.sourceforge.jtds.jdbc.ClobImpl@b92ad1', 0 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1095, 8, 8, 'I like sports. Rudi watches football. ', 8, 8, 8, '2008-05-03 16:41:51.873', 'net.sourceforge.jtds.jdbc.ClobImpl@82c3f', 1 ); 
INSERT INTO dbo.Logs( Log_Id, Log_Staff_Id, Log_Status_Id, Log_Table, Log_Customer_Id, Log_Item_Id, Log_Order_Id, Log_Create_Date, Log_Note, Log_Delete_Flag ) VALUES ( 1096, 9, 9, 'Mike watches football. Mike watches football. ', 9, null, 9, '2008-08-22 05:16:24.96', 'net.sourceforge.jtds.jdbc.ClobImpl@911382', 0 ); 

