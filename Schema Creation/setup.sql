CREATE TABLE TollWay(
TollwayID INTEGER NOT NULL,
CompletionYear INTEGER NOT NULL,
Miles INTEGER CHECK(Miles >= 1),
Lanes INTEGER CHECK(Lanes >= 1),
PRIMARY KEY (tollwayID)
);

CREATE TABLE TollGate(
TollgateID INTEGER,
SmallRate FLOAT DEFAULT 0.1 CHECK(SmallRate >= 0),
MediumRate FLOAT DEFAULT 0.2 CHECK(MediumRate >= 0),
LargeRate FLOAT DEFAULT 0.3 CHECK(LargeRate >= 0),
MileMarker INTEGER NOT NULL,
TollwID INTEGER,
FOREIGN KEY (TollwID) REFERENCES TollWay(TollwayID),
PRIMARY KEY (tollgateID)
);

CREATE TABLE AccountInfo(
AccountNum INTEGER NOT NULL,
City CHAR(15) NOT NULL,
StateName CHAR(2) NOT NULL,
Addr CHAR(40) NOT NULL,
ZIP INTEGER,
CardNum CHAR(16) NOT NULL
PRIMARY KEY (AccountNum),
UNIQUE (CardNum)
);

CREATE TABLE Driver(
LiscenseNum INTEGER NOT NULL,
FName CHAR(15) NOT NULL,
LName CHAR(15) NOT NULL,
AccNum INTEGER,
FOREIGN KEY (AccNum) REFERENCES AccountInfo(AccountNum),
PRIMARY KEY (LiscenseNum)
);

CREATE TABLE Vehicle(
Etag INTEGER NOT NULL,
size CHAR NOT NULL CHECK(size IN ('s','S','m','M','l','L')),
PlateID VARCHAR(7) NOT NULL,
DriverID INTEGER,
PRIMARY KEY (Etag),
UNIQUE (PlateID),
FOREIGN KEY (DriverID) REFERENCES Driver(LiscenseNum)
);

CREATE TABLE ETCSensor(
ReadID INTEGER NOT NULL,
SensorTime DATETIME,
TollID INTEGER,
Et INTEGER,
PRIMARY KEY (ReadID),
FOREIGN KEY (Et) REFERENCES Vehicle(Etag),
FOREIGN KEY (TollID) REFERENCES TollGate(TollgateID)
);

/*Fill TollWay*/
INSERT INTO tollWay
VALUES ('1','1982','14','3')
INSERT INTO tollWay
VALUES ('2','2013','4','4')
INSERT INTO tollWay
VALUES ('3','2009','12','5')
INSERT INTO tollWay
VALUES ('4','1973','8','3')
INSERT INTO tollWay
VALUES ('5','2003','7','3')

/*fill TollGate*/
INSERT INTO TollGate
VALUES ('6','0.1','0.2','0.3','0', '1')
INSERT INTO TollGate
VALUES ('7','0.1','0.2','0.3','5', '2')
INSERT INTO TollGate
VALUES ('8','0.1','0.2','0.3','10', '3')
INSERT INTO TollGate
VALUES ('9','0.1','0.2','0.3','15', '4')
INSERT INTO TollGate
VALUES ('10','0.1','0.2','0.3','20', '5')

/*Fill AcountInfo*/
INSERT INTO AccountInfo
Values('11','Rapid City','SD','123 Easy Way','57702', '1234567812345678')
INSERT INTO AccountInfo
Values('12','New York','NY','1920 Red Cliff Dr','10001', '8459364597869584')
INSERT INTO AccountInfo
Values('13','Chicago','IL','12 Archipelago St','60176', '7685089753427685')
INSERT INTO AccountInfo
Values('14','Boston','MA','132 Pelican Ct','01841', '6273958464521324')
INSERT INTO AccountInfo
Values('15','Portland','OR','43 Clear Lake Blvd','97035', '7465978653647586')

/*Fill Driver*/
INSERT INTO Driver
Values('16', 'Jack','Johnson', '11')
INSERT INTO Driver
Values('17', 'Johnny','Brown', '12')
INSERT INTO Driver
Values('18', 'Mary','Oliver', '13')
INSERT INTO Driver
Values('19', 'Quinton','VonSchniegel', '14')
INSERT INTO Driver
Values('20', 'Jack','Johnson', '15')

/*Fill Vehicle*/
INSERT INTO Vehicle
Values('21','M','182frs2','18')
INSERT INTO Vehicle
Values('22','S','273kj23','18')
INSERT INTO Vehicle
Values('23','M','guyman','18')
INSERT INTO Vehicle
Values('24','L','34rt23s','19')
INSERT INTO Vehicle
Values('25','S','rt3241q','20')

/*Fill ETCSensor*/
INSERT INTO ETCsensor
Values('32','20171007','6','25')
INSERT INTO ETCSensor
Values('26','20171012','9','21')
INSERT INTO ETCSensor
Values('27','20171013','6','25')
INSERT INTO ETCSensor
Values('28','20171011','8','24')
INSERT INTO ETCSensor
Values('29','20171018','9','24')
INSERT INTO ETCSensor
Values('30','20171016','8','24')
INSERT INTO ETCsensor
Values('31','20171005','7','25')