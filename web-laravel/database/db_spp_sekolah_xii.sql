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
    
);
