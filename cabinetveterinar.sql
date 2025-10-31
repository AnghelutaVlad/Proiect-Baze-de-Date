-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jan 19, 2025 at 03:46 PM
-- Server version: 5.7.24
-- PHP Version: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cabinetveterinar`
--

-- --------------------------------------------------------

--
-- Table structure for table `afectiunimedicale`
--

CREATE TABLE `afectiunimedicale` (
  `AfectiuneID` int(11) NOT NULL,
  `Simptome` varchar(100) DEFAULT NULL,
  `Denumire` varchar(20) NOT NULL,
  `Recomandare` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `afectiunimedicale`
--

INSERT INTO `afectiunimedicale` (`AfectiuneID`, `Simptome`, `Denumire`, `Recomandare`) VALUES
(1, 'Salivare excesivă, gingii inflamate', 'Parodontită', 'Curățarea dentară profesională'),
(2, 'Urinări frecvente, sânge în urină', 'Cistită', 'Antibiotice pentru combaterea infecției'),
(3, 'Vărsături, diaree severă', 'Parvoviroză canină', 'Spitalizare, rehidratare intravenoasă'),
(4, 'Febră, apetit scăzut', 'Leptospiroza', 'Antiboticoterapia cu penicilină sau doxiciclină'),
(5, ' Greutate excesivă, oboseală', 'Obezitatea', 'Controlul alimentației, creșterea activității fizice'),
(6, 'Vărsături, diaree, scădere în greutate', 'Paraziți interni', 'Tratament cu deparazitante'),
(7, 'Dureri articulare, dificultăți în mișcare, rigiditate', 'Artroza', 'Suplimente de glucosamină și condroitină'),
(8, 'Sete excesivă, urinare frecventă, blană subțire', 'Hiperadrenocorticism', 'Tratament cu medicamente care controlează producția de cortizol'),
(9, 'Vărsături neproductive, salivare excesivă, abdomen umflat', 'Torsionare stomac', 'Intervenție chirurgicală de urgență pentru detorsionarea stomacului'),
(10, 'Tremurături musculare, spasme, letargie', 'Eclampsia', 'Administrare de calciu intravenos sau oral');

-- --------------------------------------------------------

--
-- Table structure for table `animale`
--

CREATE TABLE `animale` (
  `AnimalID` int(11) NOT NULL,
  `ClientID` int(11) DEFAULT NULL,
  `NumeAnimal` varchar(20) NOT NULL,
  `Vârstă` int(11) DEFAULT NULL,
  `Specie` varchar(20) NOT NULL,
  `Rasă` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `animale`
--

INSERT INTO `animale` (`AnimalID`, `ClientID`, `NumeAnimal`, `Vârstă`, `Specie`, `Rasă`) VALUES
(1, 1, 'Rex', 5, 'Câine', 'Labrador'),
(2, 2, 'Matilda', 2, 'Pisică', 'Siberiană'),
(3, 3, 'Tim', 5, 'Iepure', NULL),
(4, 4, 'Pufi', 7, 'Pisică', 'Siameză'),
(5, 4, 'Verstappen', 8, 'Câine', 'Ciobănesc'),
(6, 5, 'Hamilton', 1, 'Hamster', NULL),
(7, 5, 'Leclerc', 2, 'Hamster', NULL),
(8, 5, 'Antonelli', 1, 'Porcușor de Guineea', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `animale_cu_afectiuni`
--

CREATE TABLE `animale_cu_afectiuni` (
  `AnimalID` int(11) NOT NULL,
  `AfectiuneID` int(11) NOT NULL,
  `DataDiagnostic` date DEFAULT NULL,
  `Stare` varchar(10) DEFAULT 'Nevindecat'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `animale_cu_afectiuni`
--

INSERT INTO `animale_cu_afectiuni` (`AnimalID`, `AfectiuneID`, `DataDiagnostic`, `Stare`) VALUES
(1, 3, '2024-08-10', 'Vindecat'),
(2, 6, '2024-11-01', 'Nevindecat'),
(3, 9, '2024-09-25', 'Vindecat'),
(5, 7, '2024-03-02', 'Nevindecat'),
(5, 8, '2024-07-16', 'Vindecat'),
(6, 4, '2024-06-28', 'Vindecat'),
(6, 5, '2024-11-10', 'Nevindecat'),
(7, 1, '2024-11-10', 'Nevindecat');

-- --------------------------------------------------------

--
-- Table structure for table `categoriiservicii`
--

CREATE TABLE `categoriiservicii` (
  `CategorieID` int(11) NOT NULL,
  `Denumire` varchar(20) NOT NULL,
  `Detalii` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categoriiservicii`
--

INSERT INTO `categoriiservicii` (`CategorieID`, `Denumire`, `Detalii`) VALUES
(1, 'Operații', 'Interventii chirurgicale pentru diverse afectiuni'),
(2, 'Vaccinări', 'Vaccinuri pentru prevenirea bolilor comune la animale'),
(3, 'Teste', 'Teste medicale pentru diagnosticarea bolilor'),
(4, 'Proceduri igienice', 'Proceduri care gestionează iginea, ajută la prevenirea bolilor'),
(5, 'Urgențe', 'Servicii medicale de urgență pentru animale, disponibile 24/7');

-- --------------------------------------------------------

--
-- Table structure for table `clienti`
--

CREATE TABLE `clienti` (
  `ClientID` int(11) NOT NULL,
  `Nume` varchar(50) NOT NULL,
  `Prenume` varchar(50) NOT NULL,
  `CNP` char(13) NOT NULL,
  `Telefon` char(10) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Adresă` varchar(100) DEFAULT NULL,
  `Oraș` varchar(10) NOT NULL,
  `DataNastere` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clienti`
--

INSERT INTO `clienti` (`ClientID`, `Nume`, `Prenume`, `CNP`, `Telefon`, `Email`, `Adresă`, `Oraș`, `DataNastere`) VALUES
(1, 'Alexandrescu', 'Bogdan', '5231199423674', '0735273171', 'alexbg@gmail.com', 'Iuliu Maniu Nr. 279', 'București', '1999-11-23'),
(2, 'Marinescu', 'Andrei', '5010397786231', '0747239102', 'marinandg@gmail.com', 'MIhai Bravu Nr. 302', 'București', '1997-03-01'),
(3, 'Marin', 'Carmen', '5240890432009', '0767556702', 'carmenmarin248g@gmail.com', 'Șoseaua Iancului Nr. 23', 'București', '1990-08-24'),
(4, 'Moraru', 'Daria', '6181202872269', '0745107234', 'mordar_854@yahoo.com', 'Strada Principală Nr. 10', 'Voluntari', '2002-12-18'),
(5, 'Anghel', 'Matei', '5041026420159', '0797722124', 'matei_ang_104@gmail.com', 'Calea Victoriei Nr. 103', 'București', '2004-10-26');

-- --------------------------------------------------------

--
-- Table structure for table `consultatii`
--

CREATE TABLE `consultatii` (
  `ConsultatieID` int(11) NOT NULL,
  `DataEfectuare` datetime NOT NULL,
  `AnimalID` int(11) NOT NULL,
  `MedicID` int(11) NOT NULL,
  `ServiciuID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `consultatii`
--

INSERT INTO `consultatii` (`ConsultatieID`, `DataEfectuare`, `AnimalID`, `MedicID`, `ServiciuID`) VALUES
(1, '2024-09-26 12:00:00', 3, 1, 9),
(2, '2024-05-20 12:00:00', 1, 2, 7),
(3, '2024-11-02 09:00:00', 2, 5, 8),
(4, '2024-03-11 17:00:00', 5, 3, 5),
(5, '2024-08-08 11:30:00', 6, 4, 2),
(6, '2024-07-21 15:00:00', 4, 6, 1),
(7, '2024-10-27 13:20:00', 5, 1, 3),
(8, '2024-10-27 14:20:00', 7, 2, 4),
(9, '2024-10-27 14:30:00', 6, 2, 4),
(10, '2024-11-07 16:50:00', 5, 3, 8);

-- --------------------------------------------------------

--
-- Table structure for table `reviews`
--

CREATE TABLE `reviews` (
  `ConsultatieID` int(11) NOT NULL,
  `ClientID` int(11) NOT NULL,
  `Scor` int(11) NOT NULL,
  `Recenzie` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `reviews`
--

INSERT INTO `reviews` (`ConsultatieID`, `ClientID`, `Scor`, `Recenzie`) VALUES
(1, 3, 10, 'Serviciu foarte bun, voi apela din nou la serviciile dvs!'),
(2, 1, 10, NULL),
(3, 2, 7, 'A fost un serviciu bun, dar costă un pic prea mult'),
(4, 4, 8, 'Servicu satisfăcător'),
(5, 5, 9, 'Medicul este un adevărat profesionist'),
(6, 4, 8, NULL),
(7, 4, 10, NULL),
(9, 5, 8, 'Cred că prețul poate fi un pic mai mic'),
(10, 4, 10, 'Sunt mulțumit că medicul a inspirat confort animalului');

-- --------------------------------------------------------

--
-- Table structure for table `servicii`
--

CREATE TABLE `servicii` (
  `ServiciuID` int(11) NOT NULL,
  `CategorieID` int(11) NOT NULL,
  `Preț` int(11) NOT NULL,
  `Detalii` varchar(100) DEFAULT NULL,
  `Denumire` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `servicii`
--

INSERT INTO `servicii` (`ServiciuID`, `CategorieID`, `Preț`, `Detalii`, `Denumire`) VALUES
(1, 1, 1000, 'Procedură de sterilizare', 'Castrare'),
(2, 1, 1500, 'Procedură de tratare a fracturilor', 'Sudare oase'),
(3, 2, 300, NULL, 'Vaccin anti-păduchi'),
(4, 2, 200, NULL, 'Vaccin anti-rabie'),
(5, 3, 700, NULL, 'Analize de sânge'),
(6, 3, 800, NULL, 'Radiografie'),
(7, 4, 100, 'Procedură de curățare a dinților', 'Detartraj'),
(8, 4, 200, 'Procedură de spălare completă, bună împotriva păduchilor', 'Baie'),
(9, 5, 900, NULL, 'Detorsionare stomac'),
(10, 5, 50, 'Procedură în cazuri critice pentru animal', 'Eutanasiere');

-- --------------------------------------------------------

--
-- Table structure for table `veterinari`
--

CREATE TABLE `veterinari` (
  `MedicID` int(11) NOT NULL,
  `Nume` varchar(50) NOT NULL,
  `Prenume` varchar(50) NOT NULL,
  `CNP` char(13) NOT NULL,
  `Telefon` char(10) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Adresă` varchar(100) DEFAULT NULL,
  `Oraș` varchar(10) NOT NULL,
  `DataNastere` date DEFAULT NULL,
  `Specializare` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `veterinari`
--

INSERT INTO `veterinari` (`MedicID`, `Nume`, `Prenume`, `CNP`, `Telefon`, `Email`, `Adresă`, `Oraș`, `DataNastere`, `Specializare`) VALUES
(1, 'Ionescu', 'Maria', '5800202564389', '0745123456', 'maria.ionescu@outlook.com', 'Strada Merelor 5', 'Chiajna', '1980-02-02', 'Chirurgie'),
(2, 'Rabin', 'Vlad', '5751017028179', '0734617402', 'rabin.vlad@oracle.com', 'Calea Moșilor 7', 'București', '1975-10-17', 'Radiografie'),
(3, 'Ciorescu', 'Toma', '5670218512062', '0742935643', 'ciorescu.toma@gmail.com', 'Strada Laminorului 100', 'București', '1967-02-18', 'Diagnostice'),
(4, 'Vircol', 'Cornelia', '5821010823419', '0731748634', 'vircol.cornelia@yahoo.com', 'Piața Amzei 20', 'București', '1982-10-10', 'Chirurgie'),
(5, 'Alecsio', 'Marcel', '5901120300717', '0737410757', 'marcel.alecsio@gmail.com', 'Calea Capitalei 20', 'Mogoșoaia', '1990-11-20', 'Recuperare'),
(6, 'Constantin', 'Andrei', '5730607842173', '0736290563', 'constantin.andrei@yahoo.com', 'Calea Victoriei 83', 'București', '1973-06-07', 'Chirurgie');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `afectiunimedicale`
--
ALTER TABLE `afectiunimedicale`
  ADD PRIMARY KEY (`AfectiuneID`),
  ADD UNIQUE KEY `Denumire` (`Denumire`);

--
-- Indexes for table `animale`
--
ALTER TABLE `animale`
  ADD PRIMARY KEY (`AnimalID`),
  ADD KEY `ClientID` (`ClientID`);

--
-- Indexes for table `animale_cu_afectiuni`
--
ALTER TABLE `animale_cu_afectiuni`
  ADD PRIMARY KEY (`AnimalID`,`AfectiuneID`),
  ADD KEY `AfectiuneID` (`AfectiuneID`);

--
-- Indexes for table `categoriiservicii`
--
ALTER TABLE `categoriiservicii`
  ADD PRIMARY KEY (`CategorieID`),
  ADD UNIQUE KEY `Denumire` (`Denumire`);

--
-- Indexes for table `clienti`
--
ALTER TABLE `clienti`
  ADD PRIMARY KEY (`ClientID`),
  ADD UNIQUE KEY `CNP` (`CNP`);

--
-- Indexes for table `consultatii`
--
ALTER TABLE `consultatii`
  ADD PRIMARY KEY (`ConsultatieID`),
  ADD KEY `AnimalID` (`AnimalID`),
  ADD KEY `MedicID` (`MedicID`),
  ADD KEY `ServiciuID` (`ServiciuID`);

--
-- Indexes for table `reviews`
--
ALTER TABLE `reviews`
  ADD PRIMARY KEY (`ConsultatieID`),
  ADD KEY `ClientID` (`ClientID`);

--
-- Indexes for table `servicii`
--
ALTER TABLE `servicii`
  ADD PRIMARY KEY (`ServiciuID`),
  ADD KEY `CategorieID` (`CategorieID`);

--
-- Indexes for table `veterinari`
--
ALTER TABLE `veterinari`
  ADD PRIMARY KEY (`MedicID`),
  ADD UNIQUE KEY `CNP` (`CNP`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `afectiunimedicale`
--
ALTER TABLE `afectiunimedicale`
  MODIFY `AfectiuneID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `animale`
--
ALTER TABLE `animale`
  MODIFY `AnimalID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `categoriiservicii`
--
ALTER TABLE `categoriiservicii`
  MODIFY `CategorieID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `clienti`
--
ALTER TABLE `clienti`
  MODIFY `ClientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `consultatii`
--
ALTER TABLE `consultatii`
  MODIFY `ConsultatieID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `servicii`
--
ALTER TABLE `servicii`
  MODIFY `ServiciuID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `veterinari`
--
ALTER TABLE `veterinari`
  MODIFY `MedicID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `animale`
--
ALTER TABLE `animale`
  ADD CONSTRAINT `animale_ibfk_1` FOREIGN KEY (`ClientID`) REFERENCES `clienti` (`ClientID`);

--
-- Constraints for table `animale_cu_afectiuni`
--
ALTER TABLE `animale_cu_afectiuni`
  ADD CONSTRAINT `animale_cu_afectiuni_ibfk_1` FOREIGN KEY (`AnimalID`) REFERENCES `animale` (`AnimalID`),
  ADD CONSTRAINT `animale_cu_afectiuni_ibfk_2` FOREIGN KEY (`AfectiuneID`) REFERENCES `afectiunimedicale` (`AfectiuneID`);

--
-- Constraints for table `consultatii`
--
ALTER TABLE `consultatii`
  ADD CONSTRAINT `consultatii_ibfk_1` FOREIGN KEY (`AnimalID`) REFERENCES `animale` (`AnimalID`),
  ADD CONSTRAINT `consultatii_ibfk_2` FOREIGN KEY (`MedicID`) REFERENCES `veterinari` (`MedicID`),
  ADD CONSTRAINT `consultatii_ibfk_3` FOREIGN KEY (`ServiciuID`) REFERENCES `servicii` (`ServiciuID`);

--
-- Constraints for table `reviews`
--
ALTER TABLE `reviews`
  ADD CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`ConsultatieID`) REFERENCES `consultatii` (`ConsultatieID`),
  ADD CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`ClientID`) REFERENCES `clienti` (`ClientID`);

--
-- Constraints for table `servicii`
--
ALTER TABLE `servicii`
  ADD CONSTRAINT `servicii_ibfk_1` FOREIGN KEY (`CategorieID`) REFERENCES `categoriiservicii` (`CategorieID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
