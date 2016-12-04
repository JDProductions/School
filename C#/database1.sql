-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.16-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for pos
CREATE DATABASE IF NOT EXISTS `pos` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pos`;

-- Dumping structure for table pos.beers
CREATE TABLE IF NOT EXISTS `beers` (
  `title` char(20) NOT NULL,
  `brewery` char(20) DEFAULT NULL,
  PRIMARY KEY (`title`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table pos.beers: ~1 rows (approximately)
/*!40000 ALTER TABLE `beers` DISABLE KEYS */;
INSERT INTO `beers` (`title`, `brewery`) VALUES
	('budlight', 'cool company');
/*!40000 ALTER TABLE `beers` ENABLE KEYS */;

-- Dumping structure for table pos.beersbought
CREATE TABLE IF NOT EXISTS `beersbought` (
  `title` char(20) NOT NULL,
  `cid` mediumint(9) NOT NULL AUTO_INCREMENT,
  `quanitybought` text,
  PRIMARY KEY (`title`,`cid`),
  KEY `cid` (`cid`),
  CONSTRAINT `beersbought_ibfk_1` FOREIGN KEY (`title`) REFERENCES `beers` (`title`),
  CONSTRAINT `beersbought_ibfk_2` FOREIGN KEY (`cid`) REFERENCES `customers` (`cid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table pos.beersbought: ~1 rows (approximately)
/*!40000 ALTER TABLE `beersbought` DISABLE KEYS */;
INSERT INTO `beersbought` (`title`, `cid`, `quanitybought`) VALUES
	('budlight', 1, '10');
/*!40000 ALTER TABLE `beersbought` ENABLE KEYS */;

-- Dumping structure for table pos.customers
CREATE TABLE IF NOT EXISTS `customers` (
  `cid` mediumint(9) NOT NULL AUTO_INCREMENT,
  `firstname` char(10) DEFAULT NULL,
  `lastname` char(20) DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`cid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Dumping data for table pos.customers: ~4 rows (approximately)
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` (`cid`, `firstname`, `lastname`, `status`) VALUES
	(1, 'Eric', 'Clapton', 1),
	(2, 'Judy', 'Higgins', 0),
	(3, 'Mike', 'Brown', 1),
	(4, 'David', 'Higgins', 0);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
