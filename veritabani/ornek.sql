CREATE TABLE Personel (
    pno INT PRIMARY KEY,
    adi VARCHAR(20) NOT NULL,
    soyad VARCHAR(20) NOT NULL,
    d_tarihi DATE NOT NULL,
    maas INT NOT NULL,
    gorev VARCHAR(20) NOT NULL,
    bno INT NOT NULL
);

INSERT INTO Personel (pno, adi, soyad, d_tarihi, maas, gorev, bno)
VALUES 
(1, 'Ali', 'Yılmaz', '1990-05-15', 50000, 'Mühendis', 101),
(2, 'Ahmet', 'Yılmaz', '1990-08-22', 40000, 'Aşçı', 101);


--SQL ORNEK SORGULARI

-- İsmi "A" harfi ile başlayanları listele
-- OR kullanıldığında her iki koşula da uyanlar gelir
SELECT * FROM Personel
WHERE adi LIKE 'A%' OR (gorev = 'Mühendis' AND maas > 40000);

-- Görevi "Mühendis" veya "Aşçı" olanları listele
SELECT * FROM Personel
WHERE gorev IN ('Mühendis', 'Aşçı');

-- Doğum tarihi 2000 yılından önce olanları listele
SELECT * FROM Personel
WHERE d_tarihi < CAST('2000-01-01' AS DATE);
