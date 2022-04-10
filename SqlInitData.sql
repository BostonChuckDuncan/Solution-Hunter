use HunterServerDb
go

insert into dbo.Users
values(
 'Charles', 'Duncan', '9787669135', '',
 'Chuck', 'cduncan@BostonDuncan.com', 'Are you tall', 'Yup', 0);

insert into dbo.Users
values(
 'Patricia', 'Duncan', '9783393660', '',
 'Pat', 'pduncan@BostonDuncan.com', 'Are you tall', 'sorta', 0);

 select * from dbo.Users

