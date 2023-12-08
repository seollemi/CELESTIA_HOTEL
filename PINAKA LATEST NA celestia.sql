-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2023 at 08:18 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `celestia`
--

-- --------------------------------------------------------

--
-- Table structure for table `bedtype`
--

CREATE TABLE `bedtype` (
  `bedtype_id` int(3) NOT NULL,
  `bedtype_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bedtype`
--

INSERT INTO `bedtype` (`bedtype_id`, `bedtype_name`) VALUES
(1, '1 Single'),
(2, '1 Queen'),
(3, '1 King'),
(4, '1 King, 1 Twin'),
(5, '1 Queen, 1 Twin'),
(6, 'King Luxurious Bedding');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `cid` int(11) NOT NULL,
  `c_fname` varchar(50) NOT NULL,
  `c_lname` varchar(50) NOT NULL,
  `c_email` varchar(50) NOT NULL,
  `c_phone` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`cid`, `c_fname`, `c_lname`, `c_email`, `c_phone`) VALUES
(5, 'Tzuyu', 'Chou', 'thinkaboutzu@gmail.com', '1237567262'),
(9, 'Sana', 'Minatozaki', 'sm.Gmail.com', '12352567890');

--
-- Triggers `client`
--
DELIMITER $$
CREATE TRIGGER `delete_reservation` AFTER DELETE ON `client` FOR EACH ROW BEGIN
    DELETE FROM reserve WHERE clientID = OLD.cid;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `mainadmin`
--

CREATE TABLE `mainadmin` (
  `id` int(3) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `gender` varchar(5) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mainadmin`
--

INSERT INTO `mainadmin` (`id`, `fname`, `lname`, `gender`, `username`, `password`) VALUES
(1, 'Kyle', 'Ngo', 'Male', 'admin_kyle', '123');

-- --------------------------------------------------------

--
-- Table structure for table `rdetails`
--

CREATE TABLE `rdetails` (
  `rid` int(11) NOT NULL,
  `rtypeid` int(11) NOT NULL,
  `rname` varchar(100) NOT NULL,
  `btype_id` int(11) NOT NULL,
  `occupancy` int(11) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rdetails`
--

INSERT INTO `rdetails` (`rid`, `rtypeid`, `rname`, `btype_id`, `occupancy`, `price`) VALUES
(1, 1, 'Standard 1', 1, 1, 1100),
(2, 1, 'Standard 2', 2, 2, 2500),
(3, 1, 'Standard 3', 3, 2, 3000),
(4, 2, 'Suite 1', 3, 4, 5555),
(5, 4, 'S2', 6, 4, 8000),
(10, 1, 'Standard 4', 1, 1, 1000);

-- --------------------------------------------------------

--
-- Table structure for table `reserve`
--

CREATE TABLE `reserve` (
  `id` int(11) NOT NULL,
  `clientID` int(11) NOT NULL,
  `roomID` int(11) NOT NULL,
  `chIn` date NOT NULL,
  `chOut` date NOT NULL,
  `Confirmation` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reserve`
--

INSERT INTO `reserve` (`id`, `clientID`, `roomID`, `chIn`, `chOut`, `Confirmation`) VALUES
(19, 5, 2, '2023-12-08', '2023-12-10', 'yes'),
(24, 9, 4, '2023-12-09', '2023-12-14', 'yes');

-- --------------------------------------------------------

--
-- Table structure for table `roomtype`
--

CREATE TABLE `roomtype` (
  `rtypeid` int(3) NOT NULL,
  `rtype_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `roomtype`
--

INSERT INTO `roomtype` (`rtypeid`, `rtype_name`) VALUES
(1, 'Standard'),
(2, 'Suite'),
(3, 'Deluxe'),
(4, 'Family Room'),
(5, 'Penthouse');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(3) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `fname`, `lname`, `gender`, `username`, `password`) VALUES
(2, 'Chaewon', 'Kim', 'Female', 'ChaeChae', '123'),
(3, 'Tzuyu', 'Chou', 'Female', 'Tzuyu', '123456'),
(4, 'Kc', 'Pingol', 'Male', 'kc', '123'),
(5, 'Christopher', 'De leon', 'Male', 'CDO', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bedtype`
--
ALTER TABLE `bedtype`
  ADD PRIMARY KEY (`bedtype_id`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`cid`);

--
-- Indexes for table `mainadmin`
--
ALTER TABLE `mainadmin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rdetails`
--
ALTER TABLE `rdetails`
  ADD PRIMARY KEY (`rid`),
  ADD UNIQUE KEY `rname` (`rname`);

--
-- Indexes for table `reserve`
--
ALTER TABLE `reserve`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `roomID` (`roomID`);

--
-- Indexes for table `roomtype`
--
ALTER TABLE `roomtype`
  ADD PRIMARY KEY (`rtypeid`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bedtype`
--
ALTER TABLE `bedtype`
  MODIFY `bedtype_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `cid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `mainadmin`
--
ALTER TABLE `mainadmin`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `rdetails`
--
ALTER TABLE `rdetails`
  MODIFY `rid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `reserve`
--
ALTER TABLE `reserve`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `roomtype`
--
ALTER TABLE `roomtype`
  MODIFY `rtypeid` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
