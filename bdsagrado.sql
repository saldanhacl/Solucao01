-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: bdsagrado
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `caixa`
--

DROP TABLE IF EXISTS `caixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caixa` (
  `NRSEQABERTURA` int(11) NOT NULL AUTO_INCREMENT,
  `TYPE_ENTRADA_CAIXA` varchar(1) NOT NULL,
  `DATE_MODIFY_CAIXA` datetime NOT NULL,
  `VALOR_ENTRADA_CAIXA` float NOT NULL,
  `VALOR_ATUAL_CAIXA` float NOT NULL,
  PRIMARY KEY (`NRSEQABERTURA`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caixa`
--

LOCK TABLES `caixa` WRITE;
/*!40000 ALTER TABLE `caixa` DISABLE KEYS */;
INSERT INTO `caixa` VALUES (1,'v','2018-03-28 05:39:43',1,1),(2,'v','2018-03-28 05:40:11',3,4),(3,'r','2018-03-28 07:38:36',2,2),(4,'r','2018-03-28 07:38:58',2,0),(5,'v','2018-03-28 07:41:25',5,5),(6,'f','2018-03-28 20:38:03',25,30),(7,'r','2018-03-28 20:39:05',5,25),(8,'e','2018-03-28 21:31:30',3,28),(9,'r','2018-03-28 21:31:53',5,23),(10,'v','2018-03-28 21:52:14',2,25),(11,'r','2018-03-28 21:52:27',9,16),(12,'v','2018-03-30 16:48:39',3,19),(13,'r','2018-03-30 16:48:52',4,15),(14,'v','2018-03-30 16:50:25',1,16);
/*!40000 ALTER TABLE `caixa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `CPF_USER` varchar(11) NOT NULL,
  `NOME_USER` varchar(50) NOT NULL,
  `TEL_USER` varchar(10) NOT NULL,
  `CEL_USER` varchar(11) NOT NULL,
  `EMAIL_USER` varchar(50) NOT NULL,
  `NIVEL_USER` char(1) NOT NULL DEFAULT 'B',
  `DTNASCIMENTO_USER` date NOT NULL,
  `SEXO_USER` varchar(1) NOT NULL,
  `RG_USER` varchar(8) NOT NULL,
  `SENHA_USER` varchar(8) DEFAULT NULL,
  `NRSEQ_USER` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`NRSEQ_USER`),
  UNIQUE KEY `CPF_USER` (`CPF_USER`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1 COMMENT='Tabela de usuario do restaurante sagrado, podendo ser tanto adm, cliente e funcionario.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('123','amanda','tel','cel','email','B','2018-03-21','f','rg','1',1),('456','joao','tel','cel','email','A','2018-03-21','f','rg','1',2),('789','maria','2','3','teste@gmail.com','B','2018-03-21','m','123456','2',3),('741','a','1','2','2@gmail.com','B','2018-03-21','m','1','1',4),('1','joao','tel','cel','email','A','2018-03-22','f','rg','1',5),('2','a','a','a','a','B','2018-03-22','m','a','1',7),('3','a','a','a','a','B','2018-03-22','f','a','1',8),('6','a','5','5','1','A','2018-03-22','f','1','1',9),('5','a','1','1','d','B','2018-03-28','m','a','1',10),('9','a','3','2','d','B','2018-03-28','f','1','1',11),('8','a','a','a','a','B','2018-03-28','f','a','1',16),('7','a','a','a','a','B','2018-03-28','f','a','1',18),('11','a','1','1','1','B','2018-03-28','f','1','1',19),('00000000000','AMA','1212211111','11111111111','TESTE@TESTE','A','2018-03-28','f','256','1',20);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-30 18:18:54
