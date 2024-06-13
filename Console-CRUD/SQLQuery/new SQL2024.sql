Create Table HospitalDetails(
Id  bigint identity(1,1) Primary key ,
Name nvarchar(100) Not null,
Email nvarchar(100) unique,
Address nvarchar(300) Not null,
Phonenumber bigint Not null,
Pincode bigint Not null)


create or alter procedure  HospitalLogin
 
 (@Name nvarchar(50), 
 @Email nvarchar(100),
 @Address nvarchar(100),
 @Phonenumber bigint,
 @Pincode bigint) 
 
 AS
 Begin
 Insert into[dbo] .[HospitalDetails]
 ([Name],[Email],[Address],[Phonenumber],[Pincode])
 values(
 @Name,
 @Email,
 @Address,
 @Phonenumber,
 @Pincode)
end

exec HospitalLogin  'santhosh','santhosh11@gmail.com','wvfwfwqfwqff',909099090,624613
select *from [HospitalDetails]

 create or alter procedure HospitalEdit
(
 @Id Bigint ,
 @Address nvarchar(100),
 @Phonenumber bigint) 
 As
 Begin
 update HospitalDetails set Phonenumber=@Phonenumber,Address=@Address
 where Id=@Id
 end
-- exec  HospitalEdit 'santhosh','sancon@gmail.com',34573698698

exec HospitalEdit 44,'santhosh',777777
 select *from HospitalDetails

 create or alter procedure HospitalDelete
 (@Id Bigint)
 As
 begin Delete  HospitalDetails where Id=@Id end


 exec HospitalDelete 7
 select *from HospitalDetails

 create or alter procedure HospitalSearch
 (@Id Bigint)
 As
 Begin
 select * from HospitalDetails 
 where
  Id=@Id
  end
  exec HospitalSearch 44
  Create or alter procedure HospitalShowall
  As
  Begin select *from HospitalDetails end 

create table Locationtap
(LocationId Bigint identity(1,1),
LocationName nvarchar(100)not null)
insert into Locationtap(LocationName)
values('palani')

--drop table Locationtap
create or Alter procedure LocationPoint
(@LocationId Bigint,
@LocationName nvarchar(100))
As
Begin
Select *from Locationtap
end

--exec LocationPoint 1,'palani'