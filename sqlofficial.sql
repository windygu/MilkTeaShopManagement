﻿create MilkTea
go

use MilkTea
go

create table Account
(
	USERNAME varchar(100) not null,
	PASSWORD VARCHAR(1000) not null,
	TYPE BIT not null,

	constraint PK_Account primary key (USERNAME)
)
go

create table Drink
(
	ID int not null,
	NAME nvarchar(100) not null,
	CATEGORY nvarchar(100) default '',
	PRICE int default 0,
	IMAGE image,
	STATUS bit default 1,

	constraint PK_Drink primary key (ID),
	constraint FK_Drink_Category foreign key(CATEGORY) references Category(NAME)
)
go

create table Category
(
	NAME nvarchar(100) default '',

	constraint PK_Category primary key (NAME)
)
go

create table Staff
(
	ID int not null,
	NAME NVARCHAR(100) not null,
	IMAGE image,
	BIRTHDATE DATE,
	POSITION NVARCHAR(100),
	USERNAME VARCHAR(100),
	OVERTIME SMALLINT DEFAULT 0, -- sửa lại là overtime nha
	SALARY INT DEFAULT 0,

	constraint PK_Staff primary key (ID),
	constraint FK_Staff_UserName foreign key(USERNAME) references Account(USERNAME)
)
go
alter table Staff
add SalaryReceived int default 0
alter table Staff
add OverTimeSalary int default 0
alter table Staff
add Fault int default 0
alter table Staff
add MinusSalary int default 0
alter table Staff
add PhoneNumber varchar(10)

create table Bill
(
	ID int not null,
	STAFFID int,
	CHECKOUT date,
	STATUS bit default 0,
	TOTAL int default 0,

	constraint PK_Bill primary key(ID),
)
go
alter table bill	
add NOTE text

create table BillInfo
(
	BILLID int,
	DRINKID int,
	COUNT int,

	constraint PK_BillInfo primary key(BILLID, DRINKID),
	constraint FK_BillInfo_BillID foreign key(BILLID) references Bill(ID),
	constraint FK_BillInfo_DrinkID foreign key(DRINKID) references Drink(ID)
)
go

-- proc BillInfo
create proc USP_InsertBillInfo
@idBill int, @idDrink int, @count int	
as
begin
	declare @isExistBillInfo int
	declare @drinkCount int = 1

	select @isExistBillInfo = BillID, @drinkCount = Count
	from BillInfo
	where BillID = @idBill and DrinkID = @idDrink

	if (@isExistBillInfo > 0)
		begin
			declare @newCount int = @drinkCount + @count
			if (@newCount > 0)
				update BillInfo 
				set Count = @drinkCount + @Count
				where DrinkID = @idDrink
			else 
				delete BillInfo
				where BillID = @idBill and DrinkID = @idDrink
		end
	else 
		begin
			insert into BillInfo(BillID, DrinkID, Count)
			values
			(
				@idBill,
				@idDrink,
				@Count
			)
		end
end
go

create proc USP_DeleteBillInfo
@BillID int
as
begin
	delete from BillInfo
	where BillID = @BillID
end
go

-- proc Bill
alter proc USP_UpdateBill
@ID int, @StaffID int, @CheckOut date, @Status bit, @Total int
as
begin
	update Bill
	set StaffID = @StaffID, CheckOut = @CheckOut, Status = @Status, Total = @Total 
	where ID = @ID
end
go

alter proc USP_InsertBill
@ID int, @StaffID int, @note text
as
begin
	insert into Bill (ID, StaffID, NOTE) 
	values 
	(
	@ID,
	@StaffID,
	@note
	)
end
go

create proc USP_DeleteBill
@ID int
as
begin
	delete from Bill
	where ID = @ID
end
go

-- proc drink
alter proc USP_AddDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image
as
begin
	--insert into Drink(ID,NAME,PRICE,IMAGE) values (@ID,@Name,@Price,@Image)

	--update Drink
	--set category = @Category
	--where ID = @ID

	insert into Drink (ID, NAME, CATEGORY, PRICE, IMAGE) values (@ID, @Name, @Category, @Price, @Image)
end
go

create proc USP_EditDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image
as 
begin
	update Drink
	set Name=@Name, Price=@Price, category=@Category, Image=@Image
	where ID=@ID
end
go

alter proc USP_SetnullDrinkIDinBillInfo
@drinkID int
as
begin
	update BillInfo
	set DrinkID=null
	where DrinkID=@drinkID
end
go

UPDATE Drink
SET STATUS =1
WHERE ID = 1

select * from Drink
-- PROC MENU
create proc USP_GetListMenuByBillID
@billID int
as
begin
	select b.ID as BillID, d.ID as IDDrink, d.Name, d.Price, bf.Count 
	from ((BillInfo as bf 
		inner join Drink as d
		on bf.DrinkID = d.ID)
		inner join Bill as b
		on b.ID = bf.BillID)
	where b.ID = @billID
end
go

-- proc category
create proc USP_DeleteCategory
@Category nvarchar(100)
as 
begin
	delete from Drink
	where Category=@Category

	delete from Category
	where NAME=@Category
end
go

-- proc staff
alter proc USP_AddStaff
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @username varchar(100), @phonenumber varchar(10), @salary int,
@OvertimeSalary int, @MinusSalary int
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, USERNAME, PhoneNumber) values(@ID, @Name, @image, @birthday, @pos, @username, @phonenumber)

	update Staff
	set SALARY = @salary, OverTimeSalary = @OvertimeSalary, MinusSalary = @MinusSalary
	where ID = @ID and POSITION = @pos
end
go

alter proc USP_AddStaffnoUsername
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @phonenumber varchar(10), @salary int,
@OvertimeSalary int, @MinusSalary int
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, PhoneNumber) values(@ID, @Name, @image, @birthday, @pos, @phonenumber)

	update Staff
	set SALARY = @salary, OverTimeSalary = @OvertimeSalary, MinusSalary = @MinusSalary
	where ID = @ID and POSITION = @pos
end
go

alter proc USP_EditStaff
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @phonenumber varchar(10)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, PhoneNumber = @phonenumber
	where ID = @ID
end
go

create proc USP_DelStaff
@ID int
as
begin
	delete from Staff where ID = @ID
end
go

create proc USP_UpdateOverTime
@ID int, @OverTime int
as
begin
	update Staff
	set OverTime = @OverTime
	where ID = @ID
end
go

create proc USP_UpdateFault
@ID int, @fault int
as
begin
	update Staff
	set Fault = @fault
	where ID = @ID
end
go

create proc USP_UpdateSalary
@position nvarchar(100), @salary int,@overtimesalary int, @minussalary int
as
begin
	update Staff
	set SALARY = @salary, OverTimeSalary = @overtimesalary, MinusSalary = @minussalary
	where POSITION = @position
end
go

create proc USP_UpdateSalaryReceived
@id int, @salaryreceived int
as
begin
	update Staff
	set SalaryReceived = @salaryreceived
	where ID = @id
end
go

-- proc account
create proc USP_DelAccount
@user varchar(100)
as
begin
	delete from Account where UserName = @user
end

alter proc USP_GetListInvoicebyBillID
@billID int
as
begin
select d.Name as N'Tên món', bf.Count as N'Số lượng', d.Price as N'Đơn giá', d.PRICE * bf.COUNT as N'Thành tiền'
from ((BillInfo as bf 
		inner join Drink as d
		on bf.DrinkID = d.ID)
		inner join Bill as b
		on b.ID = bf.BillID)
	where b.ID = @billID
end
