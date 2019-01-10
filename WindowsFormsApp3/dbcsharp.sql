-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 29 Sep 2018 pada 16.18
-- Versi Server: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbcsharp`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `Kode_Barang` varchar(20) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Stok` int(11) NOT NULL,
  `Harga` int(11) NOT NULL,
  `ID_Kategori` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`Kode_Barang`, `Nama`, `Stok`, `Harga`, `ID_Kategori`) VALUES
('MKN-BST-1', 'Roma Kelapa', 100, 8000, 'MKN-BST'),
('MKN-BST-2', 'Malkist Abon', 110, 6000, 'MKN-BST'),
('MKN-KCG-1', 'Garuda Panggang', 120, 6200, 'MKN-KCG'),
('MKN-KCG-2', 'Dua Kelinci Oven Bawang', 130, 8200, 'MKN-KCG'),
('MNM-AML-1', 'Aqua 1500 mL', 75, 5200, 'MNM-AML'),
('MNM-AML-2', 'Club 1500 mL', 75, 4700, 'MNM-AML'),
('MNM-TEH-1', 'My Tea 450 mL', 130, 5800, 'MNM-TEH'),
('MNM-TEH-2', 'Teh Gelas 350 mL', 140, 3200, 'MNM-TEH'),
('SBK-BRS-1', 'Lumbung Padi 5 Kg', 20, 62500, 'SBK-BRS'),
('SBK-BRS-2', 'Padi Walet Pandan Wangi', 15, 78500, 'SBK-BRS');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategoribarang`
--

CREATE TABLE `kategoribarang` (
  `ID_Kategori` varchar(10) NOT NULL,
  `Kategori` varchar(20) NOT NULL,
  `Jenis` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kategoribarang`
--

INSERT INTO `kategoribarang` (`ID_Kategori`, `Kategori`, `Jenis`) VALUES
('MKN-BST', 'Makanan', 'Biskuit'),
('MKN-KCG', 'Makanan', 'Kacang'),
('MKN-KPK', 'Makanan', 'Keripik'),
('MKN-RT', 'Makanan', 'Roti'),
('MKN-WFR', 'Makanan', 'Wafer'),
('MNM-AML', 'Minuman', 'Air mineral'),
('MNM-SD', 'Minuman', 'Soda'),
('MNM-SRP', 'Minuman', 'Sirup'),
('MNM-SS', 'Minuman', 'Susu'),
('MNM-TEH', 'Minuman', 'Teh'),
('SBK-BRS', 'Sembako', 'Beras'),
('SBK-GP', 'Sembako', 'Gula Pasir'),
('SBK-GRM', 'Sembako', 'Garam'),
('SBK-MYK', 'Sembako', 'Minyak Goreng'),
('SBK-TLR', 'Sembako', 'Telur');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` varchar(20) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama`, `alamat`) VALUES
('165150200111001', 'Kukuh Haryobismoko', 'Kediri'),
('165150200111002', 'Abu Wildan M', 'Purwokerto');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `Kode_Transaksi` varchar(30) NOT NULL,
  `Kode_Barang` varchar(10) NOT NULL,
  `Nama_Barang` varchar(30) NOT NULL,
  `Harga` int(11) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id`, `nama`, `username`, `password`) VALUES
(11, 'Abu Wildan M', 'wildan', '12345'),
(12, 'Fabiansyah Cahyo', 'cahyo', '23456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`Kode_Barang`),
  ADD KEY `ID_Kategori` (`ID_Kategori`);

--
-- Indexes for table `kategoribarang`
--
ALTER TABLE `kategoribarang`
  ADD PRIMARY KEY (`ID_Kategori`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`Kode_Transaksi`),
  ADD KEY `Kode_Barang` (`Kode_Barang`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD CONSTRAINT `barang_ibfk_1` FOREIGN KEY (`ID_Kategori`) REFERENCES `kategoribarang` (`ID_Kategori`);

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`Kode_Barang`) REFERENCES `barang` (`Kode_Barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
