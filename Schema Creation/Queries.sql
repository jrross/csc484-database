/*Required Queries*/
/*A*/
SELECT miles, lanes
FROM tollway
WHERE CompletionYear < 1990

/*B*/
SELECT fname, lname, liscensenum
FROM Driver, Vehicle
WHERE DriverID = LiscenseNum
GROUP BY lname, fname, LiscenseNum
HAVING COUNT(*) > 2

/*C*/
SELECT  TOP 3 MileMarker, TollgateID
FROM Tollgate, ETCSensor
WHERE tollID = TollgateID
GROUP BY MileMarker, TollgateID
ORDER BY COUNT(*) DESC

/*D*/
SELECT  fname, lname, PlateID
FROM Vehicle, Driver, ETCSEnsor, TollGate
WHERE TollwID = 1 AND Etag = Et AND liscenseNum = DriverID AND TollgateID = TollID
GROUP BY lname, fname, PlateID
HAVING COUNT(*) >= 2

/*E*/
SELECT fname, lname
FROM Driver, Vehicle, ETCSensor, tollGate, tollWay
WHERE tollID = TollgateID AND Etag = Et AND DriverID = LiscenseNum AND tollwayID = tollwID
GROUP BY lname, fname
HAVING COUNT(*) > 2


/*CUSTOM QUERIES*/

/*1 Displays the names of all the people who own two or more medium sized cars cars*/
SELECT fname, lname
FROM Driver
WHERE LiscenseNum IN
   (SELECT DriverID
	FROM Vehicle
	WHERE size = 'm' OR size = 'M'
	GROUP BY DriverID
	HAVING COUNT(*) > 1)

/*2 Displays all TollGates located on Tollway #1 */
SELECT TollGateID
FROM TollGate
WHERE TollwID IN
	(SELECT TollWayID
	 FROM TollWay
	 WHERE TollWayID = 1)

/*3 Displays all liscense plates and sizes for vehicles owned by Mary Oliver and orders by size*/
SELECT size, PlateID
FROM Vehicle
WHERE DriverID IN
	(SELECT LiscenseNum
	 FROM Driver
	 WHERE fname = 'Mary' AND lname = 'Oliver')/*this could also be changed to be more precise by locating with ID*/
ORDER BY size