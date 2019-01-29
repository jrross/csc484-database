CREATE TABLE Company(
CompName CHAR(20) NOT NULL,
EIN INTEGER NOT NULL UNIQUE,
addr CHAR(20),
PRIMARY KEY (CompName)
);

CREATE TABLE Phone(
number CHAR(10) CHECK(ISNUMERIC(number) = 1),
CompanyName CHAR(20) NOT NULL,
PRIMARY KEY (number),
FOREIGN KEY (CompanyName) REFERENCES Company(CompName)
ON DELETE CASCADE
);

CREATE TABLE Equipment(
equipID INTEGER,
manufacturer CHAR(20),
yearPurchased SMALLINT,
price DECIMAL(11,2),
PRIMARY KEY(equipID),
company CHAR(20) NOT NULL,
FOREIGN KEY (company) REFERENCES Company(CompName)
ON DELETE CASCADE
);

CREATE TABLE Engineer(
engNo INTEGER,
fname CHAR(15) NOT NULL,
mname CHAR(15),
lname CHAR(15) NOT NULL,
salary INTEGER NOT NULL,
degree CHAR(20) NOT NULL,
dateJoined DATETIME NOT NULL,
company CHAR(20),
FOREIGN KEY (company) REFERENCES Company(CompName)
ON DELETE CASCADE,
PRIMARY KEY (engNo)
);

CREATE TABLE Specialty(
specialty CHAR(20),
eng INTEGER,
PRIMARY KEY (specialty,eng),--composite key to allow for multiple uses of the same specialty
FOREIGN KEY (eng) REFERENCES Engineer(engNo)
ON DELETE CASCADE
);

CREATE TABLE Fault(
faultID INTEGER,
faultDescription CHAR(100) NOT NULL,
equip INTEGER NOT NULL,
PRIMARY KEY (faultID),
FOREIGN KEY (equip) REFERENCES Equipment(equipID)
ON DELETE CASCADE
);

CREATE TABLE Repairs(	--bridge between engineer and fault
RepairID INTEGER,
fault INTEGER,
engineer INTEGER,
FaultDate DATETIME NOT NULL,
PRIMARY KEY (RepairID),
FOREIGN KEY (Fault) REFERENCES Fault(faultID),
FOREIGN KEY (Engineer) REFERENCES Engineer(engNo)
ON DELETE CASCADE
);

CREATE TABLE ElectFault(
ePartNum INTEGER NOT NULL,
fault INTEGER,
PRIMARY KEY (fault),
FOREIGN KEY (fault) REFERENCES Fault(faultID)
ON DELETE CASCADE
);

CREATE TABLE MechFault(
mPartNum INTEGER NOT NULL,
fault INTEGER,
PRIMARY KEY (fault),
FOREIGN KEY (fault) REFERENCES Fault(faultID)
ON DELETE CASCADE
);

CREATE VIEW comp AS
	SELECT CompName, EIN, addr, COUNT(DISTINCT EngNo) Engineers
	FROM Company
		LEFT OUTER JOIN Engineer ON company = CompName
	Group by CompName, EIN, addr

--Fill company
INSERT INTO Company
VALUES('Janes Company','192837465','123 street st')
INSERT INTO Company
VALUES('Toms Company','937254938','456 lane ln')
INSERT INTO Company
Values('Johns Company','447384957','987 boulevard blvd')

--Give phone numbers for companies
INSERT INTO Phone
VALUES('9182393824','Janes Company')
INSERT INTO Phone
VALUES('8375938474','Toms Company')
INSERT INTO Phone
VALUES('8485948372','Johns Company')

--Fill equipment
INSERT INTO Equipment
VALUES('1','manufacturer x','1993','123.23','Janes Company')
INSERT INTO Equipment
VALUES('2','manufacturer y','2012','1082.34','Toms Company')
INSERT INTO Equipment
VALUES('3','manufacturer z','2016','983.90','Johns Company')

--Fill engineers
INSERT INTO Engineer
VALUES('4','Jake','k','Johnson','80000','Mechanical','20120618','Janes Company')
INSERT INTO Engineer
VALUES('5','Aaron','h','Henries','70000','Chemical','20120618','Janes Company')
INSERT INTO Engineer
VALUES('6','Charles','n','Hartford','60000','Industrial','20120618','Toms Company')

--Give engineers specialties
INSERT INTO Specialty
VALUES('dynamic systems','4')
INSERT INTO Specialty
VALUES('liquid systems','5')
INSERT INTO Specialty
VALUES('Support structures','6')

--Fill Faults
INSERT INTO Fault
VALUES('7','Leaking','1')
INSERT INTO Fault
VALUES('8','Will not move','2')
INSERT INTO Fault
VALUES('9','Leaking','2')
INSERT INTO Fault
VALUES('10','unoperational','3')

--Give repair relations
INSERT INTO Repairs
VALUES('10','7','6','20120618 10:34:09 AM')
INSERT INTO Repairs
VALUES('11','8','6','20150719 01:15:06 PM')
INSERT INTO Repairs
VALUES('12','9','7','20170218 11:56:01 AM')

--specify faults
INSERT INTO MechFault
VALUES('13','7')
INSERT INTO ElectFault
VALUES('14','8')
INSERT INTO MechFault
VALUES('15','9')

--Limit the number of phone numbers to 3 per company
CREATE TRIGGER MaxPhone
       ON Phone
       AFTER INSERT
AS
BEGIN
       DECLARE @count BIGINT;
       DECLARE @temp BIGINT;
       SELECT @temp = number from inserted
       SELECT @count = count(*) from  Phone AS O JOIN inserted ON O.CompanyName = inserted.CompanyName
       IF @count>3
       BEGIN
              DELETE FROM Phone WHERE number = @temp;
       END;
End;

CREATE TRIGGER MaxSpecialty
       ON Specialty
       AFTER INSERT
AS
BEGIN
       DECLARE @count BIGINT;
       DECLARE @temp VARCHAR(20);
       SELECT @temp = specialty from inserted
       SELECT @count = count(*) from  Specialty AS O JOIN inserted ON O.eng = inserted.eng
       IF @count>10
       BEGIN
              DELETE FROM Specialty WHERE specialty = @temp;
       END;
End;