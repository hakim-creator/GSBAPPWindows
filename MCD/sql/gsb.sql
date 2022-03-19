-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 08 nov. 2021 à 18:30
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `Id_Materiel` int(11) NOT NULL AUTO_INCREMENT,
  `typeMateriel` varchar(100) DEFAULT NULL,
  `dateAchat` varchar(50) DEFAULT NULL,
  `garantie` varchar(50) DEFAULT NULL,
  `fourni` varchar(100) DEFAULT NULL,
  `louer` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Materiel`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`Id_Materiel`, `typeMateriel`, `dateAchat`, `garantie`, `fourni`, `louer`) VALUES
(23, 'bkjbkjbkbkjnj', 'j jjj', 'Oui', 'vjhbhjbkjbjkb', 'Non'),
(22, 'bkjbkjbkbkjnj', 'j jjj', 'Oui', 'vjhbh', 'Non'),
(21, 'bkjbkjb', 'j jjj', 'Oui', 'vjhbh', 'Non');

-- --------------------------------------------------------

--
-- Structure de la table `probleme`
--

DROP TABLE IF EXISTS `probleme`;
CREATE TABLE IF NOT EXISTS `probleme` (
  `Id_Probleme` int(11) NOT NULL AUTO_INCREMENT,
  `objet` varchar(500) DEFAULT NULL,
  `nivUrgence` varchar(100) DEFAULT NULL,
  `dateIncid` varchar(50) DEFAULT NULL,
  `zoneInter` varchar(100) DEFAULT NULL,
  `etats` varchar(100) DEFAULT NULL,
  `priseCharge` varchar(50) DEFAULT NULL,
  `Message` varchar(1000) NOT NULL,
  `Id_Salarie` int(11) DEFAULT NULL,
  `Id_technicien` int(11) DEFAULT NULL,
  `Id_Materiel` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Probleme`),
  KEY `Id_Salarie` (`Id_Salarie`),
  KEY `Id_technicien` (`Id_technicien`),
  KEY `Id_Materiel` (`Id_Materiel`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `probleme`
--

INSERT INTO `probleme` (`Id_Probleme`, `objet`, `nivUrgence`, `dateIncid`, `zoneInter`, `etats`, `priseCharge`, `Message`, `Id_Salarie`, `Id_technicien`, `Id_Materiel`) VALUES
(1, 'BFBFHBCHJEBJHBEJHVBERVBREBVRVBRJBVHJVBVBVBJH', 'urgent', '64467', 'EST', NULL, NULL, '', NULL, NULL, NULL),
(2, NULL, NULL, NULL, NULL, '', 'Oui', 'cksdbcjksdbcjkbcdjcbdjcbjds', NULL, NULL, NULL),
(3, NULL, NULL, NULL, NULL, '', 'Non', 'zefezf', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `Id_Responsable` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id_Responsable`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `salarie`
--

DROP TABLE IF EXISTS `salarie`;
CREATE TABLE IF NOT EXISTS `salarie` (
  `Id_Salarie` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) DEFAULT NULL,
  `Prenom` varchar(100) DEFAULT NULL,
  `Matricule` varchar(50) DEFAULT NULL,
  `dateAmb` varchar(50) DEFAULT NULL,
  `Region` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `poste` varchar(100) DEFAULT NULL,
  `identifiant` varchar(100) DEFAULT NULL,
  `Mot_Passe` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id_Salarie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `technicien`
--

DROP TABLE IF EXISTS `technicien`;
CREATE TABLE IF NOT EXISTS `technicien` (
  `Id_technicien` int(11) NOT NULL AUTO_INCREMENT,
  `formation` varchar(50) DEFAULT NULL,
  `NivIntervention` varchar(50) DEFAULT NULL,
  `competence` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_technicien`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `traitement`
--

DROP TABLE IF EXISTS `traitement`;
CREATE TABLE IF NOT EXISTS `traitement` (
  `Id_traitement` int(11) NOT NULL AUTO_INCREMENT,
  `dateTrait` varchar(50) DEFAULT NULL,
  `heureDebut` varchar(50) DEFAULT NULL,
  `heureFin` varchar(50) DEFAULT NULL,
  `travRealis` varchar(500) DEFAULT NULL,
  `Id_Probleme` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_traitement`),
  KEY `Id_Probleme` (`Id_Probleme`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `Id_Visiteur` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id_Visiteur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
