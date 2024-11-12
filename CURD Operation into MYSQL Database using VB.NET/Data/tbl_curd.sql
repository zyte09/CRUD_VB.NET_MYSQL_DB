-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2024 at 04:13 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `curd`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_curd`
--

CREATE TABLE `tbl_curd` (
  `ID` int(11) NOT NULL,
  `PRODUCTNO` varchar(250) NOT NULL,
  `PRODUCTNAME` varchar(250) NOT NULL,
  `PRICE` decimal(10,2) NOT NULL,
  `GROUP` varchar(250) NOT NULL,
  `EXPDATE` date NOT NULL,
  `STATUS` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_curd`
--

INSERT INTO `tbl_curd` (`ID`, `PRODUCTNO`, `PRODUCTNAME`, `PRICE`, `GROUP`, `EXPDATE`, `STATUS`) VALUES
(1, '1234', 'Taps', 23.90, 'COOL DRINKS', '2024-11-12', '1'),
(3, '12345', 'Bar bar', 78.56, 'SWEETS', '2020-11-12', '0'),
(4, '1', 'Banana', 15.21, 'FOODS', '2024-11-15', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_curd`
--
ALTER TABLE `tbl_curd`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_curd`
--
ALTER TABLE `tbl_curd`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
