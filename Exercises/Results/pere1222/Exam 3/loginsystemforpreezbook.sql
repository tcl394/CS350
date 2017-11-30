-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 30, 2017 at 10:46 PM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loginsystemforpreezbook`
--

-- --------------------------------------------------------

--
-- Table structure for table `listoffriends`
--

DROP TABLE IF EXISTS `listoffriends`;
CREATE TABLE IF NOT EXISTS `listoffriends` (
  `userid` int(255) NOT NULL,
  `friendid` int(255) NOT NULL,
  UNIQUE KEY `userid` (`userid`,`friendid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `listoffriends`
--

INSERT INTO `listoffriends` (`userid`, `friendid`) VALUES
(12, 14),
(16, 12);

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

DROP TABLE IF EXISTS `posts`;
CREATE TABLE IF NOT EXISTS `posts` (
  `postid` int(255) NOT NULL AUTO_INCREMENT,
  `senderid` int(255) NOT NULL,
  `receiverid` int(255) NOT NULL,
  `text` varchar(255) NOT NULL,
  PRIMARY KEY (`postid`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`postid`, `senderid`, `receiverid`, `text`) VALUES
(2, 16, 13, 'sdfsdf'),
(9, 12, 14, 'Hi This is John Smith'),
(5, 16, 18, 'Test');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `email` varchar(80) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `password`) VALUES
(18, 'Alberto', 'Mendoza', 'AlbertoMendoza@gmail.com', '123'),
(16, 'Juan', 'Simon', 'JuanSimon@gmail.com', 'w'),
(19, 'Barney', 'Rubble', 'okay@gmail.com', 'test'),
(14, 'Manuel', 'Alberto', 'ManuelAlberto@gmail.com', '23'),
(13, 'Juan', 'Estrada', 'JuanEstrada@gmail.com', 'asd'),
(12, 'John', 'Smith', 'JohnSmith@gmail.com', 'e'),
(20, 'Javier', 'Perez', 'preez@gmail.com', 'password');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
