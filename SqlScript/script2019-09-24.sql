CREATE TABLE `product` (
  `Id` int(11) NOT NULL,
  `Name` text NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `UpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


Insert into category(`Id`,`Name`,`CreatedDate`,`UpdatedDate`) values('1','Đèn loại 1','2019/08/02','2019/08/02');

Insert into category(`Id`,`Name`,`CreatedDate`,`UpdatedDate`) values('2','Đèn loại 2','2019/08/02','2019/08/02');

Insert into category(`Id`,`Name`,`CreatedDate`,`UpdatedDate`) values('3','Đèn loại 3','2019/08/02','2019/08/02');

Insert into product(`Id`,`Name`,`CategoryId`,`CreatedDate`,`UpdatedDate`) values
('1','Đèn xanh','1','2019/08/02','2019/08/02'),
('2','Đèn xám','1','2019/08/02','2019/08/02'),
('3','Đèn đen','1','2019/08/02','2019/08/02'),
('4','Đèn nâu','1','2019/08/02','2019/08/02'),
('5','Đèn đá 1','2','2019/08/02','2019/08/02'),
('6','Đèn đá 2','2','2019/08/02','2019/08/02'),
('7','Đèn đá 3','2','2019/08/02','2019/08/02'),
('8','Đèn tròn','3','2019/08/02','2019/08/02');


