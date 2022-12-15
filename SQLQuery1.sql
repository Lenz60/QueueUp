create database AntrianRS 

on (
name = 'Antrian_dat',
filename = 'C:\SQL\FpAntrian_dat.mdf',
size = 5,
maxsize = 10,
filegrowth = 2
)

log on (
name = 'Antrian_log',
filename = 'C:\SQL\FpAntrian_log.ldf',
size = 5,
maxsize = 10,
filegrowth = 2
)
use AntrianRS

create table DataID (
ID_Pasien varchar(5) primary key not null,
Nama_Pasien varchar(15),
JK_ID varchar(1),
Tgl_Lahir_ID date,
)

INSERT INTO DataID values('P001','Rafly','L','1999/07/29')
INSERT INTO DataID values ('P002','Alif','L','1998/01/14')
INSERT INTO DataID values ('P003','Indah','p','1998/05/25')
INSERT INTO DataID values ('P004','Sufirna','p','1998/03/17')
INSERT INTO DataID values ('P005','Doni','L','2001/05/05')
INSERT INTO DataID values ('P006','Rival','L','1987/01/26')
INSERT INTO DataID values ('P007','Agus','L','1993/02/28')
INSERT INTO DataID values ('P008','Hery','L','1996/04/30')
INSERT INTO DataID values ('P009','Rendi','L','1989/04/02')
INSERT INTO DataID values ('P010','Herma','L','1990/05/03')
INSERT INTO DataID values ('P011','Adi','L','1899/09/18')

SELECT * FROM DataID

create table Kdaid (
Kd_AntriID varchar(10) primary key,
ID_Pasien varchar(5) not null references DataID(ID_Pasien),
Kd_Poli varchar(10) not null references Poli(Kd_Poli),
Kd_Dokter varchar(5) not null references Dokter(Kd_Dokter),
kd_A varchar(10) not null references Asuransi(Kd_a)
)

Select * FROM Kdaid
DELETE FROM Kdaid WHERE Kd_Poli='I01'
--DROP TABLE Kdaid

--Delete  FROM kdaid

INSERT INTO Kdaid values 
('A001','P001','A01','D01','AS01')  

create table Kdak(
Kd_AntriKTP varchar(16) primary key,
ID_Pasien varchar(5) not null references DataID(ID_Pasien),
Kd_Poli varchar(10) not null references Poli(Kd_Poli),
Kd_Dokter varchar(5) not null references Dokter(Kd_Dokter),
kd_A varchar(10) not null references Asuransi(Kd_a)
)
  DROP Table Kdak

create table Poli(
Kd_Poli varchar(10) primary key not null,
Nama_Poli varchar(50),
)

--DROP TABLE Poli

INSERT INTO Poli values('A01','Umum')
INSERT INTO Poli values('B01','Saraf')
INSERT INTO Poli values('C01','Orthopedi')
INSERT INTO Poli values('D01','THT')
INSERT INTO Poli values('E01','Gigi')
INSERT INTO Poli values('F01','Anak')
INSERT INTO Poli values('G01','Kulit dan Kelamin')
INSERT INTO Poli values('E01','Bedah')
INSERT INTO Poli values('I01','Bedah Mulut')
INSERT INTO Poli values('J01','Gigi dan Mulut')
INSERT INTO Poli values('K01','Kandungan')

--DELETE FROM Poli 

DELETE FROM Poli WHERE Kd_Poli='I01'


UPDATE Poli Set Kd_Poli = 'J01' WHERE  Nama_Poli='Kandungan'
UPDATE Poli Set Nama_Poli='Penyakit Dalam' WHERE Kd_Poli = 'H01'
UPDATE Poli Set Nama_Poli='Mata' WHERE Kd_Poli = 'I01'
UPDATE Poli Set Nama_Poli= 'Bedah' WHERE Kd_Poli = ''
UPDATE Poli Set Nama_Poli='Gigi' WHERE Kd_Poli = 'F01'
UPDATE Poli Set Nama_Poli='Anak' WHERE Kd_Poli = 'F01'
UPDATE Poli Set Nama_Poli='Kulit&Kelamin' WHERE Kd_Poli = '01'
UPDATE Poli Set Nama_Poli='Bedah Saraf' WHERE Kd_Poli = 'A01'
UPDATE Poli Set Nama_Poli='Bedah Mulut' WHERE Kd_Poli = 'A01'
UPDATE Poli Set Nama_Poli='Umum' WHERE Kd_Poli = 'A01'


SELECT * FROM Poli

create table Dokter(
Kd_Dokter varchar(5) primary key not null,
Nama_Dokter varchar(20)
)

INSERT INTO Dokter values 
('D01','Jakurai'),
('D02','Shiki'),
('D03','Kaoru')
INSERT INTO Dokter values
('D04','Muzaki'),
('D05','Demian'),
('D06','Rafael'),
('D07','Anto'),
('D08','Tri'),
('D09','Agung'),
('D10','Linda'),
('D11','Rumi')

SELECT * FROM Dokter

create table Asuransi(
Kd_A varchar(10) primary key not null,
Nama_A varchar(10)
)

INSERT INTO Asuransi values('AS01','BPJS')
INSERT INTO Asuransi values('AS02','Prudential')
INSERT INTO Asuransi values('AS03','AXAMandiri')
INSERT INTO Asuransi values('AS04','BMPutera19')
INSERT INTO Asuransi values('AS05','IFinancial')
INSERT INTO Asuransi values('AS06','Jiwasraya')
INSERT INTO Asuransi values('AS07','Avrist')
INSERT INTO Asuransi values('AS08','Sinarmas')
INSERT INTO Asuransi values('AS09','Manulife')
INSERT INTO Asuransi values('AS09','Lain-Lain')


DELETE FROM Asuransi WHERE Kd_A='AS09'

SELECT * FROM Asuransi



create table DataKTP (
No_KTP varchar(16) primary key not null,
Nama_Pasien_K varchar(15),
JK_K varchar(1),
Tgl_Lahir_K date,
)

DROP Table DataKTP

create table LoginStaff (
Username char(4) primary key not null,
Password varchar(18),
Nama varchar(50)
)

create table LoginAdmin (
Username varchar(5) primary key not null,
Password varchar(18),
Nama varchar(50),
)

--DROP Table LoginAdmin
Select * FROM LoginAdmin
--DELETE FROM LoginAdmin where Username='1195'
INSERT INTO LoginAdmin values ('1195','rafly','Rafly Andrian Wicaksana')
INSERT INTO LoginAdmin values ('Admin','Admin','Rafly Andrian Wicaksana')
SELECT * FROM LoginStaff


SELECT * FROM LoginAdmin WHERE Username = '1195'
                    AND Password = 'rafly'

SELECT Username, Password, Nama as [Nama Staff] FROM LoginStaff

SELECT COUNT(Kd_antriID) as 'Antrian Pasien P005' FROM Kdaid WHERE ID_Pasien='P005'



SELECT * FROM Kdaid WHERE Kd_Poli='B02'



INSERT into LoginStaff values
('1195','rafly','Rafly Andrian Wicaksana')

INSERT into LoginAdmin values
('Rafly Andrian Wicaksana','1195','rafly')

INSERT INTO DataID values ('P002','','','')
INSERT INTO DataID values ('P003','Wicaksana','L','1999/07/29')
SELECT * FROM DataID

INSERT INTO Kdaid values ('" + KodeAID + "','" + ID + "','" + Poli + "','" + Dokter + "','" + Asuransi + "')

SELECT * FROM Kdaid
SELECT Kd_Poli FROM Poli

SELECT ID_Pasien FROM DataID SELECT Kd_Poli FROM Poli SELECT Kd_Dokter FROM Dokter SELECT Kd_A FROM Asuransi

SELECT * From LoginStaff 

UPDATE DataID SET Nama_Pasien = 'Andrian', JK_ID = 'L', Tgl_Lahir_ID = '1999/07/29' WHERE ID_Pasien = 'P002'

 DELETE FROM DataID WHERE ID_Pasien = ' P001 ' DELETE FROM Poli WHERE Kd_Poli = ' Kosong ' DELETE FROM Dokter WHERE Kd_Dokter = ' Kosong ' DELETE FROM Kdaid WHERE Kd_AntriID = 'A001'


SELECT DataID.ID_Pasien, DataID.Nama_Pasien, Poli.Nama_Poli,
                                        Dokter.Nama_Dokter, Asuransi.Nama_A, Kdaid.Kd_AntriID FROM DataID JOIN Kdaid
                                       ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli JOIN Dokter ON Dokter.Kd_Dokter=Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Kdaid.Kd_AntriID='A002'


SELECT* FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien WHERE Kd_AntriID = 'A001'

SELECT * from Kdaid


SELECT DataID.Nama_Pasien as [Nama], Poli.Nama_Poli as [Poli], Dokter.Nama_Dokter as [Dokter],
	 Asuransi.Nama_A as [Asuransi], Kdaid.Kd_AntriID as [Kode Antri] 
		FROM Kdaid JOIN DataID ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli 
						JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Nama_Dokter='Shiki' 
							AND Nama_Poli ='Mulut'




SELECT DataID.ID_Pasien as [ID Pasien] , DataID.Nama_Pasien as [Nama], Poli.Nama_Poli as [Poli] ,Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi],
                                        Kdaid.Kd_AntriID as [Kode Antrian] FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli
                                        JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Kdaid.Kd_AntriID='A001'


SELECT * FROM DataID WHERE ID_Pasien='P002'
DELETE FROM Kdaid WHERE Kd_AntriID ='P001'

SELECT * FROM Dokter
SELECT * FROM Poli
SELECT * FROM Asuransi 

SELECT COUNT(Kd_AntriID) as 'Jumlah Seluruh Antrian'  FROM Kdaid
SELECT COUNT(Kd_AntriID) as [Jumlah Antrian di Poli yang dipilih]  FROM Kdaid WHERE Kd_Poli='A01'
SELECT COUNT(Kd_AntriID) as [Jumlah Antrian di Dokter yang dipilih]  FROM Kdaid WHERE Kd_Dokter='D02'
SELECT DataID.ID_Pasien as [ID Pasien], DataID.Nama_Pasien as [Nama Pasien], Poli.Nama_Poli as [Poli],Dokter.Nama_Dokter as [Dokter], Asuransi.Nama_A as [Asuransi],
                                        Kdaid.Kd_AntriID FROM DataID JOIN Kdaid ON DataID.ID_Pasien = Kdaid.ID_Pasien JOIN Poli ON Poli.Kd_Poli = Kdaid.Kd_Poli
                                        JOIN Dokter ON Dokter.Kd_Dokter = Kdaid.Kd_Dokter JOIN Asuransi ON Asuransi.Kd_A = Kdaid.kd_A WHERE Kdaid.Kd_Dokter='D03'


ALTER AUTHORIZATION ON DATABASE::AntrianRS TO [sa];