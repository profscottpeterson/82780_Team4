BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Orders` (
	`OrderID`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`CustID`	INTEGER,
	`Date`	TEXT NOT NULL,
	FOREIGN KEY(`CustID`) REFERENCES `Customer`(`CustID`)
);
INSERT INTO `Orders` VALUES (2,1,'12/12/12');
CREATE TABLE IF NOT EXISTS `Inventory` (
	`InvID`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`ItemName`	TEXT NOT NULL,
	`Price`	REAL NOT NULL
);
INSERT INTO `Inventory` VALUES (1,'Nails',12.3);
INSERT INTO `Inventory` VALUES (2,'Hammer',30.5);
CREATE TABLE IF NOT EXISTS `Inv_Ord` (
	`ID`	integer PRIMARY KEY AUTOINCREMENT,
	`InvID`	INTEGER,
	`OrderID`	INTEGER,
	FOREIGN KEY(`OrderID`) REFERENCES `Orders`(`OrderID`),
	FOREIGN KEY(`InvID`) REFERENCES `Inventory`(`InvID`)
);
INSERT INTO `Inv_Ord` VALUES (1,1,2);
CREATE TABLE IF NOT EXISTS `Customer` (
	`CustID`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`FirstName`	TEXT,
	`LastName`	TEXT,
	`Email`	TEXT NOT NULL
);
INSERT INTO `Customer` VALUES (1,'John','Smith','js@gm.com');
INSERT INTO `Customer` VALUES (2,'Tom','Jonhs','tj@gm.com');
COMMIT;
