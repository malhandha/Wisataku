-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 24, 2024 at 11:15 AM
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
-- Database: `wisataku`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `email_admin` varchar(40) NOT NULL,
  `password_admin` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`email_admin`, `password_admin`) VALUES
('admin@gmail.com', 'admin#1234');

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `email` varchar(50) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `sandi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`email`, `nama`, `sandi`) VALUES
('A@gmail.com', 'A', 'tes12345'),
('ahmad@gmail.com', 'ahmad', 'ahmad123'),
('nalen@gmail.com', 'PAcul', 'nalen123'),
('rojak@gmail.com', 'rojak', '12345678'),
('wildan@gmail.com', 'wildan', 'wildan123'),
('yudha@gmail.com', 'yudha', 'yudha123');

-- --------------------------------------------------------

--
-- Table structure for table `tiket`
--

CREATE TABLE `tiket` (
  `Nomor_Tiket` varchar(20) NOT NULL,
  `Nama_Pembeli` varchar(100) NOT NULL,
  `Jumlah_Tiket` int(5) NOT NULL,
  `Tanggal_Berangkat` date NOT NULL,
  `Kode_wisata` varchar(20) DEFAULT NULL,
  `Total_Harga` double(50,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tiket`
--

INSERT INTO `tiket` (`Nomor_Tiket`, `Nama_Pembeli`, `Jumlah_Tiket`, `Tanggal_Berangkat`, `Kode_wisata`, `Total_Harga`) VALUES
('WSTK001', 'yudha', 1, '2024-10-23', 'KW003', 5000000),
('WSTK002', 'nalen', 2, '2024-10-31', 'KW001', 2000000),
('WSTK003', 'rojak', 2, '2000-12-30', 'KW001', 2000000),
('WSTK004', 'loka', 4, '2024-11-02', 'KW002', 8000000),
('WSTK005', 'ahmad', 6, '2024-10-26', 'KW002', 12000000),
('WSTK006', 'ALfian', 2, '2024-10-23', 'KW003', 10000000);

-- --------------------------------------------------------

--
-- Table structure for table `wisata`
--

CREATE TABLE `wisata` (
  `Kode_Wisata` varchar(15) NOT NULL,
  `Nama_Wisata` varchar(30) DEFAULT NULL,
  `Harga` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `wisata`
--

INSERT INTO `wisata` (`Kode_Wisata`, `Nama_Wisata`, `Harga`) VALUES
('KW001', 'Borobudur', '1000000'),
('KW002', 'Bali', '2000000'),
('KW003', 'RajaAmpat', '5000000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`email_admin`);

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `tiket`
--
ALTER TABLE `tiket`
  ADD PRIMARY KEY (`Nomor_Tiket`);

--
-- Indexes for table `wisata`
--
ALTER TABLE `wisata`
  ADD PRIMARY KEY (`Kode_Wisata`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
