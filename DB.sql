CREATE DATABASE  IF NOT EXISTS `retail_store` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `retail_store`;
-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: retail_store
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `best_selling_products`
--

DROP TABLE IF EXISTS `best_selling_products`;
/*!50001 DROP VIEW IF EXISTS `best_selling_products`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `best_selling_products` AS SELECT 
 1 AS `ID`,
 1 AS `Product`,
 1 AS `Quantity_Sold`,
 1 AS `Total_Revenue`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `category_id` int NOT NULL AUTO_INCREMENT,
  `category_name` varchar(255) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Canned & Preserved Foods'),(2,'Ice Cream'),(3,'Bakery Products'),(4,'PC Products'),(5,'Frozen Food'),(6,'Snacks & Crackers'),(7,'Instant Coffee'),(8,'Personal Care'),(9,'Drinks');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories_backup`
--

DROP TABLE IF EXISTS `categories_backup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories_backup` (
  `category_id` int NOT NULL DEFAULT '0',
  `category_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories_backup`
--

LOCK TABLES `categories_backup` WRITE;
/*!40000 ALTER TABLE `categories_backup` DISABLE KEYS */;
INSERT INTO `categories_backup` VALUES (1,'Canned Goods'),(2,'Ice Cream'),(3,'Gardenia Breads'),(4,'PC Products'),(5,'Frozen Food'),(6,'Biscuits'),(7,'Coffee'),(8,'Personal Care'),(9,'Drinks'),(10,'Junk Foods');
/*!40000 ALTER TABLE `categories_backup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daily_sales_report`
--

DROP TABLE IF EXISTS `daily_sales_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `daily_sales_report` (
  `report_id` int NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `total_sales` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total_items_sold` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`report_id`),
  UNIQUE KEY `sale_date_UNIQUE` (`date`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily_sales_report`
--

LOCK TABLES `daily_sales_report` WRITE;
/*!40000 ALTER TABLE `daily_sales_report` DISABLE KEYS */;
INSERT INTO `daily_sales_report` VALUES (3,'2025-01-05',3958.00,54),(4,'2025-01-08',336.00,48),(5,'2025-01-09',544.00,68),(6,'2025-01-10',400.00,20),(7,'2025-01-12',990.00,22),(8,'2025-01-14',690.00,46),(9,'2025-01-15',160.00,10),(10,'2025-01-16',874.00,46),(11,'2025-01-19',1160.00,20),(12,'2025-01-22',1080.00,26),(13,'2025-01-24',820.00,100),(14,'2025-01-25',810.00,60),(15,'2025-01-26',240.00,20),(16,'2025-01-28',78.00,6),(17,'2025-01-30',910.00,14),(18,'2025-01-31',120.00,12),(19,'2025-02-02',465.00,5),(20,'2025-02-04',1038.00,6),(21,'2025-02-05',210.00,30),(22,'2025-02-06',810.00,10),(23,'2025-02-07',130.00,10),(24,'2025-02-09',1278.00,6),(25,'2025-02-10',492.00,2),(26,'2025-02-12',468.00,4),(27,'2025-02-15',914.00,51),(28,'2025-02-18',128.00,4),(30,'2025-01-01',3750.00,150),(31,'2025-02-20',6133.00,163),(32,'2025-01-03',2600.00,20),(33,'2025-03-18',2477.00,65),(34,'2025-03-31',112.00,4),(35,'2025-04-01',244.00,6),(36,'2025-04-14',160.00,7),(37,'2025-05-06',1183.00,36),(38,'2025-05-07',26.00,3),(39,'2025-05-09',174.00,6),(40,'2025-05-10',132.00,3),(41,'2025-05-11',104.00,2),(42,'2025-05-12',24.00,2),(43,'2025-05-17',7.00,1);
/*!40000 ALTER TABLE `daily_sales_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `daily_sales_summary`
--

DROP TABLE IF EXISTS `daily_sales_summary`;
/*!50001 DROP VIEW IF EXISTS `daily_sales_summary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `daily_sales_summary` AS SELECT 
 1 AS `Date`,
 1 AS `Total_Sales`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `monthly_sales_report`
--

DROP TABLE IF EXISTS `monthly_sales_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `monthly_sales_report` (
  `month_date` date NOT NULL,
  `total_sales` decimal(10,2) DEFAULT '0.00',
  `total_items_sold` int DEFAULT '0',
  PRIMARY KEY (`month_date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monthly_sales_report`
--

LOCK TABLES `monthly_sales_report` WRITE;
/*!40000 ALTER TABLE `monthly_sales_report` DISABLE KEYS */;
INSERT INTO `monthly_sales_report` VALUES ('2025-03-01',1368.00,38);
/*!40000 ALTER TABLE `monthly_sales_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_items`
--

DROP TABLE IF EXISTS `order_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_items` (
  `order_item_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int DEFAULT NULL,
  `product_id` int DEFAULT NULL,
  `quantity` int NOT NULL,
  `unit_price` decimal(10,2) NOT NULL,
  `subtotal` decimal(10,2) NOT NULL DEFAULT ((`quantity` * `unit_price`)),
  PRIMARY KEY (`order_item_id`),
  KEY `order_id_oi_idx` (`order_id`),
  KEY `product_id_oi_idx` (`product_id`),
  CONSTRAINT `order_id_oi_fk` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `product_id_oi_fk` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_items`
--

LOCK TABLES `order_items` WRITE;
/*!40000 ALTER TABLE `order_items` DISABLE KEYS */;
INSERT INTO `order_items` VALUES (1,1,4,30,27.00,324.00),(2,1,5,12,27.00,324.00),(3,1,6,12,27.00,324.00),(4,1,7,12,27.00,324.00),(5,1,8,12,27.00,324.00),(6,1,10,24,22.86,548.64),(7,1,11,24,22.86,548.64),(8,1,19,24,21.47,515.28),(9,1,20,24,21.47,515.28),(10,2,76,20,5.50,110.00),(11,2,91,20,6.20,124.00),(12,2,95,20,5.90,118.00),(13,2,96,12,11.00,132.00),(14,3,35,10,13.65,136.50),(15,3,41,6,29.10,174.60),(16,3,42,5,49.10,245.50),(17,3,43,5,49.10,245.50),(18,4,60,5,42.00,210.00),(19,4,61,5,45.00,225.00),(20,4,66,5,37.00,185.00),(21,5,129,25,13.33,333.25),(22,5,131,30,15.83,474.90),(23,6,52,4,213.75,641.25),(24,7,27,20,16.47,329.40),(25,7,28,20,16.47,329.40),(26,7,29,20,16.47,329.40),(27,7,30,20,16.47,329.40),(28,7,31,20,16.47,329.40),(29,7,34,25,8.12,203.00),(30,8,123,12,18.50,222.00),(31,8,124,12,17.50,210.00),(32,9,100,24,11.20,268.80),(33,9,102,24,11.60,278.40),(34,9,106,48,4.77,228.96),(35,10,134,50,10.25,512.50),(36,11,1,24,21.00,504.00),(37,11,2,24,32.00,768.00),(38,11,3,24,35.00,840.00),(39,12,67,3,185.00,555.00),(40,12,70,5,70.00,350.00),(41,13,107,12,17.00,204.00),(42,13,108,12,17.00,204.00),(43,13,112,24,5.50,132.00),(44,13,113,24,5.50,132.00),(45,13,119,12,6.17,74.04),(46,13,122,12,5.50,66.00),(47,14,97,24,12.80,307.20),(48,14,98,24,17.50,420.00),(49,14,105,24,11.68,280.32),(50,15,72,2,155.00,310.00),(51,15,73,5,30.00,150.00),(52,15,74,5,58.00,290.00),(53,16,134,50,10.25,512.50),(54,17,35,10,13.65,136.50),(55,17,36,10,16.35,163.50),(56,18,106,48,4.77,228.96),(57,19,53,5,116.25,581.25),(58,19,54,5,116.25,581.25),(59,19,55,5,116.25,581.25),(60,19,56,5,116.25,581.25),(61,20,22,20,12.18,243.60),(62,20,23,20,12.18,243.60),(63,20,24,20,12.18,243.60),(64,21,39,6,30.90,185.40),(65,21,40,6,30.90,185.40),(66,21,41,6,29.10,174.60),(67,21,42,6,49.10,294.60),(72,34,123,2,18.50,37.00),(73,34,115,5,5.50,27.50),(74,35,133,2,15.83,31.66),(75,35,128,5,15.00,75.00),(76,36,133,5,15.83,79.15),(77,39,134,10,10.25,102.50),(78,40,2,2,32.00,64.00),(79,41,22,2,12.18,24.36);
/*!40000 ALTER TABLE `order_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `order_date` date NOT NULL,
  `status` enum('sent','pending','cancelled','delivered') NOT NULL,
  `supplier_id` int NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY ` supplier_id_o_idx` (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2025-01-01','cancelled',1),(2,'2025-01-02','delivered',6),(3,'2025-01-07','cancelled',3),(4,'2025-01-08','delivered',5),(5,'2025-01-10','cancelled',9),(6,'2025-01-12','delivered',4),(7,'2025-01-16','cancelled',2),(8,'2025-01-17','delivered',8),(9,'2025-01-20','cancelled',7),(10,'2025-01-23','delivered',10),(11,'2025-01-27','delivered',1),(12,'2025-01-30','cancelled',5),(13,'2025-02-03','delivered',8),(14,'2025-02-05','delivered',7),(15,'2025-02-10','delivered',5),(16,'2025-02-15','cancelled',10),(17,'2025-02-17','delivered',3),(18,'2025-02-19','delivered',7),(19,'2025-02-20','cancelled',4),(20,'2025-02-21','cancelled',2),(21,'2025-04-14','delivered',3),(22,'2025-05-09','cancelled',2),(23,'2025-05-09','pending',4),(24,'2025-05-09','pending',1),(25,'2025-05-09','pending',1),(26,'2025-05-09','pending',10),(27,'2025-05-09','cancelled',10),(28,'2025-05-09','pending',2),(29,'2025-05-09','cancelled',2),(30,'2025-05-09','pending',4),(31,'2025-05-09','cancelled',1),(32,'2025-05-09','cancelled',2),(33,'2025-05-09','pending',4),(34,'2025-05-09','sent',8),(35,'2025-05-09','cancelled',9),(36,'2025-05-09','sent',9),(37,'2025-05-10','cancelled',2),(38,'2025-05-10','cancelled',2),(39,'2025-05-10','sent',10),(40,'2025-05-11','cancelled',1),(41,'2025-05-11','sent',2);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_insert_order` BEFORE INSERT ON `orders` FOR EACH ROW BEGIN
    SET NEW.status = 'Pending';
    SET NEW.order_date = CURDATE();
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `orders_summary`
--

DROP TABLE IF EXISTS `orders_summary`;
/*!50001 DROP VIEW IF EXISTS `orders_summary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `orders_summary` AS SELECT 
 1 AS `ID`,
 1 AS `Date`,
 1 AS `Supplier`,
 1 AS `Status`,
 1 AS `Total_Amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `product_id` int NOT NULL AUTO_INCREMENT,
  `product_name` varchar(255) NOT NULL,
  `category_id` int DEFAULT NULL,
  `net_weight` varchar(10) DEFAULT NULL,
  `unit` enum('Piece','Pack') DEFAULT 'Piece',
  `unit_price` decimal(10,2) NOT NULL,
  `retail_price` decimal(10,2) DEFAULT NULL,
  `supplier_id` int DEFAULT NULL,
  `stock` int NOT NULL,
  PRIMARY KEY (`product_id`),
  KEY `supplier_id_p_idx` (`supplier_id`),
  KEY `category_id_p_idx` (`category_id`),
  CONSTRAINT `category_id_p_fk` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `supplier_id_p_fk` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=148 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Argentina Meat Loafs',1,'150g','Piece',30.00,35.00,1,43),(2,'Argentina Corn Beef',1,'150g','Piece',32.00,37.00,1,44),(3,'Century Tuna Flakes in Oil',1,'155g','Piece',35.00,41.00,1,48),(4,'Fresca Tuna Adobo',1,'175g','Piece',27.00,32.00,1,50),(5,'Fresca Tuna Afritada',1,'175g','Piece',27.00,31.00,1,50),(6,'Fresca Tuna Caldereta',1,'175g','Piece',27.00,32.00,1,50),(7,'Fresca Tuna Flakes in Oil',1,'175g','Piece',27.00,31.00,1,45),(8,'Fresca Tuna Mechado',1,'175g','Piece',27.00,32.00,1,45),(9,'Lucky 7 Carne Norte',1,'150g','Piece',19.25,23.00,1,49),(10,'Mega Sardines Green',1,'155g','Piece',22.86,27.00,1,49),(11,'Mega Sardines Red',1,'155g','Piece',22.86,27.00,1,50),(12,'San Marino Chili Corned Tuna',1,'150g','Piece',39.00,45.00,1,41),(13,'San Marino Corned Tuna',1,'150g','Piece',39.00,45.00,1,48),(14,'Wow Ulam Adobo',1,'155g','Piece',24.00,28.00,1,52),(15,'Wow Ulam Afritada',1,'155g','Piece',24.00,28.00,1,50),(16,'Wow Ulam Caldereta',1,'155g','Piece',24.00,28.00,1,50),(17,'Wow Ulam Menudo',1,'155g','Piece',24.00,28.00,1,50),(18,'Wow Ulam Mechado',1,'155g','Piece',24.00,28.00,1,50),(19,'Youngs Town Green',1,'155g','Piece',21.47,25.00,1,50),(20,'Youngs Town Red',1,'155g','Piece',21.47,25.00,1,50),(21,'Selecta 3in1 Choco Mango Ube',2,'1L','Piece',80.36,113.00,2,10),(22,'Selecta BOOM BOOM! Cookies & Cream',2,'60ml','Piece',12.18,18.00,2,9),(23,'Selecta BOOM BOOM! Pinipig Chocolate',2,'60ml','Piece',12.18,18.00,2,10),(24,'Selecta BOOM BOOM! Ube',2,'60ml','Piece',12.18,18.00,2,9),(25,'Selecta Coffee Crumble',2,'750ml','Piece',112.81,158.00,2,10),(26,'Selecta Cookies & Cream',2,'750ml','Piece',112.81,158.00,2,9),(27,'Selecta Cornetto  Choco Hazelnut',2,'110ml','Piece',16.47,24.00,2,8),(28,'Selecta Cornetto Berry Crazy For You',2,'110ml','Piece',16.47,24.00,2,10),(29,'Selecta Cornetto Chocolate',2,'110ml','Piece',16.47,24.00,2,0),(30,'Selecta Cornetto Cookies & Dream ',2,'110ml','Piece',16.47,24.00,2,10),(31,'Selecta Cornetto Vanilla',2,'110ml','Piece',16.47,24.00,2,10),(32,'Selecta Double Dutch',2,'750ml','Piece',112.81,158.00,2,10),(33,'Selecta Supreme Rocky Road',2,'750ml','Piece',112.81,158.00,2,10),(34,'Selecta Watermelon Slice',2,'60ml','Piece',8.12,12.00,2,7),(35,'Gardenia Butter Toast',3,'25g','Pack',13.65,16.00,3,6),(36,'Gardenia Chocolate Filled Buns',3,'75g','Pack',16.35,19.00,3,4),(37,'Gardenia Clustered Cheese Buns',3,'250g','Pack',56.35,65.00,3,9),(38,'Gardenia Multigrain Soft Bun',3,'120g','Pack',37.30,43.00,3,10),(39,'Gardenia NeuBake Choco Bread Roll',3,'150g','Pack',30.90,36.00,3,10),(40,'Gardenia NeuBake Monggo Bread Roll',3,'150g','Pack',30.90,36.00,3,10),(41,'Gardenia NeuBake Spanish Bread',3,'150g','Pack',29.10,34.00,3,10),(42,'Gardenia NeuBake White Bread',3,'450g','Pack',49.10,57.00,3,10),(43,'Gardenia Soft Delight Pandesal Family Pack',3,'300g','Pack',49.10,57.00,3,8),(44,'Gardenia Ube Filled Buns',3,'75g','Pack',16.35,19.00,3,10),(45,'Gardenia White Bread Classic',3,'400g','Pack',16.35,19.00,3,10),(46,'PC Alert Green Burst Gel Toothpaste',4,'160g','Piece',101.25,117.00,4,5),(47,'PC Alert Optimum Fluoride Toothpaste',4,'160g','Piece',101.25,117.00,4,5),(48,'PC Alert Red Blaze Gel Toothpaste',4,'160g','Piece',101.25,117.00,4,5),(49,'PC Check Blooming Papaya Soap',4,'130g','Piece',45.00,52.00,4,5),(50,'PC Check Fruity Floral Fresh Soap',4,'130g','Piece',45.00,52.00,4,5),(51,'PC Anti-Dandruff Care Shampoo & Conditioner',4,'200ml ','Piece',127.50,147.00,4,5),(52,'PC Sof & mmmmm Fabric Conditionaer',4,'1L','Piece',213.75,246.00,4,5),(53,'PC White Dove Baby Lotion',4,'200ml ','Piece',116.25,134.00,4,5),(54,'PC White Dove Baby Milk Soap',4,'200ml ','Piece',116.25,134.00,4,5),(55,'PC White Dove Baby Powder',4,'200ml ','Piece',116.25,134.00,4,5),(56,'PC White Dove Baby Shampoo',4,'200ml ','Piece',116.25,134.00,4,4),(57,'PC White Dove Baby Wash Dreamscent',4,'200ml ','Piece',116.25,134.00,4,5),(58,'Arbees Bologna Pork',5,'200g','Pack',42.00,49.00,5,2),(59,'Arbees Cooked Ham ',5,'200g','Pack',42.00,49.00,5,10),(60,'Arbees Embotido',5,'200g','Pack',42.00,49.00,5,8),(61,'Arbees Skinless Longaniza',5,'200g','Pack',45.00,52.00,5,10),(62,'Arbees Sweet Ham',5,'200g','Pack',45.00,52.00,5,8),(63,'Arbees Tapa',5,'200g','Pack',50.00,58.00,5,8),(64,'Arbees Tocino',5,'200g','Pack',50.00,58.00,5,9),(65,'BigTime Hotdog King Size ',5,'1.1 kg','Pack',150.00,173.00,5,10),(66,'Bingo Hotdog Mini',5,'250g','Pack',37.00,43.00,5,10),(67,'Chicken',5,'1kg','Pack',185.00,213.00,5,10),(68,'Fishball',5,'1kg','Pack',64.00,74.00,5,8),(69,'Kikiam',5,'250g','Pack',25.00,29.00,5,8),(70,'Lumpia',5,'250g','Pack',70.00,81.00,5,10),(71,'PureFoods Tender Juicy Hotdog',5,'1kg','Pack',208.00,240.00,5,10),(72,'Siomai',5,'1kg','Pack',155.00,179.00,5,10),(73,'Squidball',5,'250g','Pack',30.00,35.00,5,10),(74,'Ulam Burger',5,'250g','Pack',58.00,67.00,5,10),(75,'Bingo Chocolate',6,'28g','Piece',5.50,7.00,6,12),(76,'Bingo Vanilla',6,'28g','Piece',5.50,7.00,6,8),(77,'CalCheese',6,'48g','Piece',11.00,13.00,6,12),(78,'ChocoMucho Cookies Choco Caramel',6,'38g','Piece',7.50,9.00,6,12),(79,'Cream-O Choco',6,'33g','Piece',7.50,9.00,6,12),(80,'Cream-O Vanilla',6,'33g','Piece',7.50,9.00,6,12),(81,'Dewberry Blueberries n Cream',6,'33g','Piece',7.50,9.00,6,10),(82,'Dewberry Blueberry Cheesecake',6,'33g','Piece',7.50,9.00,6,12),(83,'Dewberry Strawberries n Cream',6,'33g','Piece',7.50,9.00,6,12),(84,'FITA Crackers',6,'30g','Piece',5.90,7.00,6,11),(85,'Hansel Chocolate Sandwich',6,'32g','Piece',5.50,7.00,6,11),(86,'Hansel Crackers',6,'32g','Piece',5.80,7.00,6,11),(87,'Hansel Crackers Cheese',6,'32g','Piece',5.80,7.00,6,12),(88,'Hansel Mocha Sandwich',6,'32g','Piece',5.80,7.00,6,12),(89,'Rebisco Butter',6,'32g','Piece',6.20,8.00,6,8),(90,'Rebisco Choco',6,'32g','Piece',6.20,8.00,6,10),(91,'Rebisco Crackers',6,'32g','Piece',6.20,8.00,6,12),(92,'Rebisco Pastillas',6,'32g','Piece',6.20,8.00,6,12),(93,'Rebisco Peanut Butter',6,'32g','Piece',6.20,8.00,6,12),(94,'Rebisco Strawberry',6,'32g','Piece',6.20,8.00,6,12),(95,'Sky Flakes Crackers',6,'25g','Piece',5.90,7.00,6,12),(96,'Wafello',6,'48g','Piece',11.00,13.00,NULL,12),(97,'Bestcaffe 8in1 Coffee',7,'14g','Piece',12.80,15.00,NULL,23),(98,'Bestcaffe Gold 20in1 Coffee',7,'16g','Piece',17.50,21.00,NULL,24),(99,'Great Taste Choco Twin Pack',7,'50g','Piece',12.00,14.00,NULL,22),(100,'Great Taste White Twin Pack',7,'50g','Piece',11.20,13.00,NULL,24),(101,'Kopiko Black Twin Pack',7,'53g','Piece',11.60,14.00,NULL,24),(102,'Kopiko Blanca Twin Pack',7,'58g','Piece',11.60,14.00,NULL,24),(103,'Kopiko Brown Twin Pack',7,'53g','Piece',11.60,14.00,NULL,24),(104,'Nescafe Creamy White Twin Pack',7,'51g','Piece',11.68,14.00,NULL,24),(105,'Nescafe 3in1 Original Twin Pack',7,'52g','Piece',11.68,14.00,NULL,24),(106,'San Mig Original',7,'20g','Piece',4.77,6.00,8,21),(107,'Bioderm Germicidal Soap Bloom',8,'60g','Piece',17.00,20.00,8,12),(108,'Bioderm Germicidal Soap Coolness',8,'60g','Piece',17.00,20.00,8,12),(109,'Closeup Cool Mint Toothpaste Twin Pack',8,'20g','Piece',8.50,10.00,8,12),(110,'Closeup Gel Toothpaste Red Hot Twin Pack',8,'20g','Piece',8.50,10.00,8,12),(111,'Colgate Charcoal Clean Toothpaste',8,'20g','Piece',8.50,10.00,8,12),(112,'Cream Silk Hair Fall Defense Vitamin Boost Conditioner',8,'11ml','Piece',5.50,7.00,8,12),(113,'Cream Silk Standout Straight Vitamin Boost Conditioner',8,'11ml','Piece',5.50,7.00,8,12),(114,'DeoPlus Tawas Powder',8,'50g','Piece',13.50,16.00,8,12),(115,'Dove Keratin Tri-Silk Serum',8,'12ml','Piece',5.50,7.00,8,12),(116,'Haileys Tawas Mentholated',8,'50g','Piece',14.25,17.00,8,12),(117,'Head & Shoulders Anti-Dandruff Shampoo Cool Menthol',8,'12ml','Piece',5.50,7.00,8,12),(118,'Head & Shoulders Anti-Dandruff Shampoo Smooth & Silky',8,'12ml','Piece',5.50,7.00,8,12),(119,'Keratin Plus Gold',8,'20g','Piece',6.17,8.00,8,12),(120,'Nivea Deo Lotion Extra Brgihtening',8,'3ml','Piece',8.00,10.00,8,12),(121,'Nivea Men Cool Quick Anti-Perspirant',8,'3ml','Piece',8.00,10.00,8,12),(122,'Rejoice 3in1',8,'16ml','Piece',5.50,7.00,8,12),(123,'Safeguard Pure White Soap',8,'60g','Piece',18.50,22.00,8,12),(124,'Silka Whitening Herbal Soap',8,'65g','Piece',17.50,21.00,8,12),(125,'Sunsilk Shampoo Biotin & Aloe Vera',8,'15ml','Piece',5.50,7.00,8,12),(127,'C2 Solo Apple',9,'230ml','Piece',12.46,15.00,9,10),(128,'Chuckie',9,'110ml','Piece',15.00,18.00,9,10),(129,'Cobra Green',9,'240ml','Piece',13.33,16.00,9,10),(130,'Cobra Yellow',9,'240ml','Piece',13.33,16.00,9,10),(131,'Coca-Cola Mismo',9,'250ml','Piece',15.83,19.00,9,5),(132,'Royal Mismo',9,'250ml','Piece',15.83,19.00,9,9),(133,'Sprite Mismo',9,'250ml','Piece',15.83,19.00,9,10),(134,'Yakult',9,'80ml','Piece',10.25,12.00,10,22),(135,'Chippy',6,'27g','Piece',6.71,8.00,NULL,12),(136,'Mang Juan Espesyal Sukat Sli',6,'26g','Piece',6.70,8.00,NULL,12),(137,'Martys Craklin Spicy Vinegar Flavor',6,'26g','Piece',6.15,8.00,NULL,12),(138,'Oishi Cracklings',6,'24g','Piece',6.15,8.00,NULL,12);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products_backup`
--

DROP TABLE IF EXISTS `products_backup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products_backup` (
  `product_id` int NOT NULL DEFAULT '0',
  `product_name` varchar(255) NOT NULL,
  `category_id` int DEFAULT NULL,
  `net_weight` varchar(10) DEFAULT NULL,
  `unit` enum('Piece','Pack') DEFAULT NULL,
  `unit_price` decimal(10,2) NOT NULL,
  `retail_price` decimal(10,2) NOT NULL DEFAULT '0.00',
  `supplier_id` int DEFAULT NULL,
  `stock` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products_backup`
--

LOCK TABLES `products_backup` WRITE;
/*!40000 ALTER TABLE `products_backup` DISABLE KEYS */;
INSERT INTO `products_backup` VALUES (1,'Argentina Meat Loaf',1,'150g','Piece',30.00,35.00,1,43),(2,'Argentina Corn Beef',1,'150g','Piece',32.00,37.00,1,46),(3,'Century Tuna Flakes in Oil',1,'155g','Piece',35.00,41.00,1,48),(4,'Fresca Tuna Adobo',1,'175g','Piece',27.00,32.00,1,50),(5,'Fresca Tuna Afritada',1,'175g','Piece',27.00,32.00,1,47),(6,'Fresca Tuna Caldereta',1,'175g','Piece',27.00,32.00,1,50),(7,'Fresca Tuna Flakes in Oil',1,'175g','Piece',27.00,32.00,1,49),(8,'Fresca Tuna Mechado',1,'175g','Piece',27.00,32.00,1,45),(9,'Lucky 7 Carne Norte',1,'150g','Piece',19.25,23.00,1,50),(10,'Mega Sardines Green',1,'155g','Piece',22.86,27.00,1,49),(11,'Mega Sardines Red',1,'155g','Piece',22.86,27.00,1,50),(12,'San Marino Chili Corned Tuna',1,'150g','Piece',39.00,45.00,1,42),(13,'San Marino Corned Tuna',1,'150g','Piece',39.00,45.00,1,50),(14,'Wow Ulam Adobo',1,'155g','Piece',24.00,28.00,1,52),(15,'Wow Ulam Afritada',1,'155g','Piece',24.00,28.00,1,50),(16,'Wow Ulam Caldereta',1,'155g','Piece',24.00,28.00,1,50),(17,'Wow Ulam Menudo',1,'155g','Piece',24.00,28.00,1,50),(18,'Wow Ulam Mechado',1,'155g','Piece',24.00,28.00,1,50),(19,'Youngs Town Green',1,'155g','Piece',21.47,25.00,1,50),(20,'Youngs Town Red',1,'155g','Piece',21.47,25.00,1,50),(21,'Selecta 3in1 Choco Mango Ube',2,'1L','Piece',80.36,113.00,2,10),(22,'Selecta BOOM BOOM! Cookies & Cream',2,'60ml','Piece',12.18,18.00,2,10),(23,'Selecta BOOM BOOM! Pinipig Chocolate',2,'60ml','Piece',12.18,18.00,2,10),(24,'Selecta BOOM BOOM! Ube',2,'60ml','Piece',12.18,18.00,2,9),(25,'Selecta Coffee Crumble',2,'750ml','Piece',112.81,158.00,2,10),(26,'Selecta Cookies & Cream',2,'750ml','Piece',112.81,158.00,2,10),(27,'Selecta Cornetto  Choco Hazelnut',2,'110ml','Piece',16.47,24.00,2,10),(28,'Selecta Cornetto Berry Crazy For You',2,'110ml','Piece',16.47,24.00,2,10),(29,'Selecta Cornetto Chocolate',2,'110ml','Piece',16.47,24.00,2,0),(30,'Selecta Cornetto Cookies & Dream ',2,'110ml','Piece',16.47,24.00,2,10),(31,'Selecta Cornetto Vanilla',2,'110ml','Piece',16.47,24.00,2,10),(32,'Selecta Double Dutch',2,'750ml','Piece',112.81,158.00,2,10),(33,'Selecta Supreme Rocky Road',2,'750ml','Piece',112.81,158.00,2,10),(34,'Selecta Watermelon Slice',2,'60ml','Piece',8.12,12.00,2,10),(35,'Gardenia Butter Toast',3,'25g','Pack',13.65,16.00,3,10),(36,'Gardenia Chocolate Filled Buns',3,'75g','Pack',16.35,19.00,3,10),(37,'Gardenia Clustered Cheese Buns',3,'250g','Pack',56.35,65.00,3,10),(38,'Gardenia Multigrain Soft Bun',3,'120g','Pack',37.30,43.00,3,10),(39,'Gardenia NeuBake Choco Bread Roll',3,'150g','Pack',30.90,36.00,3,10),(40,'Gardenia NeuBake Monggo Bread Roll',3,'150g','Pack',30.90,36.00,3,10),(41,'Gardenia NeuBake Spanish Bread',3,'150g','Pack',29.10,34.00,3,10),(42,'Gardenia NeuBake White Bread',3,'450g','Pack',49.10,57.00,3,10),(43,'Gardenia Soft Delight Pandesal Family Pack',3,'300g','Pack',49.10,57.00,3,10),(44,'Gardenia Ube Filled Buns',3,'75g','Pack',16.35,19.00,3,10),(45,'Gardenia White Bread Classic',3,'400g','Pack',16.35,19.00,3,10),(46,'PC Alert Green Burst Gel Toothpaste',4,'160g','Piece',101.25,117.00,4,5),(47,'PC Alert Optimum Fluoride Toothpaste',4,'160g','Piece',101.25,117.00,4,5),(48,'PC Alert Red Blaze Gel Toothpaste',4,'160g','Piece',101.25,117.00,4,5),(49,'PC Check Blooming Papaya Soap',4,'130g','Piece',45.00,52.00,4,5),(50,'PC Check Fruity Floral Fresh Soap',4,'130g','Piece',45.00,52.00,4,5),(51,'PC Anti-Dandruff Care Shampoo & Conditioner',4,'200ml ','Piece',127.50,147.00,4,5),(52,'PC Sof & mmmmm Fabric Conditionaer',4,'1L','Piece',213.75,246.00,4,5),(53,'PC White Dove Baby Lotion',4,'200ml ','Piece',116.25,134.00,4,5),(54,'PC White Dove Baby Milk Soap',4,'200ml ','Piece',116.25,134.00,4,5),(55,'PC White Dove Baby Powder',4,'200ml ','Piece',116.25,134.00,4,5),(56,'PC White Dove Baby Shampoo',4,'200ml ','Piece',116.25,134.00,4,5),(57,'PC White Dove Baby Wash Dreamscent',4,'200ml ','Piece',116.25,134.00,4,5),(58,'Arbees Bologna Pork',5,'200g','Pack',42.00,49.00,5,10),(59,'Arbees Cooked Ham ',5,'200g','Pack',42.00,49.00,5,10),(60,'Arbees Embotido',5,'200g','Pack',42.00,49.00,5,10),(61,'Arbees Skinless Longaniza',5,'200g','Pack',45.00,52.00,5,10),(62,'Arbees Sweet Ham',5,'200g','Pack',45.00,52.00,5,10),(63,'Arbees Tapa',5,'200g','Pack',50.00,58.00,5,10),(64,'Arbees Tocino',5,'200g','Pack',50.00,58.00,5,10),(65,'BigTime Hotdog King Size ',5,'1.1 kg','Pack',150.00,173.00,5,10),(66,'Bingo Hotdog Mini',5,'250g','Pack',37.00,43.00,5,10),(67,'Chicken',5,'1kg','Pack',185.00,213.00,5,10),(68,'Fishball',5,'1kg','Pack',64.00,74.00,5,10),(69,'Kikiam',5,'250g','Pack',25.00,29.00,5,10),(70,'Lumpia',5,'250g','Pack',70.00,81.00,5,10),(71,'PureFoods Tender Juicy Hotdog',5,'1kg','Pack',208.00,240.00,5,10),(72,'Siomai',5,'1kg','Pack',155.00,179.00,5,10),(73,'Squidball',5,'250g','Pack',30.00,35.00,5,10),(74,'Ulam Burger',5,'250g','Pack',58.00,67.00,5,10),(75,'Bingo Chocolate',6,'28g','Piece',5.50,7.00,6,12),(76,'Bingo Vanilla',6,'28g','Piece',5.50,7.00,6,12),(77,'CalCheese',6,'48g','Piece',11.00,13.00,6,12),(78,'ChocoMucho Cookies Choco Caramel',6,'38g','Piece',7.50,9.00,6,12),(79,'Cream-O Choco',6,'33g','Piece',7.50,9.00,6,12),(80,'Cream-O Vanilla',6,'33g','Piece',7.50,9.00,6,12),(81,'Dewberry Blueberries n Cream',6,'33g','Piece',7.50,9.00,6,12),(82,'Dewberry Blueberry Cheesecake',6,'33g','Piece',7.50,9.00,6,12),(83,'Dewberry Strawberries n Cream',6,'33g','Piece',7.50,9.00,6,12),(84,'FITA Crackers',6,'30g','Piece',5.90,7.00,6,12),(85,'Hansel Chocolate Sandwich',6,'32g','Piece',5.50,7.00,6,12),(86,'Hansel Crackers',6,'32g','Piece',5.80,7.00,6,12),(87,'Hansel Crackers Cheese',6,'32g','Piece',5.80,7.00,6,12),(88,'Hansel Mocha Sandwich',6,'32g','Piece',5.80,7.00,6,12),(89,'Rebisco Butter',6,'32g','Piece',6.20,8.00,6,12),(90,'Rebisco Choco',6,'32g','Piece',6.20,8.00,6,12),(91,'Rebisco Crackers',6,'32g','Piece',6.20,8.00,6,12),(92,'Rebisco Pastillas',6,'32g','Piece',6.20,8.00,6,12),(93,'Rebisco Peanut Butter',6,'32g','Piece',6.20,8.00,6,12),(94,'Rebisco Strawberry',6,'32g','Piece',6.20,8.00,6,12),(95,'Sky Flakes Crackers',6,'25g','Piece',5.90,7.00,6,12),(96,'Wafello',6,'48g','Piece',11.00,13.00,7,12),(97,'Bestcaffe 8in1 Coffee',7,'14g','Piece',12.80,15.00,7,24),(98,'Bestcaffe Gold 20in1 Coffee',7,'16g','Piece',17.50,21.00,7,24),(99,'Great Taste Choco Twin Pack',7,'50g','Piece',12.00,14.00,7,24),(100,'Great Taste White Twin Pack',7,'50g','Piece',11.20,13.00,7,24),(101,'Kopiko Black Twin Pack',7,'53g','Piece',11.60,14.00,7,24),(102,'Kopiko Blanca Twin Pack',7,'58g','Piece',11.60,14.00,7,24),(103,'Kopiko Brown Twin Pack',7,'53g','Piece',11.60,14.00,7,24),(104,'Nescafe Creamy White Twin Pack',7,'51g','Piece',11.68,14.00,7,24),(105,'Nescafe 3in1 Original Twin Pack',7,'52g','Piece',11.68,14.00,7,24),(106,'San Mig Original',7,'20g','Piece',4.77,6.00,8,24),(107,'Bioderm Germicidal Soap Bloom',8,'60g','Piece',17.00,20.00,8,12),(108,'Bioderm Germicidal Soap Coolness',8,'60g','Piece',17.00,20.00,8,12),(109,'Closeup Cool Mint Toothpaste Twin Pack',8,'20g','Piece',8.50,10.00,8,12),(110,'Closeup Gel Toothpaste Red Hot Twin Pack',8,'20g','Piece',8.50,10.00,8,12),(111,'Colgate Charcoal Clean Toothpaste',8,'20g','Piece',8.50,10.00,8,12),(112,'Cream Silk Hair Fall Defense Vitamin Boost Conditioner',8,'11ml','Piece',5.50,7.00,8,12),(113,'Cream Silk Standout Straight Vitamin Boost Conditioner',8,'11ml','Piece',5.50,7.00,8,12),(114,'DeoPlus Tawas Powder',8,'50g','Piece',13.50,16.00,8,12),(115,'Dove Keratin Tri-Silk Serum',8,'12ml','Piece',5.50,7.00,8,12),(116,'Haileys Tawas Mentholated',8,'50g','Piece',14.25,17.00,8,12),(117,'Head & Shoulders Anti-Dandruff Shampoo Cool Menthol',8,'12ml','Piece',5.50,7.00,8,12),(118,'Head & Shoulders Anti-Dandruff Shampoo Smooth & Silky',8,'12ml','Piece',5.50,7.00,8,12),(119,'Keratin Plus Gold',8,'20g','Piece',6.17,8.00,8,12),(120,'Nivea Deo Lotion Extra Brgihtening',8,'3ml','Piece',8.00,10.00,8,12),(121,'Nivea Men Cool Quick Anti-Perspirant',8,'3ml','Piece',8.00,10.00,8,12),(122,'Rejoice 3in1',8,'16ml','Piece',5.50,7.00,8,12),(123,'Safeguard Pure White Soap',8,'60g','Piece',18.50,22.00,8,12),(124,'Silka Whitening Herbal Soap',8,'65g','Piece',17.50,21.00,8,12),(125,'Sunsilk Shampoo Biotin & Aloe Vera',8,'15ml','Piece',5.50,7.00,8,12),(126,'Sunsilk Shampoo Flower Essences',8,'15ml','Piece',5.50,7.00,8,12),(127,'C2 Solo Apple',9,'230ml','Piece',12.46,15.00,9,10),(128,'Chuckie',9,'110ml','Piece',15.00,18.00,9,10),(129,'Cobra Green',9,'240ml','Piece',13.33,16.00,9,10),(130,'Cobra Yellow',9,'240ml','Piece',13.33,16.00,9,10),(131,'Coca-Cola Mismo',9,'250ml','Piece',15.83,19.00,9,10),(132,'Royal Mismo',9,'250ml','Piece',15.83,19.00,9,10),(133,'Sprite Mismo',9,'250ml','Piece',15.83,19.00,9,10),(134,'Yakult',9,'80ml','Piece',10.25,12.00,10,25),(135,'Chippy',10,'27g','Piece',6.71,8.00,NULL,12),(136,'Mang Juan Espesyal Sukat Sli',10,'26g','Piece',6.70,8.00,NULL,12),(137,'Martys Craklin Spicy Vinegar Flavor',10,'26g','Piece',6.15,8.00,NULL,12),(138,'Oishi Cracklings',10,'24g','Piece',6.15,8.00,NULL,12),(139,'Oishi Onion Rings',10,'16g','Piece',6.50,8.00,NULL,12),(140,'Piattos Cheese',10,'40g','Piece',15.70,19.00,NULL,12),(141,'Ri-Chee',10,'25g','Piece',6.50,8.00,NULL,12);
/*!40000 ALTER TABLE `products_backup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `products_suppliers`
--

DROP TABLE IF EXISTS `products_suppliers`;
/*!50001 DROP VIEW IF EXISTS `products_suppliers`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `products_suppliers` AS SELECT 
 1 AS `Product_ID`,
 1 AS `Product`,
 1 AS `Unit_Price`,
 1 AS `Retail_Price`,
 1 AS `Supplier_ID`,
 1 AS `Supplier`,
 1 AS `Contact`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales` (
  `sale_id` int NOT NULL AUTO_INCREMENT,
  `sale_date` date NOT NULL,
  `status` enum('pending','completed','cancelled') DEFAULT NULL,
  `total_amount` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total_items` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`sale_id`)
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES (1,'2025-01-01','completed',1875.00,75),(2,'2025-01-02','cancelled',888.00,24),(3,'2025-01-03','completed',1300.00,10),(4,'2025-01-04','cancelled',0.00,0),(5,'2025-01-05','completed',1127.00,23),(6,'2025-01-05','completed',852.00,4),(7,'2025-01-07','cancelled',0.00,0),(8,'2025-01-08','completed',168.00,24),(9,'2025-01-09','completed',272.00,34),(10,'2025-01-10','completed',200.00,10),(11,'2025-01-11','cancelled',189.00,7),(12,'2025-01-12','completed',495.00,11),(13,'2025-01-13','cancelled',600.00,40),(14,'2025-01-14','completed',345.00,23),(15,'2025-01-15','completed',80.00,5),(16,'2025-01-16','completed',437.00,23),(17,'2025-01-17','cancelled',456.00,8),(18,'2025-01-18','cancelled',0.00,0),(19,'2025-01-19','completed',580.00,10),(20,'2025-01-20','cancelled',60.00,10),(21,'2025-01-21','cancelled',405.00,15),(22,'2025-01-22','completed',540.00,13),(23,'2025-01-23','cancelled',426.00,2),(24,'2025-01-24','completed',320.00,40),(25,'2025-01-25','completed',405.00,30),(26,'2025-01-26','completed',120.00,10),(27,'2025-01-27','cancelled',80.00,8),(28,'2025-01-28','cancelled',0.00,0),(29,'2025-01-29','cancelled',36.00,4),(30,'2025-01-30','completed',455.00,7),(31,'2025-01-31','cancelled',0.00,0),(32,'2025-02-01','cancelled',204.00,8),(33,'2025-02-02','cancelled',0.00,0),(34,'2025-02-03','cancelled',0.00,0),(35,'2025-02-04','completed',519.00,3),(36,'2025-02-05','completed',70.00,10),(37,'2025-02-06','completed',405.00,5),(38,'2025-02-07','completed',65.00,5),(39,'2025-02-08','cancelled',42.00,3),(40,'2025-02-09','completed',639.00,3),(41,'2025-02-10','completed',246.00,1),(42,'2025-02-11','cancelled',703.00,21),(43,'2025-02-12','completed',234.00,2),(44,'2025-02-13','cancelled',438.00,12),(45,'2025-02-14','cancelled',234.00,2),(46,'2025-02-15','completed',86.00,2),(47,'2025-02-15','completed',176.00,22),(48,'2025-02-17','cancelled',406.00,7),(49,'2025-02-18','completed',64.00,2),(50,'2025-02-19','cancelled',710.00,18),(51,'2025-02-20','completed',432.00,10),(52,'2025-02-20','completed',829.00,23),(53,'2025-03-18','completed',185.00,5),(54,'2025-03-18','completed',32.00,1),(55,'2025-03-18','completed',270.00,6),(56,'2025-03-18','cancelled',250.00,10),(57,'2025-03-18','completed',84.00,2),(58,'2025-03-18','completed',18.00,1),(59,'2025-03-18','cancelled',0.00,0),(60,'2025-03-18','cancelled',0.00,0),(61,'2025-03-18','completed',72.00,2),(62,'2025-03-18','cancelled',0.00,0),(63,'2025-03-18','cancelled',0.00,0),(64,'2025-03-18','cancelled',0.00,0),(65,'2025-03-18','cancelled',0.00,0),(66,'2025-03-18','completed',137.00,4),(67,'2025-03-18','completed',35.00,1),(68,'2025-03-18','cancelled',82.00,2),(69,'2025-03-18','completed',82.00,2),(70,'2025-03-18','completed',96.00,3),(71,'2025-03-18','completed',35.00,1),(72,'2025-03-18','completed',35.00,1),(73,'2025-03-18','cancelled',140.00,4),(74,'2025-03-18','completed',175.00,5),(75,'2025-03-18','cancelled',35.00,1),(76,'2025-03-31','completed',112.00,4),(77,'2025-04-01','completed',244.00,6),(78,'2025-04-14','completed',160.00,7),(79,'2025-05-06','completed',116.00,3),(81,'2025-05-06','completed',177.00,2),(82,'2025-05-06','cancelled',0.00,0),(83,'2025-05-06','cancelled',0.00,0),(84,'2025-05-07','completed',14.00,2),(85,'2025-05-07','cancelled',18.00,2),(86,'2025-05-07','pending',0.00,0),(87,'2025-05-07','cancelled',0.00,0),(88,'2025-05-06','cancelled',0.00,0),(89,'2025-05-06','pending',0.00,0),(90,'2025-05-06','pending',0.00,0),(91,'2025-05-06','pending',0.00,0),(92,'2025-05-06','cancelled',0.00,0),(93,'2025-05-06','completed',58.00,1),(94,'2025-05-06','pending',15.00,1),(95,'2025-05-06','cancelled',7.00,1),(96,'2025-05-06','cancelled',19.00,1),(97,'2025-05-06','cancelled',65.00,1),(98,'2025-05-06','completed',45.00,1),(99,'2025-05-06','completed',98.00,2),(100,'2025-05-06','completed',16.00,2),(101,'2025-05-06','completed',23.00,3),(102,'2025-05-06','completed',131.00,2),(103,'2025-05-06','cancelled',0.00,0),(104,'2025-05-06','completed',181.00,6),(105,'2025-05-06','completed',69.00,5),(106,'2025-05-06','completed',38.00,2),(107,'2025-05-06','completed',98.00,2),(108,'2025-05-06','completed',98.00,2),(109,'2025-05-06','completed',19.00,1),(110,'2025-05-06','cancelled',14.00,2),(111,'2025-05-06','completed',16.00,2),(112,'2025-05-07','completed',12.00,1),(113,'2025-05-09','pending',0.00,0),(114,'2025-05-09','completed',174.00,6),(115,'2025-05-10','cancelled',0.00,0),(116,'2025-05-10','cancelled',0.00,0),(117,'2025-05-10','cancelled',0.00,0),(118,'2025-05-10','cancelled',0.00,0),(119,'2025-05-10','completed',132.00,3),(120,'2025-05-11','cancelled',139.00,3),(121,'2025-05-11','completed',104.00,2),(122,'2025-05-12','cancelled',0.00,0),(123,'2025-05-12','completed',24.00,2),(124,'2025-05-17','completed',7.00,1);
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_sale_insert` BEFORE INSERT ON `sales` FOR EACH ROW BEGIN
    SET NEW.status = 'pending';
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_sale_update` AFTER UPDATE ON `sales` FOR EACH ROW BEGIN
    DECLARE existing_report INT;
    
    SELECT COUNT(*) INTO existing_report
    FROM Daily_Sales_Report
    WHERE date = NEW.sale_date;
    
    IF NEW.status = 'completed' AND OLD.status != 'completed' THEN
        IF existing_report > 0 THEN
            UPDATE Daily_Sales_Report
            SET 
                total_sales = total_sales + NEW.total_amount,
                total_items_sold = total_items_sold + NEW.total_items
            WHERE date = NEW.sale_date;
        ELSE
            INSERT INTO Daily_Sales_Report (date, total_sales, total_items_sold)
            VALUES (NEW.sale_date, NEW.total_amount, NEW.total_items);
        END IF;
    ELSEIF NEW.status = 'completed' AND OLD.status = 'completed' 
        AND (NEW.total_amount != OLD.total_amount OR NEW.total_items != OLD.total_items) THEN
        UPDATE Daily_Sales_Report
        SET 
            total_sales = total_sales - OLD.total_amount + NEW.total_amount,
            total_items_sold = total_items_sold - OLD.total_items + NEW.total_items
        WHERE date = NEW.sale_date;
    ELSEIF NEW.status = 'cancelled' AND OLD.status = 'completed' THEN
        UPDATE Daily_Sales_Report
        SET 
            total_sales = total_sales - OLD.total_amount,
            total_items_sold = total_items_sold - OLD.total_items
        WHERE date = OLD.sale_date;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `sales_items`
--

DROP TABLE IF EXISTS `sales_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales_items` (
  `sale_item_id` int NOT NULL AUTO_INCREMENT,
  `sale_id` int NOT NULL,
  `product_id` int DEFAULT NULL,
  `quantity` int NOT NULL,
  `retail_price` decimal(10,2) NOT NULL,
  `subtotal` decimal(10,2) GENERATED ALWAYS AS ((`quantity` * `retail_price`)) STORED,
  `status` enum('accepted','rejected') DEFAULT NULL,
  PRIMARY KEY (`sale_item_id`),
  KEY `sale_id_si_idx` (`sale_id`),
  KEY `product_id_si_idx` (`product_id`),
  CONSTRAINT `product_id_si_fk` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sale_id_si_fk` FOREIGN KEY (`sale_id`) REFERENCES `sales` (`sale_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=216 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales_items`
--

LOCK TABLES `sales_items` WRITE;
/*!40000 ALTER TABLE `sales_items` DISABLE KEYS */;
INSERT INTO `sales_items` (`sale_item_id`, `sale_id`, `product_id`, `quantity`, `retail_price`, `status`) VALUES (1,1,1,75,25.00,'accepted'),(2,2,2,24,37.00,'accepted'),(3,3,32,10,130.00,'accepted'),(4,4,47,10,117.00,'rejected'),(5,5,59,23,49.00,'accepted'),(6,6,67,4,213.00,'accepted'),(7,7,75,30,7.00,'rejected'),(8,8,84,24,7.00,'accepted'),(9,9,93,34,8.00,'accepted'),(10,10,107,10,20.00,'accepted'),(11,11,10,7,27.00,'accepted'),(12,12,13,11,45.00,'accepted'),(13,13,22,40,15.00,'accepted'),(14,14,23,23,15.00,'accepted'),(15,15,35,5,16.00,'accepted'),(16,16,44,23,19.00,'accepted'),(17,17,42,8,57.00,'accepted'),(18,18,52,5,246.00,'rejected'),(19,19,63,10,58.00,'accepted'),(20,20,106,10,6.00,'accepted'),(21,21,11,8,27.00,'accepted'),(22,21,10,7,27.00,'accepted'),(23,22,25,3,130.00,'accepted'),(24,22,24,10,15.00,'accepted'),(25,23,67,2,213.00,'accepted'),(26,24,79,20,9.00,'rejected'),(27,24,82,20,9.00,'accepted'),(28,24,84,20,7.00,'accepted'),(29,25,113,15,7.00,'accepted'),(30,25,108,15,20.00,'accepted'),(31,26,134,10,12.00,'accepted'),(32,27,110,8,10.00,'accepted'),(33,28,96,6,13.00,'rejected'),(34,29,79,4,9.00,'accepted'),(35,29,130,5,16.00,'rejected'),(36,30,37,7,65.00,'accepted'),(37,31,34,12,10.00,'rejected'),(38,32,9,3,23.00,'accepted'),(39,32,10,5,27.00,'accepted'),(64,33,21,5,93.00,'rejected'),(65,34,43,12,57.00,'rejected'),(66,35,65,3,173.00,'accepted'),(67,36,75,10,7.00,'rejected'),(68,36,76,10,7.00,'accepted'),(69,37,70,5,81.00,'accepted'),(70,38,77,5,13.00,'accepted'),(71,39,101,3,14.00,'accepted'),(72,40,67,3,213.00,'accepted'),(73,41,52,1,246.00,'accepted'),(74,42,45,13,19.00,'accepted'),(75,42,42,8,57.00,'accepted'),(76,43,47,2,117.00,'accepted'),(77,44,72,2,179.00,'accepted'),(78,44,90,10,8.00,'accepted'),(79,45,48,2,117.00,'accepted'),(80,46,38,2,43.00,'accepted'),(81,46,26,3,130.00,'rejected'),(82,47,93,10,8.00,'accepted'),(83,47,94,12,8.00,'accepted'),(84,48,63,5,58.00,'accepted'),(85,48,64,2,58.00,'accepted'),(86,49,4,2,32.00,'accepted'),(87,50,37,8,65.00,'accepted'),(88,50,36,5,19.00,'accepted'),(89,50,34,5,19.00,'accepted'),(90,51,15,4,24.00,'accepted'),(91,51,36,4,19.00,'accepted'),(92,51,25,2,130.00,'accepted'),(93,52,66,3,43.00,'accepted'),(95,52,1,2,35.00,'accepted'),(96,52,1,2,35.00,'accepted'),(97,52,1,2,35.00,'accepted'),(98,52,1,2,35.00,'accepted'),(99,52,1,2,35.00,'accepted'),(100,52,1,2,35.00,'accepted'),(101,52,1,2,35.00,'accepted'),(102,52,1,2,35.00,'accepted'),(103,52,1,2,35.00,'accepted'),(104,52,1,2,35.00,'accepted'),(105,53,2,1,37.00,'accepted'),(106,53,2,1,37.00,'accepted'),(107,53,2,1,37.00,'accepted'),(108,53,2,1,37.00,'accepted'),(109,53,2,1,37.00,'accepted'),(110,54,7,1,32.00,'accepted'),(111,55,12,3,45.00,'accepted'),(112,55,12,3,45.00,'accepted'),(114,56,29,2,25.00,'accepted'),(115,56,29,2,25.00,'accepted'),(116,56,29,2,25.00,'accepted'),(117,56,29,2,25.00,'accepted'),(118,56,29,2,25.00,'accepted'),(119,56,29,2,25.00,'rejected'),(120,56,29,2,25.00,'rejected'),(121,57,2,1,40.00,'accepted'),(122,57,3,1,44.00,'accepted'),(123,58,24,1,18.00,'accepted'),(124,59,1,2,35.00,'rejected'),(125,60,1,2,35.00,'rejected'),(126,61,1,1,35.00,'accepted'),(127,61,2,1,37.00,'accepted'),(128,61,1,2,35.00,'rejected'),(129,62,1,2,35.00,'rejected'),(130,62,3,2,41.00,'accepted'),(131,62,10,1,27.00,'accepted'),(132,63,1,2,35.00,'rejected'),(133,63,3,1,41.00,'accepted'),(134,64,12,1,45.00,'accepted'),(135,64,12,1,45.00,'accepted'),(136,65,1,1,35.00,'rejected'),(137,65,5,2,32.00,'rejected'),(138,66,5,1,32.00,'accepted'),(139,66,1,3,35.00,'accepted'),(140,67,1,1,35.00,'accepted'),(143,68,1,1,32.00,'rejected'),(144,68,3,2,41.00,'accepted'),(148,69,3,2,41.00,'accepted'),(151,70,8,3,32.00,'accepted'),(152,71,1,1,35.00,'accepted'),(156,73,1,2,35.00,'accepted'),(157,73,1,1,35.00,'accepted'),(159,74,1,5,35.00,'accepted'),(161,75,1,1,35.00,'accepted'),(162,76,7,2,32.00,'accepted'),(163,76,27,2,24.00,'accepted'),(164,77,34,3,12.00,'accepted'),(165,77,2,2,37.00,'accepted'),(166,77,56,1,134.00,'accepted'),(167,78,35,4,16.00,'accepted'),(168,78,7,3,32.00,'accepted'),(170,79,58,2,49.00,'accepted'),(171,79,22,1,18.00,'accepted'),(172,81,26,1,158.00,'accepted'),(173,81,131,1,19.00,'accepted'),(174,82,127,150,15.00,'rejected'),(175,83,127,1000,15.00,'rejected'),(176,84,76,2,7.00,'accepted'),(177,85,81,2,9.00,'accepted'),(179,93,64,1,58.00,'accepted'),(180,94,97,1,15.00,'accepted'),(181,95,84,1,7.00,'accepted'),(182,96,36,1,19.00,'accepted'),(183,97,37,1,65.00,'accepted'),(184,98,12,1,45.00,'accepted'),(185,99,60,2,49.00,'accepted'),(186,100,90,2,8.00,'accepted'),(187,101,86,1,7.00,'accepted'),(188,101,89,2,8.00,'accepted'),(189,102,68,1,74.00,'accepted'),(190,102,43,1,57.00,'accepted'),(191,104,13,2,45.00,'accepted'),(192,104,43,1,57.00,'accepted'),(193,104,99,2,14.00,'accepted'),(194,104,106,1,6.00,'accepted'),(196,105,106,2,6.00,'accepted'),(197,105,36,3,19.00,'accepted'),(198,106,36,2,19.00,'accepted'),(199,107,58,2,49.00,'accepted'),(200,108,58,2,49.00,'accepted'),(201,109,132,1,19.00,'accepted'),(203,110,76,2,7.00,'accepted'),(205,111,89,2,8.00,'accepted'),(206,112,134,1,12.00,'accepted'),(207,114,58,2,49.00,'accepted'),(208,114,131,4,19.00,'accepted'),(209,119,69,2,29.00,'accepted'),(210,119,68,1,74.00,'accepted'),(211,120,63,2,58.00,'accepted'),(212,120,9,1,23.00,'accepted'),(213,121,62,2,52.00,'accepted'),(214,123,134,2,12.00,'accepted'),(215,124,85,1,7.00,'accepted');
/*!40000 ALTER TABLE `sales_items` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_sale_item_insert` BEFORE INSERT ON `sales_items` FOR EACH ROW BEGIN
    DECLARE product_retail_price DECIMAL(10,2);
    DECLARE available_stock INT;
    
    SELECT retail_price, stock 
    INTO product_retail_price, available_stock
    FROM Products 
    WHERE product_id = NEW.product_id;
    
    SET NEW.retail_price = product_retail_price;
    
   IF available_stock < NEW.quantity THEN
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'Insufficient stock for this product.';
    ELSE
        SET NEW.status = 'accepted';
        UPDATE Products 
        SET stock = stock - NEW.quantity 
        WHERE product_id = NEW.product_id;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_sale_item_insert` AFTER INSERT ON `sales_items` FOR EACH ROW BEGIN
    DECLARE total_amount DECIMAL(10,2);
    DECLARE total_items INT;
    
    SELECT IFNULL(SUM(subtotal), 0), IFNULL(SUM(quantity), 0)
    INTO total_amount, total_items
    FROM Sales_Items
    WHERE sale_id = NEW.sale_id 
    AND status = 'accepted';
    
    UPDATE Sales 
    SET 
        total_amount = total_amount,
        total_items = total_items
    WHERE sale_id = NEW.sale_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_sale_item_update` BEFORE UPDATE ON `sales_items` FOR EACH ROW BEGIN
    DECLARE available_stock INT;
    
    IF NEW.quantity != OLD.quantity THEN
        IF OLD.status = 'accepted' THEN
            UPDATE Products 
            SET stock = stock + OLD.quantity 
            WHERE product_id = NEW.product_id;
        END IF;
        
        SELECT stock INTO available_stock
        FROM Products 
        WHERE product_id = NEW.product_id;
        
        IF available_stock >= NEW.quantity THEN
            SET NEW.status = 'accepted';
            UPDATE Products 
            SET stock = stock - NEW.quantity 
            WHERE product_id = NEW.product_id;
        ELSE
            SET NEW.status = 'rejected';
        END IF;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_sale_item_update` AFTER UPDATE ON `sales_items` FOR EACH ROW BEGIN
    DECLARE total_amount DECIMAL(10,2);
    DECLARE total_items INT;
    
    SELECT IFNULL(SUM(subtotal), 0), IFNULL(SUM(quantity), 0)
    INTO total_amount, total_items
    FROM Sales_Items
    WHERE sale_id = NEW.sale_id
    AND status = 'accepted';
    
    UPDATE Sales 
    SET 
        total_amount = total_amount,
        total_items = total_items
    WHERE sale_id = NEW.sale_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `before_sale_item_delete` BEFORE DELETE ON `sales_items` FOR EACH ROW BEGIN
    IF OLD.status = 'accepted' THEN
        UPDATE Products
        SET stock = stock + OLD.quantity
        WHERE product_id = OLD.product_id;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_sale_item_delete` AFTER DELETE ON `sales_items` FOR EACH ROW BEGIN
    DECLARE new_total_amount DECIMAL(10,2);
    DECLARE new_total_quantity INT;
    
    SELECT IFNULL(SUM(subtotal), 0), IFNULL(SUM(quantity), 0)
    INTO new_total_amount, new_total_quantity
    FROM Sales_Items
    WHERE sale_id = OLD.sale_id
    AND status = 'accepted';
    
    UPDATE Sales s
    SET 
        total_amount = new_total_amount,
        total_items = new_total_quantity
    WHERE s.sale_id = OLD.sale_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `supplier_id` int NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(255) NOT NULL,
  `contact_number` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Lotte Mart','09323671238'),(2,'Selecta','09672139546'),(3,'Gardenia','09423985291'),(4,'Personal Collection','09518742624'),(5,'LCC','09561234567'),(6,'CRL','09243247910'),(8,'NOVO','09891234567'),(9,'Castro','09901234567'),(10,'Rem Basallote (Yakult)','09345772812');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `contact_number` varchar(45) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Laiza Barias','09911426049','lmbb2022-2851-76296@bicol-u.edu.ph','1d481032099371b5c99ad38ff4a48155fc221d3f210225c5bd1f230445cd4842','admin'),(2,'Jeanliza Barias','09955580068','liezelbanalbarias@gmail.com','4d7620f8748b4773b7e10a1fccee322089cf07163c4dcac8b80f1defbbbe4e1b','store manager'),(6,'Kenneth Tro Barias','09123456789','kennethbarias@gmail.com','bb0854daad371bf77f35569f8b4864a335f2d87fbfbebe74189e0171e301187d','cashier');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_discounted_products`
--

DROP TABLE IF EXISTS `view_discounted_products`;
/*!50001 DROP VIEW IF EXISTS `view_discounted_products`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_discounted_products` AS SELECT 
 1 AS `ID`,
 1 AS `Product`,
 1 AS `Unit_Price`,
 1 AS `Retail_Price`,
 1 AS `Discounted_Price`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_order_items`
--

DROP TABLE IF EXISTS `view_order_items`;
/*!50001 DROP VIEW IF EXISTS `view_order_items`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_order_items` AS SELECT 
 1 AS `Order_Item_ID`,
 1 AS `Order_ID`,
 1 AS `Product`,
 1 AS `Quantity`,
 1 AS `Price`,
 1 AS `Subtotal`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_sales_items`
--

DROP TABLE IF EXISTS `view_sales_items`;
/*!50001 DROP VIEW IF EXISTS `view_sales_items`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_sales_items` AS SELECT 
 1 AS `Sale_Item_ID`,
 1 AS `Sales_ID`,
 1 AS `Product`,
 1 AS `Quantity`,
 1 AS `Price`,
 1 AS `Subtotal`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `weekly_sales_report`
--

DROP TABLE IF EXISTS `weekly_sales_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `weekly_sales_report` (
  `week_start_date` date NOT NULL,
  `week_end_date` date DEFAULT NULL,
  `total_sales` decimal(10,2) DEFAULT '0.00',
  `total_items_sold` int DEFAULT '0',
  PRIMARY KEY (`week_start_date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weekly_sales_report`
--

LOCK TABLES `weekly_sales_report` WRITE;
/*!40000 ALTER TABLE `weekly_sales_report` DISABLE KEYS */;
INSERT INTO `weekly_sales_report` VALUES ('2025-03-31','2025-04-01',356.00,10);
/*!40000 ALTER TABLE `weekly_sales_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yearly_sales_report`
--

DROP TABLE IF EXISTS `yearly_sales_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yearly_sales_report` (
  `year` int NOT NULL,
  `total_sales` decimal(10,2) DEFAULT '0.00',
  `total_items_sold` int DEFAULT '0',
  PRIMARY KEY (`year`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yearly_sales_report`
--

LOCK TABLES `yearly_sales_report` WRITE;
/*!40000 ALTER TABLE `yearly_sales_report` DISABLE KEYS */;
INSERT INTO `yearly_sales_report` VALUES (2024,1368.00,38);
/*!40000 ALTER TABLE `yearly_sales_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'retail_store'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `generate_monthly_sales_report` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `generate_monthly_sales_report` ON SCHEDULE EVERY 1 MONTH STARTS '2025-04-01 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO INSERT INTO Monthly_Sales_Report (month_date, total_sales, total_items_sold)
    SELECT 
        DATE_FORMAT(CURRENT_DATE - INTERVAL 1 MONTH, '%Y-%m-01') AS month_date,  
        IFNULL(SUM(s.total_amount), 0),
        IFNULL(SUM(s.total_items), 0)
    FROM Sales s
    WHERE s.sale_date >= DATE_FORMAT(CURRENT_DATE - INTERVAL 1 MONTH, '%Y-%m-01')  
        AND s.sale_date < DATE_FORMAT(CURRENT_DATE, '%Y-%m-01')  
    AND s.status = 'completed'
    ON DUPLICATE KEY UPDATE
        total_sales = VALUES(total_sales),
        total_items_sold = VALUES(total_items_sold) */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
/*!50106 DROP EVENT IF EXISTS `generate_yearly_sales_report` */;;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `generate_yearly_sales_report` ON SCHEDULE EVERY 1 YEAR STARTS '2025-01-01 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO INSERT INTO Yearly_Sales_Report (year, total_sales, total_items_sold)
    SELECT 
        YEAR(CURRENT_DATE) - 1 AS report_year,  
        IFNULL(SUM(total_sales), 0),
        IFNULL(SUM(total_items_sold), 0)
    FROM Monthly_Sales_Report
    WHERE YEAR(month_date) = YEAR(CURRENT_DATE) - 1
    ON DUPLICATE KEY UPDATE
        total_sales = VALUES(total_sales),
        total_items_sold = VALUES(total_items_sold) */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
/*!50106 DROP EVENT IF EXISTS `update_weekly_sales_report` */;;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8mb4 */ ;;
/*!50003 SET character_set_results = utf8mb4 */ ;;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `update_weekly_sales_report` ON SCHEDULE EVERY 1 WEEK STARTS '2025-04-07 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO INSERT INTO Weekly_Sales_Report (week_start_date, week_end_date, total_sales, total_items_sold)
    
    SELECT 
        CURRENT_DATE - INTERVAL WEEKDAY(CURRENT_DATE) DAY,
        CURRENT_DATE - INTERVAL WEEKDAY(CURRENT_DATE) DAY + INTERVAL 6 DAY + INTERVAL 23 HOUR  + INTERVAL 59 MINUTE,
        IFNULL(SUM(s.total_amount), 0),
        IFNULL(SUM(s.total_items), 0)
    FROM Sales s
    WHERE s.sale_date BETWEEN CURRENT_DATE - INTERVAL WEEKDAY(CURRENT_DATE) DAY
        AND CURRENT_DATE - INTERVAL WEEKDAY(CURRENT_DATE) DAY + INTERVAL 6 DAY + INTERVAL 23 HOUR  + INTERVAL 59 MINUTE
    AND s.status = 'completed'
    ON DUPLICATE KEY UPDATE
        total_sales = VALUES(total_sales),
        total_items_sold = VALUES(total_items_sold) */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'retail_store'
--
/*!50003 DROP FUNCTION IF EXISTS `discounted_price` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `discounted_price`(id INT) RETURNS double
    DETERMINISTIC
BEGIN
    DECLARE price DOUBLE DEFAULT 0;
    SELECT CEIL(retail_price * 0.95) INTO price FROM Products WHERE product_id = id;
    RETURN price;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_order_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_order_status`(id INT) RETURNS char(20) CHARSET utf8mb4
    DETERMINISTIC
BEGIN  
    DECLARE order_status CHAR(20);  
    SELECT status INTO order_status FROM Orders WHERE order_id = id;  
    RETURN order_status;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_stock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_stock`(id INT) RETURNS int
    DETERMINISTIC
BEGIN
    DECLARE quantity INT;
    SELECT stock INTO quantity FROM Products WHERE product_id = id;
    RETURN quantity;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `profit_margin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `profit_margin`(id INT) RETURNS double
    DETERMINISTIC
BEGIN  
    DECLARE profit DOUBLE DEFAULT 0;  
    SELECT retail_price - unit_price INTO profit FROM Products WHERE product_id = id;  
    RETURN profit;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `total_stock_value` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `total_stock_value`(id INT) RETURNS double
    DETERMINISTIC
BEGIN  
    DECLARE stock_value DOUBLE DEFAULT 0;  
    SELECT retail_price * stock INTO stock_value FROM Products WHERE product_id = id;  
    RETURN stock_value;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `adjust_price_by_supplier` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `adjust_price_by_supplier`(
    IN supp_id INT,
    IN price_percent DECIMAL(5,2)
)
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE prod_id INT;
    
    DECLARE cur CURSOR FOR 
        SELECT product_id FROM Products WHERE supplier_id = supp_id;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    OPEN cur;

    price_adjustment: LOOP
        FETCH cur INTO prod_id;

        IF done THEN 
            LEAVE price_adjustment;
        END IF;

        UPDATE Products
        SET 
            retail_price = CEIL(unit_price + (unit_price * (price_percent / 100)))
        WHERE product_id = prod_id;

    END LOOP;

    CLOSE cur;

    SELECT product_id, product_name, unit_price, retail_price 
    FROM Products
    WHERE supplier_id = supp_id;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `cancel_order` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `cancel_order`(IN p_order_id INT)
BEGIN
    UPDATE Orders
    SET status = 'cancelled'
    WHERE order_id = p_order_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `cancel_sale` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `cancel_sale`(IN p_sale_id INT)
BEGIN
    UPDATE Sales
    SET status = 'cancelled'
    WHERE sale_id = p_sale_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complete_sale` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complete_sale`(IN p_sale_id INT)
BEGIN
    UPDATE Sales 
    SET status = 'completed'
    WHERE sale_id = p_sale_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `default_retail_price` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `default_retail_price`(IN p_product_id INT)
BEGIN
    UPDATE Products
    SET retail_price = CEIL(unit_price * 1.15)
    WHERE product_id = p_product_id;

    SELECT product_id, product_name, unit_price, retail_price 
    FROM Products
    WHERE product_id = p_product_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `generate_detailed_sales_report` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `generate_detailed_sales_report`(
    IN start_date DATE,
    IN end_date DATE
)
BEGIN
    SELECT 
        s.sale_date as 'Date',
        p.product_name as 'Product',
        si.quantity as 'Quantity',
        si.retail_price as 'Retail Price',
        si.subtotal as 'Subtotal'
    FROM Sales s
    JOIN Sales_Items si ON s.sale_id = si.sale_id
    JOIN Products p ON si.product_id = p.product_id
    WHERE s.sale_date BETWEEN start_date AND end_date
      AND s.status = 'Completed'
    ORDER BY s.sale_date ASC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `generate_sales_summary_report` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `generate_sales_summary_report`(
    IN start_date DATE,
    IN end_date DATE
)
BEGIN
    -- 1. Show daily totals
    SELECT 
        s.sale_date AS `Date`,
        SUM(si.subtotal) AS `Total_Sales`,
        SUM(si.quantity) AS `Total_Items_Sold`
    FROM Sales s
    JOIN Sales_Items si ON s.sale_id = si.sale_id
    WHERE s.sale_date BETWEEN start_date AND end_date
      AND s.status = 'Completed'
    GROUP BY s.sale_date
    ORDER BY s.sale_date ASC;

    -- 2. Show grand total
    SELECT 
        'Total for Entire Date Range' AS `Summary`,
        start_date AS `Start_Date`,
        end_date AS `End_Date`,
        SUM(si.subtotal) AS `Total_Sales`,
        SUM(si.quantity) AS `Total_Items_Sold`
    FROM Sales s
    JOIN Sales_Items si ON s.sale_id = si.sale_id
    WHERE s.sale_date BETWEEN start_date AND end_date
      AND s.status = 'Completed';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_all_products_profit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_all_products_profit`()
BEGIN  
    SELECT product_id as ID, product_name as Product, retail_price as Retail_Price, unit_price as Unit_Price,  
           profit_margin(product_id) AS Profit_Margin  
    FROM Products;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_all_stock_values` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_all_stock_values`()
BEGIN  
    SELECT product_id as ID, 
		   product_name as Product, 
           retail_price As Retail_Price, 
           stock as Stock,  
           total_stock_value(product_id) AS Total_Stock_Value  
    FROM Products;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_daily_sales_report` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_daily_sales_report`()
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE d_date DATE;
    DECLARE tot_sales DECIMAL(10,2);
    DECLARE tot_items INT;
    DECLARE exist INT;

    DECLARE sales_cursor CURSOR FOR 
    SELECT s.sale_date, SUM(si.subtotal), SUM(si.quantity)
    FROM sales s
    JOIN sales_items si ON s.sale_id = si.sale_id
    WHERE s.status = 'Completed'
    GROUP BY s.sale_date;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    OPEN sales_cursor;

    sales_loop: LOOP
        FETCH sales_cursor INTO d_date, tot_sales, tot_items;

        IF done THEN 
            LEAVE sales_loop;
        END IF;

        SELECT COUNT(*) INTO exist 
        FROM Daily_Sales_Report 
        WHERE date = d_date;

        IF exist = 0 THEN
            INSERT INTO Daily_Sales_Report (date, total_sales, total_items_sold)
            VALUES (d_date, tot_sales, tot_items);
        END IF;

    END LOOP;

    CLOSE sales_cursor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `send_order` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `send_order`(IN p_order_id INT)
BEGIN
    UPDATE Orders
    SET status = 'sent'
    WHERE order_id = p_order_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_stock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_stock`(
    IN p_product_id INT,
    IN p_quantity INT
)
BEGIN
    DECLARE prev_stock INT;

    SELECT stock INTO prev_stock 
    FROM Products 
    WHERE product_id = p_product_id;

    UPDATE Products
    SET stock = GREATEST(stock + p_quantity, 0)
    WHERE product_id = p_product_id;
    
    SELECT 
        product_id, 
        product_name, 
        prev_stock AS previous_stock,  
        stock AS updated_stock
    FROM Products
    WHERE product_id = p_product_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `best_selling_products`
--

/*!50001 DROP VIEW IF EXISTS `best_selling_products`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `best_selling_products` AS select `p`.`product_id` AS `ID`,`p`.`product_name` AS `Product`,sum(`si`.`quantity`) AS `Quantity_Sold`,sum(`si`.`subtotal`) AS `Total_Revenue` from ((`sales_items` `si` join `products` `p` on((`si`.`product_id` = `p`.`product_id`))) join `sales` `s` on((`si`.`sale_id` = `s`.`sale_id`))) where (`s`.`status` = 'Completed') group by `p`.`product_id`,`p`.`product_name` order by `Quantity_Sold` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `daily_sales_summary`
--

/*!50001 DROP VIEW IF EXISTS `daily_sales_summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `daily_sales_summary` AS select `s`.`sale_date` AS `Date`,sum(`si`.`subtotal`) AS `Total_Sales` from (`sales` `s` join `sales_items` `si` on((`s`.`sale_id` = `si`.`sale_id`))) where (`s`.`status` = 'Completed') group by `s`.`sale_date` order by `s`.`sale_date` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `orders_summary`
--

/*!50001 DROP VIEW IF EXISTS `orders_summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `orders_summary` AS select `o`.`order_id` AS `ID`,`o`.`order_date` AS `Date`,`s`.`supplier_name` AS `Supplier`,`o`.`status` AS `Status`,sum(`oi`.`subtotal`) AS `Total_Amount` from ((`orders` `o` join `order_items` `oi` on((`o`.`order_id` = `oi`.`order_id`))) join `suppliers` `s` on((`o`.`supplier_id` = `s`.`supplier_id`))) group by `o`.`order_id`,`o`.`order_date`,`o`.`status` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `products_suppliers`
--

/*!50001 DROP VIEW IF EXISTS `products_suppliers`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `products_suppliers` AS select `p`.`product_id` AS `Product_ID`,`p`.`product_name` AS `Product`,`p`.`unit_price` AS `Unit_Price`,`p`.`retail_price` AS `Retail_Price`,`s`.`supplier_id` AS `Supplier_ID`,`s`.`supplier_name` AS `Supplier`,`s`.`contact_number` AS `Contact` from (`products` `p` left join `suppliers` `s` on((`p`.`supplier_id` = `s`.`supplier_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_discounted_products`
--

/*!50001 DROP VIEW IF EXISTS `view_discounted_products`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_discounted_products` AS select `products`.`product_id` AS `ID`,`products`.`product_name` AS `Product`,`products`.`unit_price` AS `Unit_Price`,`products`.`retail_price` AS `Retail_Price`,cast(`DISCOUNTED_PRICE`(`products`.`product_id`) as decimal(10,2)) AS `Discounted_Price` from `products` where (`products`.`retail_price` <> `DISCOUNTED_PRICE`(`products`.`product_id`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_order_items`
--

/*!50001 DROP VIEW IF EXISTS `view_order_items`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_order_items` AS select `oi`.`order_item_id` AS `Order_Item_ID`,`oi`.`order_id` AS `Order_ID`,`p`.`product_name` AS `Product`,`oi`.`quantity` AS `Quantity`,`oi`.`unit_price` AS `Price`,`oi`.`subtotal` AS `Subtotal` from (`order_items` `oi` join `products` `p`) where (`oi`.`product_id` = `p`.`product_id`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_sales_items`
--

/*!50001 DROP VIEW IF EXISTS `view_sales_items`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_sales_items` AS select `si`.`sale_item_id` AS `Sale_Item_ID`,`si`.`sale_id` AS `Sales_ID`,`p`.`product_name` AS `Product`,`si`.`quantity` AS `Quantity`,`si`.`retail_price` AS `Price`,`si`.`subtotal` AS `Subtotal` from (`sales_items` `si` join `products` `p`) where (`si`.`product_id` = `p`.`product_id`) */;
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

-- Dump completed on 2025-05-20 21:54:13
