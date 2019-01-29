-- Customer Table will remain the same, is not reimplemented
CREATE TABLE `Music_ID` (
	`ID` smallint(6) NOT NULL,
    `Album` varchar(100) UNIQUE NOT NULL,
    `ISBN` char(10) UNIQUE DEFAULT NULL,
	PRIMARY KEY (`ID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Music_Album` (
	`mAlbum` varchar(100) NOT NULL,
    `Artist` varchar(50) NOT NULL,
    `Songs` varchar(1000) NOT NULL,
    KEY `FK_Album` (`mAlbum`),
	FOREIGN KEY (`mAlbum`) REFERENCES `Music_ID` (`Album`) ON DELETE NO ACTION ON UPDATE NO ACTION
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Music_ISBN` (
	`mISBN` char(10) DEFAULT NULL,
    `Price` decimal(19,4) DEFAULT NULL,
    KEY `FK_ISBN` (`mISBN`),
	FOREIGN KEY (`mISBN`) REFERENCES `Music_ID` (`ISBN`) ON DELETE NO ACTION ON UPDATE NO ACTION
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `Norm_Ratings` (
	`Music_ID` smallint(6) NOT NULL,
    `Customer_ID` int(11) NOT NULL,
    `Rating` smallint(6) DEFAULT NULL,
    KEY `FK_Music` (`Music_ID`),
    KEY `FK_Customer` (`Customer_ID`),
    CONSTRAINT `FK_Music` FOREIGN KEY (`Music_ID`) REFERENCES `Music_ID` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT `FK_Customer` FOREIGN KEY (`Customer_ID`) References `Customer` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
)ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- Transfer over from previous DB

INSERT into `Music_ID` (`ID`, `Album`, `ISBN`)
SELECT `ID`, `Album`, `ISBN`
FROM `Music`;

INSERT into `Music_Album` (`mAlbum`, `Artist`,`Songs`)
SELECT `Album`, `Artist`, `Songs`
FROM `Music`;

INSERT into `Music_ISBN` (`mISBN`, `Price`)
SELECT `ISBN`, `Price`
FROM `Music`;

INSERT into `Norm_Ratings` (`Music_ID`, `Customer_ID`, `Rating`)
SELECT `Music_ID`, `Customer_ID`, `Rating`
FROM `Ratings`;
