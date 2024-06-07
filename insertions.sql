insert into Employees([Id],[FirstName],[LastName],[Email],[MobileNumber],[DateOfBirth],[DateOfJoin],[Location],[JobTitle],[Department],[Manager],[Project])
values
('TZ0001','Ramya','Sanaboina','ramya@tezo.com',9876543210,'2002-12-01','2020-12-20',1,1,1,1,1),
('TZ0002','Kavya','Gutthula','kavya@tezo.com',9876543210,'2002-11-02','2020-02-01',2,2,1,2,1),
('TZ0003','Sravya','Saripella','sravya@tezo.com',9876543210,'2002-02-13','2020-02-10',1,3,2,2,1);


insert into Roles([Name],[Location],[Department],[Description])
values
('Lead developer',1,1,'test'),
('Solution Architect',1,1,'test'),
('Lead tester',2,1,'test');



insert into Locations(Name)
values('Hyderabad'),
('Banglore');

insert into Departments(Name)
values('Product Engineering'),
('Quality Assurance'),
('Marketing');

insert into Managers(Name)
values('Sandeep'),
('siva');

insert into Projects(Name)
values('Geo Blue'),
('BNSI');

select *from Locations;
select *from Roles;
select *from Employees;