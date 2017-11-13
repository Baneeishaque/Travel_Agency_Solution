-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: alrayan
-- ------------------------------------------------------
-- Server version	5.7.13-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `id_client` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  `address` varchar(100) NOT NULL,
  `mobile` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL DEFAULT 'K',
  PRIMARY KEY (`id_client`),
  UNIQUE KEY `id_money_client_UNIQUE` (`id_client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1000,'cv','cvd','123','K'),(1001,'cv2','hhh','678','K'),(1002,'cv3','cv3a','6566','K'),(1003,'cv4','cv4','3445','K'),(1004,'oo','pop','[p]]p','K'),(1005,'oio','popp','[o[[p','K'),(1006,'bhn','bb','bb','K');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `collection`
--

DROP TABLE IF EXISTS `collection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `collection` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` varchar(45) NOT NULL,
  `particulars` varchar(45) NOT NULL,
  `mode` varchar(45) NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `balance` decimal(10,0) NOT NULL,
  `id_operation` int(11) NOT NULL,
  `operation` varchar(45) NOT NULL,
  `benefit` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `collection`
--

LOCK TABLES `collection` WRITE;
/*!40000 ALTER TABLE `collection` DISABLE KEYS */;
INSERT INTO `collection` VALUES (33,'18 July 2016 09:14:17','Send Money By cv Advance 1 (ID : 1000 )','Credit',24,24,9,'Send',4),(34,'18 July 2016 09:17:43','Send Money By cv2 Advance 1 (ID : 1001 )','Credit',16,40,10,'Send',3),(35,'18 July 2016 09:17:43','Send Money By cv2 Advance 2 (ID : 1001 )','Credit',16,56,10,'Send',3),(36,'18 July 2016 09:17:43','Send Money By cv2 Advance 3 (ID : 1001 )','Credit',16,72,10,'Send',3),(37,'18 July 2016 09:18:41','Receive Money For cv (ID : 1000 )','Credit',15000,15072,12,'Receive',64),(38,'18 July 2016 09:19:31','Receive Money For cv3 (ID : 1002 )','Credit',1500,16572,13,'Receive',2),(40,'18 July 2016 09:30:09','Ticket Issue For cv3 (ID : 1002 )','Credit',60,16632,13,'Ticket',8),(41,'18 July 2016 09:36:09','Visa Issue For cv2 (ID : 1001 )','Credit',60,16692,2,'Visa',10),(42,'18 July 2016 09:36:30','Visa Issue For oo (ID : 1004 )','Credit',20,16712,3,'Visa',10),(43,'18 July 2016 09:36:50','Ticket Issue For oio (ID : 1005 )','Credit',20,16732,14,'Ticket',10),(44,'18 July 2016 09:45:56','Send Money By bhn Advance 1 (ID : 1006 )','Credit',400,17132,11,'Send',67),(45,'18 July 2016 09:45:56','Send Money By bhn Advance 2 (ID : 1006 )','Credit',500,17632,11,'Send',67),(46,'18 July 2016 09:54:18','Visa Issue For cv (ID : 1000 )','Credit',20,17652,4,'Visa',10),(47,'18 July 2016 09:55:28','Ticket Issue For cv (ID : 1000 )','Credit',20,17672,15,'Ticket',10),(48,'21 July 2016 09:53:15','Send Money By cv3 Advance 1 (ID : 1002 )','Credit',80,17752,12,'Send',13),(49,'21 July 2016 09:53:15','Send Money By cv3 Advance 2 (ID : 1002 )','Credit',80,17832,12,'Send',13),(50,'21 July 2016 09:53:15','Send Money By cv3 Advance 3 (ID : 1002 )','Credit',80,17912,12,'Send',13),(51,'21 July 2016 10:04:11','Send Money By cv4 Advance 1 (ID : 1003 )','Credit',71,17983,13,'Send',12),(52,'21 July 2016 10:04:11','Send Money By cv4 Advance 2 (ID : 1003 )','Credit',71,18054,13,'Send',12);
/*!40000 ALTER TABLE `collection` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `collection_receive`
--

DROP TABLE IF EXISTS `collection_receive`;
/*!50001 DROP VIEW IF EXISTS `collection_receive`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `collection_receive` AS SELECT 
 1 AS `id`,
 1 AS `date`,
 1 AS `id_operation`,
 1 AS `operation`,
 1 AS `amount`,
 1 AS `id_client`,
 1 AS `benefit`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `coolection_send`
--

DROP TABLE IF EXISTS `coolection_send`;
/*!50001 DROP VIEW IF EXISTS `coolection_send`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `coolection_send` AS SELECT 
 1 AS `id`,
 1 AS `date`,
 1 AS `id_operation`,
 1 AS `operation`,
 1 AS `amount`,
 1 AS `id_client`,
 1 AS `benefit`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `exchange_rate`
--

DROP TABLE IF EXISTS `exchange_rate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `exchange_rate` (
  `id_exchange_rate` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `current_rate` decimal(10,0) NOT NULL,
  `insert_date` varchar(45) NOT NULL,
  `alter_date` varchar(45) DEFAULT NULL,
  `alterator` varchar(100) NOT NULL,
  PRIMARY KEY (`id_exchange_rate`),
  UNIQUE KEY `id_exchange_rate_UNIQUE` (`id_exchange_rate`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exchange_rate`
--

LOCK TABLES `exchange_rate` WRITE;
/*!40000 ALTER TABLE `exchange_rate` DISABLE KEYS */;
INSERT INTO `exchange_rate` VALUES (4,15,'1998-02-01 00:00:00','2015-02-14 00:00:00','Inserted by gfh, Altered by Banee'),(10,18,'2015-02-14 00:00:00','07 July 2016 16:44:12','Inserted by Banee, Altered by ban2, Altered by logined person'),(16,25,'07 July 2016 16:44:12','07 July 2016 16:44:48','Inserted by logined person, Altered by logined person'),(17,21,'07 July 2016 16:44:48','07 July 2016 18:05:55','Inserted by logined person, Altered by logined person'),(18,25,'07 July 2016 18:05:55','10 July 2016 16:40:54','Inserted by logined person, Altered by jabir'),(19,30,'10 July 2016 16:40:54','10 July 2016 16:42:31','Inserted by jabir, Altered by jabir'),(20,25,'10 July 2016 16:42:31','10 July 2016 16:43:16','Inserted by jabir, Altered by jabir'),(21,30,'10 July 2016 16:43:16','10 July 2016 16:43:20','Inserted by jabir, Altered by jabir'),(22,25,'10 July 2016 16:43:20','21 July 2016 06:44:26','Inserted by jabir, Altered by jabir'),(23,28,'21 July 2016 06:44:26','','Inserted by jabir');
/*!40000 ALTER TABLE `exchange_rate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `money_client`
--

DROP TABLE IF EXISTS `money_client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `money_client` (
  `id` int(11) unsigned NOT NULL,
  `name` varchar(45) NOT NULL,
  `address` varchar(100) NOT NULL,
  `mobile` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL DEFAULT 'K',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_money_client_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `money_client`
--

LOCK TABLES `money_client` WRITE;
/*!40000 ALTER TABLE `money_client` DISABLE KEYS */;
INSERT INTO `money_client` VALUES (1000,'ccdfd','cccccsed','125','R'),(1001,'bb','bbb','678','K'),(1002,'yyuy','oioioio','78878','K'),(1003,'bvbb','bnnbnn','12','K'),(1004,'bb','bbbb','45698','K'),(1005,'gfg','hghgh','gjgjjj','K'),(1006,'iui','uiiu','iiui','K'),(1007,'jkkj','jkhk','677899','K');
/*!40000 ALTER TABLE `money_client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receive_money`
--

DROP TABLE IF EXISTS `receive_money`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receive_money` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` varchar(45) NOT NULL,
  `inr` decimal(10,0) NOT NULL,
  `rate` decimal(10,0) NOT NULL,
  `benefit` decimal(10,0) NOT NULL,
  `deliver_aed` decimal(10,0) NOT NULL,
  `id_client` int(11) NOT NULL,
  `agency_rate` decimal(10,0) NOT NULL,
  `actual_aed` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receive_money`
--

LOCK TABLES `receive_money` WRITE;
/*!40000 ALTER TABLE `receive_money` DISABLE KEYS */;
INSERT INTO `receive_money` VALUES (12,'18 July 2016 09:18:41',15000,25,64,536,1000,28,600),(13,'18 July 2016 09:19:31',1500,25,2,58,1002,26,60);
/*!40000 ALTER TABLE `receive_money` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `send_money`
--

DROP TABLE IF EXISTS `send_money`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `send_money` (
  `id_send_money` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` varchar(45) NOT NULL,
  `rate` decimal(10,0) NOT NULL,
  `aed` decimal(10,0) NOT NULL,
  `inr` decimal(10,0) NOT NULL,
  `benefit` decimal(10,0) NOT NULL,
  `total_aed` decimal(10,0) NOT NULL,
  `advance1` decimal(10,0) NOT NULL,
  `advance2` decimal(10,0) NOT NULL,
  `advance3` decimal(10,0) NOT NULL,
  `balance` decimal(10,0) NOT NULL,
  `advance1_date` varchar(45) NOT NULL,
  `advance2_date` varchar(45) NOT NULL,
  `advance3_date` varchar(45) NOT NULL,
  `id_client` int(11) NOT NULL,
  PRIMARY KEY (`id_send_money`),
  UNIQUE KEY `id_send_money_UNIQUE` (`id_send_money`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `send_money`
--

LOCK TABLES `send_money` WRITE;
/*!40000 ALTER TABLE `send_money` DISABLE KEYS */;
INSERT INTO `send_money` VALUES (12,'21 July 2016 09:53:15',25,200,5000,40,240,80,80,80,0,'21 July 2016','21 August 2016','21 September 2016',1002),(13,'21 July 2016 10:04:11',28,179,5000,36,214,71,71,0,71,'21 July 2016','21 August 2016','21 September 2016',1003);
/*!40000 ALTER TABLE `send_money` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket_one`
--

DROP TABLE IF EXISTS `ticket_one`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ticket_one` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `airline` varchar(45) NOT NULL,
  `connection` varchar(45) NOT NULL,
  `date_time` varchar(45) NOT NULL,
  `from` varchar(45) NOT NULL,
  `to` varchar(45) NOT NULL,
  `class` varchar(45) NOT NULL,
  `pnr` varchar(45) NOT NULL,
  `issue` varchar(45) NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `commision` decimal(10,0) NOT NULL,
  `total` decimal(10,0) NOT NULL,
  `date` varchar(45) NOT NULL,
  `id_client` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket_one`
--

LOCK TABLES `ticket_one` WRITE;
/*!40000 ALTER TABLE `ticket_one` DISABLE KEYS */;
INSERT INTO `ticket_one` VALUES (13,'ghh','Direct','18 July 2016 00:00','tt','tt2','2','245','gh',52,8,60,'18 July 2016 09:30:09',1002),(14,'[p[','Direct','18 July 2016 25',';;\'l','\'\';','hjhj','kjl','k;;',10,10,20,'18 July 2016 09:36:50',1005),(15,'fyyyyt','Direct','18 July 2016 10','ikj','kjk','kkjkj','i','kjk',10,10,20,'18 July 2016 09:55:28',1000);
/*!40000 ALTER TABLE `ticket_one` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `travel_client`
--

DROP TABLE IF EXISTS `travel_client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `travel_client` (
  `id` int(11) unsigned NOT NULL,
  `name` varchar(45) NOT NULL,
  `address` varchar(100) NOT NULL,
  `mobile` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL DEFAULT 'K',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_travel_client_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `travel_client`
--

LOCK TABLES `travel_client` WRITE;
/*!40000 ALTER TABLE `travel_client` DISABLE KEYS */;
INSERT INTO `travel_client` VALUES (1000,'vbn','mmmn','145','R'),(1001,'ip','yuiy','09','K');
/*!40000 ALTER TABLE `travel_client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `iduser` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `create_time` varchar(45) NOT NULL,
  PRIMARY KEY (`iduser`,`username`),
  UNIQUE KEY `iduser_UNIQUE` (`iduser`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'jabir','jabir','2016-07-17 18:33:53');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vissa`
--

DROP TABLE IF EXISTS `vissa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vissa` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `vissa_type` varchar(45) NOT NULL,
  `permit_number` varchar(45) NOT NULL,
  `issue_date` varchar(45) NOT NULL,
  `date` varchar(45) NOT NULL,
  `issue_place` varchar(45) NOT NULL,
  `valid_till` varchar(45) NOT NULL,
  `emigration_date` varchar(45) NOT NULL,
  `expiry_date` varchar(45) NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `commision` decimal(10,0) NOT NULL,
  `total_amount` decimal(10,0) NOT NULL,
  `id_client` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vissa`
--

LOCK TABLES `vissa` WRITE;
/*!40000 ALTER TABLE `vissa` DISABLE KEYS */;
INSERT INTO `vissa` VALUES (2,'6 Month','67','18 July 2016','18 July 2016 09:36:09','h','18 July 2016','18 July 2016','18 July 2016',50,10,60,1001),(3,'Permanent','jjkl','18 July 2016','18 July 2016 09:36:30','ggh','18 July 2016','18 July 2016','18 July 2016',10,10,20,1004),(4,'3 Month','hhh','18 July 2016','18 July 2016 09:54:18','hhh','18 July 2016','18 July 2016','18 July 2016',10,10,20,1000);
/*!40000 ALTER TABLE `vissa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'alrayan'
--

--
-- Dumping routines for database 'alrayan'
--
/*!50003 DROP PROCEDURE IF EXISTS `client` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `client`(
IN id_client varchar(45),IN client_name varchar(45),IN client_address varchar(100),
IN client_mobile varchar(45))
BEGIN
	INSERT INTO `alrayan`.`client`
(id_client,
`name`,
`address`,
`mobile`)
VALUES
(id_client,client_name,
client_address,
client_mobile);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `exchange_rate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `exchange_rate`(
IN new_current_rate decimal,IN insert_date varchar(45), 
IN new_alterator varchar(45), IN flag int)
BEGIN
	

	declare last_exchange_rate_id int default 0;
	declare last_exchange_rate decimal default 0;
	declare last_alterator varchar(45) default "";

	DECLARE loop_break INT DEFAULT 0;

	declare cursor_get_last_exchange_rate_id CURSOR for select id_exchange_rate,
    current_rate,alterator from exchange_rate where id_exchange_rate=(select 
    max(id_exchange_rate) from exchange_rate);

	DECLARE CONTINUE HANDLER FOR NOT FOUND SET loop_break =1 ;
    
    OPEN cursor_get_last_exchange_rate_id;
		
		FETCH cursor_get_last_exchange_rate_id INTO last_exchange_rate_id,
        last_exchange_rate,last_alterator;
	
	CLOSE cursor_get_last_exchange_rate_id;
    
	if flag=1 then
		select last_exchange_rate_id ,last_exchange_rate,last_alterator;
        end if;
	
    if flag=2 then
    
    
   

    
    INSERT INTO `alrayan`.`exchange_rate`
(
`current_rate`,
`insert_date`,
`alter_date`,
`alterator`)
VALUES
(
new_current_rate,
insert_date,
'',
concat("Inserted by ",new_alterator));

 UPDATE `alrayan`.`exchange_rate`
SET

`alter_date` = insert_date,
`alterator` =  concat(last_alterator,
", Altered by ",new_alterator)
WHERE `id_exchange_rate` = last_exchange_rate_id;

end if; 

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_client` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_client`(
IN flag int,IN search_id int)
BEGIN
if flag=1 then
	SELECT `id_client`,
    `name`
FROM `alrayan`.`client`;
end if;
if flag=2 then
	SELECT `id_client`,
    `name`,
    `address`,
    `mobile`
FROM `client` where `client`.`id_client`=search_id;

end if;

if flag=3 then
select max(id_client) from `client`;
end if;

if flag=4 then
SELECT `send_money`.`id_send_money`,

   `send_money`.`id_client`,
   `client`.`name`,
   
    `send_money`.`advance1`,
    `send_money`.`advance1_date`,
    
    `send_money`.`advance2`,
    `send_money`.`advance2_date`,
    
    `send_money`.`advance3`,
    `send_money`.`advance3_date`,
      `send_money`.`total_aed`,
    `send_money`.`balance`
    
    
    
    
FROM `alrayan`.`send_money`,`alrayan`.`client` where `send_money`.`balance`!=0 
AND `send_money`.`id_client`=`client`.`id_client`;

end if;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_collection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_collection`(
IN flag int)
BEGIN
	DECLARE loop_break INT DEFAULT 0;
	DECLARE id_client INT DEFAULT 0;
	declare rawDetail varchar(500) default "";
	declare collection_date varchar(50) default "";
	declare collection_operation varchar(50) default "";
	declare collection_amount decimal DEFAULT 0;
    declare sum_amount decimal DEFAULT 0;
	declare benefit decimal DEFAULT 0;
    declare sum_benefit decimal DEFAULT 0;
		
	declare cursor_get_send_data CURSOR for SELECT 
		`collection`.`date`,
        `send_money`.`id_client`,

		`collection`.`operation`,
		
        `send_money`.`benefit`,
		`collection`.`amount`
	FROM `alrayan`.`collection`,`alrayan`.`send_money` where operation='Send' 
    AND `id_operation`=`id_send_money`;
    
    declare cursor_get_ticket_data CURSOR for SELECT 
		`collection`.`date`,
        `ticket_one`.`id_client`,

		`collection`.`operation`,
		
        `ticket_one`.`commision`,
		`collection`.`amount`
	FROM `alrayan`.`collection`,`alrayan`.`ticket_one` where operation='Ticket' 
    AND `id_operation`=`ticket_one`.`id`;
    
    declare cursor_get_visa_data CURSOR for SELECT 
		`collection`.`date`,
        `vissa`.`id_client`,

		`collection`.`operation`,
		
        `vissa`.`commision`,
		`collection`.`amount`
	FROM `alrayan`.`collection`,`alrayan`.`vissa` where operation='Visa' 
    AND `id_operation`=`vissa`.`id`;


	declare cursor_get_receive_data CURSOR for SELECT 
		`collection`.`date`,
        `receive_money`.`id_client`,

		`collection`.`operation`,
		
        `receive_money`.`benefit`,
		`collection`.`amount`
	FROM `alrayan`.`collection`,`alrayan`.`receive_money` where operation='Receive' 
    AND `id_operation`=`receive_money`.`id`;
    

	DECLARE CONTINUE HANDLER FOR NOT FOUND SET loop_break =1 ;
	if flag=1 then
			SELECT `collection`.`id`,
			`collection`.`date`,
			`collection`.`id_operation`,
			`collection`.`operation`,
			`collection`.`amount`
		FROM `alrayan`.`collection`;
	end if;
	if flag=2 then
		set sum_benefit=0;
        set sum_amount=0;
		OPEN cursor_get_send_data;
			get_data: loop
				FETCH cursor_get_send_data INTO 
					collection_date,id_client,collection_operation,
                    benefit,collection_amount;
		  
					set sum_benefit=sum_benefit+benefit;
					set sum_amount=sum_amount+collection_amount;
					set rawDetail = concat(rawDetail,"-",collection_date,"~",
                    id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount,
                        "~",sum_benefit,"~",sum_amount);
			
				
                
				
				if loop_break=1 then
					leave get_data ;
                    
				end if;
                
           /*     set rawDetail = concat(rawDetail,"-",collection_date,"~",id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount); */
			
				
			end loop get_data ;	
				
			
			CLOSE cursor_get_send_data;
			
			select rawDetail;
			
	end if;
    
    if flag=3 then
		set sum_benefit=0;
        set sum_amount=0;
		OPEN cursor_get_receive_data;
			get_data: loop
				FETCH cursor_get_receive_data INTO 
					collection_date,id_client,collection_operation,
                    benefit,collection_amount;
		  
			
					set sum_benefit=sum_benefit+benefit;
					set sum_amount=sum_amount+collection_amount;
					set rawDetail = concat(rawDetail,"-",collection_date,"~",
                    id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount,
                        "~",sum_benefit,"~",sum_amount);
				
                
				
				if loop_break=1 then
					leave get_data ;
                    
				end if;
                
           /*     set rawDetail = concat(rawDetail,"-",collection_date,"~",id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount); */
			
				
			end loop get_data ;	
				
			
			CLOSE cursor_get_receive_data;
			
			select rawDetail;
			
	end if;
    
    if flag=4 then
		set sum_benefit=0;
        set sum_amount=0;
		OPEN cursor_get_ticket_data;
			get_data: loop
				FETCH cursor_get_ticket_data INTO 
					collection_date,id_client,collection_operation,
                    benefit,collection_amount;
		  
			
					set sum_benefit=sum_benefit+benefit;
					set sum_amount=sum_amount+collection_amount;
					set rawDetail = concat(rawDetail,"-",collection_date,"~",
                    id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount,
                        "~",sum_benefit,"~",sum_amount);
				
                
				
				if loop_break=1 then
					leave get_data ;
                    
				end if;
                
           /*     set rawDetail = concat(rawDetail,"-",collection_date,"~",id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount); */
			
				
			end loop get_data ;	
				
			
			CLOSE cursor_get_ticket_data;
			
			select rawDetail;
			
	end if;
    
    if flag=5 then
		set sum_benefit=0;
        set sum_amount=0;
		OPEN cursor_get_visa_data;
			get_data: loop
				FETCH cursor_get_visa_data INTO 
					collection_date,id_client,collection_operation,
                    benefit,collection_amount;
		  
			
					set sum_benefit=sum_benefit+benefit;
					set sum_amount=sum_amount+collection_amount;
					set rawDetail = concat(rawDetail,"-",collection_date,"~",
                    id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount,
                        "~",sum_benefit,"~",sum_amount);
				
                
				
				if loop_break=1 then
					leave get_data ;
                    
				end if;
                
           /*     set rawDetail = concat(rawDetail,"-",collection_date,"~",id_client,"~",collection_operation
						,"~",benefit,"~",collection_amount); */
			
				
			end loop get_data ;	
				
			
			CLOSE cursor_get_visa_data;
			
			select rawDetail;
			
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `receive_money` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `receive_money`(
IN new_date varchar(45),
IN  inr decimal ,
IN  rate decimal,
IN  benefit decimal,
IN  deliver_aed decimal,
IN  actual_aed decimal,
IN  agency_rate decimal,
IN  id_client int)
BEGIN
declare client_name varchar(45) default "";
declare old_balance decimal default 0;
DECLARE loop_break INT DEFAULT 0;
DECLARE insert_id INT DEFAULT 0;
declare cursor_get_insert_id CURSOR for SELECT last_insert_id() FROM alrayan.send_money;


	declare cursor_get_client_name CURSOR for SELECT  `client`.`name`FROM `alrayan`.`client` 
    where `client`.`id_client`=id_client;
    
    declare cursor_get_old_balance CURSOR for SELECT  `collection`.`balance`FROM `alrayan`.`collection` 
    where `id`=(select  max(id) from collection);

	DECLARE CONTINUE HANDLER FOR NOT FOUND SET loop_break =1 ;
    
    OPEN cursor_get_client_name;
		
		FETCH cursor_get_client_name INTO client_name;
	
	CLOSE cursor_get_client_name;
    
     OPEN cursor_get_old_balance;
		
		FETCH cursor_get_old_balance INTO old_balance;
	
	CLOSE cursor_get_old_balance;
INSERT INTO `alrayan`.`receive_money`
(
`date`,
`inr`,
`rate`,
`benefit`,
`deliver_aed`,
`id_client`,
`agency_rate`,
`actual_aed`)
VALUES
(new_date,
inr,
rate,
benefit,
deliver_aed,
id_client,
agency_rate,
actual_aed);
OPEN cursor_get_insert_id;
		
		FETCH cursor_get_insert_id INTO insert_id;
	
	CLOSE cursor_get_insert_id;
INSERT INTO `alrayan`.`collection`
(
`date`,
`particulars`,
`mode`,
`amount`,
`balance`,
`id_operation`,
`operation`,
    benefit)
VALUES
(
new_date,
concat("Receive Money For ",client_name," (ID : ",id_client," )"),
"Credit",
inr,
old_balance+inr,
insert_id,
"Receive",
    benefit);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `send_money` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `send_money`(IN new_date varchar(45), IN
rate decimal, IN
aed decimal, IN
inr decimal, IN
benefit decimal, IN
total_aed decimal, IN
advance1 decimal, IN
advance2 decimal, IN
advance3 decimal, IN
balance decimal, IN
advance1_date varchar(45), IN
advance2_date varchar(45), IN
advance3_date varchar(45), IN
id_client int)
BEGIN
	declare client_name varchar(45) default "";
	declare old_balance decimal default 0;
	DECLARE loop_break INT DEFAULT 0;
	DECLARE insert_id INT DEFAULT 0;

	declare cursor_get_insert_id CURSOR for SELECT last_insert_id() FROM alrayan.send_money;
    
	declare cursor_get_client_name CURSOR for SELECT  `client`.`name`FROM `alrayan`.`client` 
    where `client`.`id_client`=id_client;
    
    
    declare cursor_get_old_balance CURSOR for SELECT  `collection`.`balance`FROM `alrayan`.`collection` 
    where `id`=(select  max(id) from collection);

	DECLARE CONTINUE HANDLER FOR NOT FOUND SET loop_break =1 ;
    
    OPEN cursor_get_client_name;
		
		FETCH cursor_get_client_name INTO client_name;
	
	CLOSE cursor_get_client_name;
    
     OPEN cursor_get_old_balance;
		
		FETCH cursor_get_old_balance INTO old_balance;
	
	CLOSE cursor_get_old_balance;
    
	INSERT INTO `alrayan`.`send_money`
	(
	`date`,
	`rate`,
	`aed`,
	`inr`,
	`benefit`,
	`total_aed`,
	`advance1`,
	`advance2`,
	`advance3`,
	`balance`,
	`advance1_date`,
	`advance2_date`,
	`advance3_date`,
	`id_client`)
	VALUES
	(
	new_date,
	rate,
	aed,
	inr,
	benefit,
	total_aed,
	advance1,
	advance2,
	advance3,
	balance,
	advance1_date,
	advance2_date,
	advance3_date,
	id_client);

	OPEN cursor_get_insert_id;
		
		FETCH cursor_get_insert_id INTO insert_id;
	
	CLOSE cursor_get_insert_id;

	if advance1!=0 then

		INSERT INTO `alrayan`.`collection`
		(
		`date`,
		`particulars`,
		`mode`,
		`amount`,
		`balance`,
		`id_operation`,
		`operation`,
    benefit)
		VALUES
		(
		new_date,
		concat("Send Money By ",client_name," Advance 1 (ID : ",id_client," )"),
		"Credit",
		advance1,
		old_balance+advance1,
		insert_id,
		"Send",
    benefit/3);
	end if;

	OPEN cursor_get_old_balance;
		
			FETCH cursor_get_old_balance INTO old_balance;
	
	CLOSE cursor_get_old_balance;

	if advance2!=0 then
		INSERT INTO `alrayan`.`collection`
		(
		`date`,
		`particulars`,
		`mode`,
		`amount`,
		`balance`,
		`id_operation`,
		`operation`,
    benefit)
		VALUES
		(
		new_date,
		concat("Send Money By ",client_name," Advance 2 (ID : ",id_client," )"),
		"Credit",
		advance2,
		old_balance+advance2,
		insert_id,
		"Send",
    benefit/3);
	end if;

	OPEN cursor_get_old_balance;
		
			FETCH cursor_get_old_balance INTO old_balance;
	
	CLOSE cursor_get_old_balance;
	
	if advance3!=0 then
		INSERT INTO `alrayan`.`collection`
		(
		`date`,
		`particulars`,
		`mode`,
		`amount`,
		`balance`,
		`id_operation`,
		`operation`,
    benefit)
		VALUES
		(
		new_date,
		concat("Send Money By ",client_name," Advance 3 (ID : ",id_client," )"),
		"Credit",
		advance3,
		old_balance+advance3,
		insert_id,
		"Send",
    benefit/3);
	end if;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ticket_one` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ticket_one`(airline varchar(45) , 
		IN new_date varchar(45),
		IN new_connection varchar(45) , 
        IN date_time varchar(45) , IN
		new_from varchar(45) , IN
		new_to varchar(45) , IN
		class varchar(45) , IN
		pnr varchar(45) , IN
		issue varchar(45) , IN
		amount decimal , IN
		commision decimal , IN
		total decimal,
        IN id_client int)
BEGIN
	 DECLARE insert_id INT DEFAULT 0;
    declare old_balance decimal default 0;
	DECLARE loop_break INT DEFAULT 0;
	declare client_name varchar(45) default "";

	declare cursor_get_client_name CURSOR for SELECT  `client`.`name`FROM `alrayan`.`client` 
    where `client`.`id_client`=id_client;

	declare cursor_get_insert_id CURSOR for SELECT last_insert_id() FROM alrayan.ticket_one;
    
    declare cursor_get_old_balance CURSOR for SELECT  `collection`.`balance`FROM `alrayan`.`collection` 
    where `id`=(select  max(id) from collection);


	DECLARE CONTINUE HANDLER FOR NOT FOUND SET loop_break =1 ;
    
    INSERT INTO `alrayan`.`ticket_one`
		(
		`airline`,`date`,
		`connection`,
		`date_time`,
		`from`,
		`to`,
		`class`,
		`pnr`,
		`issue`,
		`amount`,
		`commision`,
		`total`,id_client)
		VALUES
		(
		airline,new_date,
		new_connection,
		date_time,
		new_from,
		new_to,
		class,
		pnr,
		issue,
		amount,
		commision,
		total,id_client);
        
        OPEN cursor_get_insert_id;
		
		FETCH cursor_get_insert_id INTO insert_id;
	
	CLOSE cursor_get_insert_id;

	OPEN cursor_get_client_name;
		
		FETCH cursor_get_client_name INTO client_name;
	
	CLOSE cursor_get_client_name;

	OPEN cursor_get_old_balance;
		
		FETCH cursor_get_old_balance INTO old_balance;
	
	CLOSE cursor_get_old_balance;

INSERT INTO `alrayan`.`collection`
	(
	`date`,
	`particulars`,
	`mode`,
	`amount`,
	`balance`,
	`id_operation`,
	`operation`,
    benefit)
	VALUES
	(
	new_date,
	concat("Ticket Issue For ",client_name," (ID : ",id_client," )"),
	"Credit",
	total,
	old_balance+total,
	insert_id,
	"Ticket",
    commision);

	select insert_id;


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `vissa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `vissa`(
IN vissa_type varchar(45),
IN permit_number varchar(45),
IN issue_date varchar(45),
IN new_date varchar(45),
IN issue_place varchar(45),
IN valid_till varchar(45),
IN emigration_date varchar(45),
IN expiry_date varchar(45),
IN amount decimal,
IN commision decimal,
IN total_amount decimal,
IN id_client int)
BEGIN
	
    DECLARE insert_id INT DEFAULT 0;
    declare old_balance decimal default 0;
	DECLARE loop_break INT DEFAULT 0;
	declare client_name varchar(45) default "";

	declare cursor_get_client_name CURSOR for SELECT  `client`.`name`FROM `alrayan`.`client` 
    where `client`.`id_client`=id_client;


	declare cursor_get_insert_id CURSOR for SELECT last_insert_id() FROM alrayan.vissa;
    

    declare cursor_get_old_balance CURSOR for SELECT  `collection`.`balance`FROM `alrayan`.`collection` 
    where `id`=(select  max(id) from collection);


	DECLARE CONTINUE HANDLER FOR NOT FOUND SET loop_break =1 ;

	INSERT INTO `alrayan`.`vissa`
		(
		`vissa_type`,
		`permit_number`,
		`issue_date`,
		`date`,
		`issue_place`,
		`valid_till`,
		`emigration_date`,
		`expiry_date`,
		`amount`,
		`commision`,
		`total_amount`,`id_client`)
		VALUES
		(
		vissa_type,
		permit_number,
		issue_date,
		new_date,
		issue_place,
		valid_till,
		emigration_date,
		expiry_date,
		amount,
		commision,
		total_amount,id_client);


	OPEN cursor_get_insert_id;
		
		FETCH cursor_get_insert_id INTO insert_id;
	
	CLOSE cursor_get_insert_id;

	OPEN cursor_get_client_name;
		
		FETCH cursor_get_client_name INTO client_name;
	
	CLOSE cursor_get_client_name;

	OPEN cursor_get_old_balance;
		
		FETCH cursor_get_old_balance INTO old_balance;
	
	CLOSE cursor_get_old_balance;



	INSERT INTO `alrayan`.`collection`
	(
	`date`,
	`particulars`,
	`mode`,
	`amount`,
	`balance`,
	`id_operation`,
	`operation`,
    benefit)
	VALUES
	(
	new_date,
	concat("Visa Issue For ",client_name," (ID : ",id_client," )"),
	"Credit",
	total_amount,
	old_balance+total_amount,
	insert_id,
	"Visa",
    commision);


END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `collection_receive`
--

/*!50001 DROP VIEW IF EXISTS `collection_receive`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `collection_receive` AS select `collection`.`id` AS `id`,`collection`.`date` AS `date`,`collection`.`id_operation` AS `id_operation`,`collection`.`operation` AS `operation`,`collection`.`amount` AS `amount`,`receive_money`.`id_client` AS `id_client`,`collection`.`benefit` AS `benefit` from (`collection` join `receive_money`) where ((`collection`.`operation` = 'Receive') and (`receive_money`.`id` = `collection`.`id_operation`) and (`receive_money`.`id_client` = 1000)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `coolection_send`
--

/*!50001 DROP VIEW IF EXISTS `coolection_send`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `coolection_send` AS select `collection`.`id` AS `id`,`collection`.`date` AS `date`,`collection`.`id_operation` AS `id_operation`,`collection`.`operation` AS `operation`,`collection`.`amount` AS `amount`,`receive_money`.`id_client` AS `id_client`,`collection`.`benefit` AS `benefit` from (`collection` join `receive_money`) where ((`collection`.`operation` = 'Receive') and (`receive_money`.`id` = `collection`.`id_operation`) and (`receive_money`.`id_client` = 1000)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-21 10:11:15
