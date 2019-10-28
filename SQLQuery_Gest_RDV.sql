use Gest_RDV
go

select * from Medecin
select * from Patient
select * from RDV

insert into Medecin values('1','Hassan lmghari','0644321922','12-12-2009','Cardiologie')
insert into Medecin values('2','Hassan lmghari','0677965432','17-12-2005','Chirurgie')
insert into Medecin values('3','Mohamed Latifi','0612335487','16-9-2009','Dermatologie')
insert into Medecin values('4','Fayssal Faoizi','0698541198','6-7-2008','Gériatrie')
insert into Medecin values('5','Samir Bnani','061198437765','5-3-2010','Oncologie')
insert into Medecin values('6','Morad lmghari','0612550977','19-11-2011','Pediatrie')
insert into Medecin values('7','Abdltif lmghari','0600985432','14-4-2008','psychiatrie')
insert into Medecin values('8','Osama El habib','0663554167','9-1-2012','Allergologie')

insert into Patient values('1','Hlimi Mohamed','BV Hassa2','12-4-1966','Homme')
insert into Patient values('2','Bdrawi Abdsamad','BV Mohamed5 Marrakech','12-4-1985','Homme')
insert into Patient values('3','Karimi Morad','BV Hassa2 Marrakech','12-4-1976','Homme')
insert into Patient values('4','Anasi khadija','Qu Bnmansor Tamnsort','12-4-1983','femme')
insert into Patient values('5','Jabori Halima','Hay massira Ait ourir','12-4-1990','femme')

select * from RDV

drop table RDV

create table RDV(NumeroRDV int primary key identity(1,1),DateRDV date,HeureRDV varchar(20),CodeMedecin varchar(50) foreign key references Medecin ,CodePatient varchar(50) foreign key references Patient)


insert into RDV values('12-10-2018','10:11','5','1')
insert into RDV values('12-10-2018','10:11','1','1')
insert into RDV values('19-12-2018','9:18','2','1')
insert into RDV values('16-11-2018','11:30','3','3')
insert into RDV values('17-1-2019','9:45','4','2')

select * from RDV


select NomPatient,AdressePatient,Datenaissance,SexePatient from Patient 
select * from RDV
select * from RDV where CodePatient='3'

delete from RDV where NumeroRDV='' 
select p.NomPatient,p.Datenaissance,p.SexePatient from Patient p inner join RDV r on p.CodePatient=r.CodePatient where r.NumeroRDV='1'

update Medecin 
set NomMedecin='Mohamed Lbhrawi' where CodeMedecin='2'

delete  from RDV where CodeMedecin = '5'

update RDV set NumeroRDV='{0}',DateRDV='{1}' , HeurRDV='{2}' , CodeMedecin='{4}' , CodePatient='{5}' where NumeroRDV='2'

delete  from RDV where NumeroRDV = '3'
delete  from Patient where CodePatient = '3'

select * from Medecin



Alter table RDV drop PK_RDV --Valider

select * from RDV

alter table RDV alter column NumeroRDV int


alter table RDV 
add constraint RDV_Num primary key (NumeroRDV) 

