-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.33 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
-- Dumping data for table pos.beers: ~0 rows (approximately)
/*!40000 ALTER TABLE `beers` DISABLE KEYS */;
REPLACE INTO `beers` (`title`, `brewery`) VALUES
	('budlight', 'cool company'),
	('budweiser', 'company cool'),
	('test', 'test'),
	('test2', 'test2');
/*!40000 ALTER TABLE `beers` ENABLE KEYS */;

-- Dumping data for table pos.beersbought: ~0 rows (approximately)
/*!40000 ALTER TABLE `beersbought` DISABLE KEYS */;
REPLACE INTO `beersbought` (`title`, `cid`, `quanitybought`) VALUES
	('budlight', 1, '14'),
	('budlight', 2, '24'),
	('budlight', 3, '7');
/*!40000 ALTER TABLE `beersbought` ENABLE KEYS */;

-- Dumping data for table pos.customers: ~4 rows (approximately)
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
REPLACE INTO `customers` (`cid`, `firstname`, `lastname`, `status`) VALUES
	(1, 'Eric', 'Clapton', 1),
	(2, 'Judy', 'Higgins', 0),
	(3, 'Mike', 'Brown', 1),
	(4, 'David', 'Higgins', 0);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
