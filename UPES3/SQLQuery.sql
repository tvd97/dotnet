create  database website_nckh
go 
use website_nckh
go

create table account
(
userName varchar(20) primary key,
passWord varchar(32) not null,
role ntext,
status int default 1
)
go 
create table department
(
idDepartment varchar(10) primary key,
nameDepartment text not null
)
go
create table notifications
(idNotification int identity primary key,
title ntext not null,
metaTitle text ,
content ntext not null,
FileName text,
dateCreat date default getdate()
)
go
create table statements
(
idStatement int Identity  primary key,
dateStatement date,
status ntext
)
go

create table lecturer
(
idLecturer varchar(10) primary key,
name nvarchar(50),
userName varchar(20),
email varchar(30),
phone char(10),
idDepartment varchar(10)
foreign key (userName) references Account(userName),
foreign key (idDepartment) references department(idDepartment)
)
go
 create table type
(
 idType varchar(10) primary key,
 nametype ntext
 )
 go 
 create table classityType
 (
 idClassity varchar(10) primary key,
 idType varchar(10),
 name ntext,
 value float,
 foreign key (idType) references Type(idType)
 )
 go 
 create table  projectOfLecturer
 (
 idProject varchar(20) primary key,
 nameProject ntext,
 target ntext,
 content ntext,
 idLecturer varchar(10),
 idClassity varchar(10),
 dateSubmit date,
 dateStart date,
 deadline int,
 expense float,
 status int default 1, --1 Pending, 2 Accept, 3 Reject
 countAuthor int,
 point ntext,
 scholastic ntext
 foreign key (idLecturer) references lecturer(idLecturer),
 foreign key (idClassity) references classityType(idClassity)
 )
 go
 create table request
 (idRequest int identity primary key,
 idProject varchar(20) not null,
 request ntext not null,
 countMonth int,
 cause ntext,
 status int default -1
 foreign key (idProject) references  projectOfLecturer(idProject)
 )
 go
 create table detailStatement
(
idDetail int  identity primary key,
idStatement int,
idProject varchar(20),
countStatement ntext ,-- lần báo cáo
status ntext default N'Chưa báo cáo' -- 
foreign key (idProject) references  projectOfLecturer(idProject),
foreign key (idStatement) references   Statements(idStatement)

)
 go
 create table  progressProject
 (
 idProgress int identity primary key,
 idProject varchar(20),
 content ntext,
 date date,
 status ntext
 foreign key (idProject) references projectOfLecturer(idProject)
 )

 go
 create table projectOfStudent
 (
 idProject varchar(20) primary key,
 nameProject ntext,
 target ntext,
 content ntext,
 nameStudent ntext,
 idStudent varchar(12),
 idDepartment varchar(10),
 email varchar(30),
 idClassity varchar(10),
 countAuthor int,
 dateSubmit date,
 dateStart date,
 deadline int,
 expense float default 0,
 Status int default 1,-- 1 đang chờ 2 chấp nhận 3 K chap nhan
 foreign key (idClassity) references classityType(idClassity),
 foreign key (idDepartment)  references department(idDepartment)
 )
 go
 create table fileClassity
 (
	id	int identity primary key,
	sincedate	date,
	todate	date,
	FileName	ntext
 )
 create table HistoryApproval
 ( id int identity primary key,
 idProject varchar(20),
 times datetime,
 status int --0 fasle 1 true
 foreign key (idProject) references projectOfLecturer(idProject)
 )
 go 
 insert into  ACCOUNT
 VALUES('admin','21232f297a57a5a743894a0e4a801fc3','isAdmin',1)
 
