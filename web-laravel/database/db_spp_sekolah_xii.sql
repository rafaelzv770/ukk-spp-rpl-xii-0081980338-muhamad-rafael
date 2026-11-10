-- Active: 1794273397980@@127.0.0.1@3306@db_spp_sekolah_xii
CREATE DATABASE db_spp_sekolah_xii;
CREATE TABLE spp (
    spp INT AUTO_INCREMENT PRIMARY KEY,
    tahun INT NOT NULL,
    nominal INT NOT NULL,
    keterangan VARCHAR(100),
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);

CREATE TABLE petugas (
    id_petugas INT PRIMARY KEY,
    username VARCHAR(30) NOT NULL,
    password VARCHAR(255) NOT NULL,
    nama_petugas VARCHAR(50) NOT NULL,
    level ENUM NOT NULL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE TABLE kelas (
    id_kelas INT PRIMARY KEY,
    nama_kelas VARCHAR(30) NOT NULL,
    kompetensi_keahlian VARCHAR(255) NOT NULL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE TABLE siswa (
    nisn CHAR(10) PRIMARY KEY,
    nis CHAR(8) NOT NULL,
    nama VARCHAR(50) NOT NULL,
    id_kelas VARCHAR(50) NOT NULL,
    alamat TEXT,
    no_telp VARCHAR(15),
    id_spp INT NOT NULL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE TABLE pembayaran (
    id_pembayaran INT PRIMARY KEY,
    id_petugas INT NOT NULL,
    nisn CHAR(10) NOT NULL,
    tgl_bayar DATE NOT NULL,
    bulan_bayar VARCHAR(15) NOT NULL,
    tahun_bayar VARCHAR(5) NOT NULL,
    no_telp VARCHAR(15) NOT NULL,
    id_spp INT NOT NULL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
