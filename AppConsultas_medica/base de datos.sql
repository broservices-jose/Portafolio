CREATE DATABASE  IF NOT EXISTS `consulta_medicas` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `consulta_medicas`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: consulta_medicas
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.13-MariaDB

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
-- Table structure for table `cita`
--

DROP TABLE IF EXISTS `cita`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cita` (
  `id_cita` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` varchar(12) DEFAULT NULL,
  `id_paciente` int(11) DEFAULT NULL,
  `hora` time(6) DEFAULT NULL,
  PRIMARY KEY (`id_cita`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cita`
--

LOCK TABLES `cita` WRITE;
/*!40000 ALTER TABLE `cita` DISABLE KEYS */;
INSERT INTO `cita` VALUES (1,'2001-12-15',1,'00:00:00.000000'),(2,'2001-12-15',2,'08:23:12.000000'),(10,'10/10/2016',15,'08:00:00.000000'),(11,'12/12/2016',14,'08:00:00.000000'),(12,'2/02/2016',16,'06:00:00.000000'),(13,'8/08/2016',14,'08:00:00.000000'),(14,'2/02/2016',15,'08:00:00.000000'),(15,'11/11/2016',16,'08:00:00.000000'),(16,'15/06/2016',16,'08:00:00.000000');
/*!40000 ALTER TABLE `cita` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultas`
--

DROP TABLE IF EXISTS `consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultas` (
  `num_consulta` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_consulta` varchar(45) DEFAULT NULL,
  `Motivo` varchar(45) DEFAULT NULL,
  `Enfermedad` varchar(45) DEFAULT NULL,
  `Examen` varchar(45) DEFAULT NULL,
  `Fecha` varchar(10) DEFAULT NULL,
  `Diagnostico` varchar(45) DEFAULT NULL,
  `Receta` varchar(45) DEFAULT NULL,
  `observacion` varchar(100) DEFAULT NULL,
  `id_turno` int(11) DEFAULT NULL,
  PRIMARY KEY (`num_consulta`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` VALUES (2,'Clinica','Fiebre y Dolor de Cabeza','Refriado','Orinal','12/12/16','Reposar en casa durante 12 horas al dia','Calmante','El paciente Presenta una temperatura demasiada elevada',6),(3,'Clinica','Receca','Receca ','Fisico','27/10/16','No beber mas alcohol durante 1 anios','Alka Selk Ser','Usted bebe demasiado',26),(4,'Clinica','Dolor en los huesos','Reumantesimos','sobre el reumantesismos','15/5/16','no se porque a usted le duelen todos los hues','Alka Selk Ser','',6),(5,'General','Fiebre','Temperatura alta','fjsdlkajf','27/10/16','Usted debe de trabajar','Calmante','Usted es un vago se inverto eso para no ir a trabajar',26);
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidad`
--

DROP TABLE IF EXISTS `especialidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `especialidad` (
  `id_especialidad` int(11) NOT NULL AUTO_INCREMENT,
  `especialidad` varchar(45) DEFAULT NULL,
  `id_medico` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_especialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidad`
--

LOCK TABLES `especialidad` WRITE;
/*!40000 ALTER TABLE `especialidad` DISABLE KEYS */;
INSERT INTO `especialidad` VALUES (5,'Pelotero',NULL),(7,'Pediatra',NULL),(8,'Medicina General',NULL),(9,'Cirugano',NULL),(10,'Cargiologo',NULL),(11,'Dermatologa',NULL),(12,'Ginecologa',NULL);
/*!40000 ALTER TABLE `especialidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imagen`
--

DROP TABLE IF EXISTS `imagen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `imagen` (
  `id_imagen` int(11) NOT NULL AUTO_INCREMENT,
  `imagen` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_imagen`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imagen`
--

LOCK TABLES `imagen` WRITE;
/*!40000 ALTER TABLE `imagen` DISABLE KEYS */;
INSERT INTO `imagen` VALUES (6,'WIN_20160919_150947.JPG'),(8,'H:.TrashesSistema de consultas medicaBackupsergio.'),(10,'WIN_20160905_182810.JPG'),(12,'WIN_20160919_150947.JPG'),(13,'WIN_20160905_182810.JPG'),(15,'WIN_20160905_182810.JPG'),(16,'manuel.jpg'),(17,'WIN_20160919_150947.JPG'),(18,'WIN_20160919_150947.JPG'),(19,'WIN_20160919_150947.JPG'),(21,'C:UsersJOSEPicturesCamera RollWIN_20160919_150947.'),(22,'C:UsersJOSEPicturesCamera RollWIN_20160919_151147.'),(23,'WIN_20160919_150947.JPG'),(24,'WIN_20161021_202525.JPG'),(25,'WIN_20161021_202525.JPG'),(26,'H:/.Trashes/Sistema de consultas medica/Backup/ser'),(29,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_15'),(31,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_15');
/*!40000 ALTER TABLE `imagen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medico` (
  `id_medico` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `cedula` varchar(14) DEFAULT NULL,
  `correo` varchar(40) DEFAULT NULL,
  `hora_entrada` time(6) DEFAULT NULL,
  `hora_salida` time(6) DEFAULT NULL,
  `sexo` varchar(20) DEFAULT NULL,
  `direccion` text,
  `telefono` varchar(15) DEFAULT NULL,
  `id_especialidad` int(11) DEFAULT NULL,
  `id_imagen` int(11) DEFAULT NULL,
  `fecha_nacimiento` varchar(10) DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_medico`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico`
--

LOCK TABLES `medico` WRITE;
/*!40000 ALTER TABLE `medico` DISABLE KEYS */;
INSERT INTO `medico` VALUES (5,'David','Ortiz','003-3343534','elbigpapi@gmail.com','08:00:00.000000','08:00:00.000000','Masculino','Boston el bronk de boston USA','392894893',1,6,'0000-00-00',43),(7,'Pedro','Santana','002-435344','pedrosantana@gmail.com','08:00:00.000000','08:00:00.000000','Masculino','Sector Duarte esquina los libertadores','234894344',7,8,'1986/02/31',32),(8,'Antonio ','Cruz Jiminian','0034-3248393','cruzjimina@hotmail.com','08:00:00.000000','08:00:00.000000','Masculino','cristo rey esquina los consultorios','82938383838',8,15,'1985/08/04',34),(9,'Jose Manuel','Estrella Castanios','2303-343934','manuelestrella@gmail.com','08:00:00.000000','08:00:00.000000','Masculino','Ensache naco esquina los de clase media','39834343',9,16,'1978/09/18',34),(10,'Sergio Cabrera','Tejada','034-3489432','sergiorejada@hotmail.com','08:00:00.000000','08:00:00.000000','Masculino','ensache los doctores sector los doctores','8293893443',10,17,'1983/07/20',43),(11,'Juana Mercedes','Martinez','014-3984934','juanamartinez@hotmail.cm','08:00:00.000000','08:00:00.000000','Femenino','new york the bronk around the corner','839348934',11,18,'1997/10/20',43),(12,'Jennifer','Reyes','0094-4939483','jenniferreyes@hotmail.com','08:00:00.000000','08:00:00.000000','Femenino','estoy cansado de poner direcciones','353538923',12,19,'1982/03/01',36);
/*!40000 ALTER TABLE `medico` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER set_id_m BEFORE INSERT
ON medico
FOR EACH ROW
BEGIN
    IF(SELECT MAX(id_imagen) FROM imagen) IS NULL THEN
      SET NEW.id_imagen = 1;
    ELSE
      SET NEW.id_imagen = (SELECT MAX(id_imagen) FROM imagen) + 1;
    END IF;
    IF (SELECT MAX(id_especialidad) FROM especialidad) IS NULL THEN
       SET NEW.id_especialidad = 1;
	ELSE
	   SET NEW.id_especialidad = (SELECT MAX(id_especialidad) FROM especialidad) + 1;
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `orden2`
--

DROP TABLE IF EXISTS `orden2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orden2` (
  `id_orden2` int(11) NOT NULL AUTO_INCREMENT,
  `banco` varchar(25) DEFAULT NULL,
  `meses` varchar(10) DEFAULT NULL,
  `tasa` double(6,4) DEFAULT NULL,
  `precio` double(6,4) DEFAULT NULL,
  `inicial` double(6,4) DEFAULT NULL,
  `total` double(6,4) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_vehiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_orden2`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden2`
--

LOCK TABLES `orden2` WRITE;
/*!40000 ALTER TABLE `orden2` DISABLE KEYS */;
/*!40000 ALTER TABLE `orden2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente` (
  `id_paciente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `cedula` varchar(25) DEFAULT NULL,
  `sexo` varchar(30) DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` text,
  `correo` varchar(45) DEFAULT NULL,
  `fecha_nacimiento` varchar(10) DEFAULT NULL,
  `Peso` varchar(25) DEFAULT NULL,
  `telrepresenta` varchar(15) DEFAULT NULL,
  `representante` varchar(35) DEFAULT NULL,
  `id_imagen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_paciente`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (2,'Alex','Rodriguez','002-3487483','Masculino',34,'829348934','nueva york el bronk la gran manhata','alexrod@hotmail.com','0000-00-00','324.34','82394839','hermano de alex',56),(3,'Albert','Pujols','0134-34433','Femenino',34,'83928493','san luis estados unidos los cadenales','albertpujols@gmail.com','0000-00-00','345.34','89343895','hermano de albert',57),(7,'jflksadjf','jdlskfjl','lkfjsdlkfjlk','Femenino',35,'j324093','jflksdjaflkj','lkflkdsjflkj','0000-00-00','534','jfoisdjfajsdf','jfsdklfjeiow',61),(8,'Miguel Angeul','Sanchez','002-32343','Masculino',19,'829393939','los frayles de herrera','miguelangel@hotmail.com','2017-12-11','342.3','829382393','hermano Miguel',63),(9,'fjdslkafjlk','jflkdsajlfkjlkfj','lkfsjadflkjlk','Femenino',32,'fj32843289','fjslkadjflkajfoiejwflkj','ojsafjkfsjlka','0000-00-00','343','lfjsdalfjilsdf3','fjsdlkfjl',64),(10,'fjsdlkafj','ljflskdjflk','jflksjdalkjsdkljf','Femenino',34,'30294390','jfsdakljrfweoija;vjkxcvnqvp;j','sfjlkdjfalksfj','0000-00-00','434.43','fsdjoijfsdlk','fdskljfsalkj',65),(15,'Francis','Dario','4034=2343324','Masculino',32,'83934839','los alcarrizos barrios los mentiros esquina caliente','francisdario@hotmail.com','27/23/2016','100','83934839','hermano de francis',21),(16,'Claudio','Arias','0034-32498','Masculino',40,'82938943','ensache naco esquina los millonarios','claudioarias@hotmail.com','27/10/2016','180','82938943','hermano claudio',22),(17,'Juan','Pedro','001-3434353','Masculino',23,'82934895','km #28 sector los locos','juanpedro','08/05/2016','220','82934893','hermano de juan',23),(18,'Carolina','Hinojosa','223-01788845-5','Femenino',19,'83948932','zona oriental los mina esquina caliente','carol23@hotmail.com','05/10/2016','324','829343894','Hannel la para',24),(19,'Mario ','Mingo','0023-32482','Masculino',32,'93248923','jflkjasklfdjkljlk','jflkasdjfklasjdlkf','05/12/2016','244','893439','jaskljklf',25),(20,'Hector ','Francisco','001-384934','Masculino',34,'8293894','ensache quisqueya sector la cuyaya','hectorfrancisco@gmail.com','05/02/1992','234.43','829834933','hermano de hector',26),(23,'Claudio','Arias','0034-32498','Masculino',40,'829384934','ensache naco esquina los millonarios','claudioarias@hotmail.com','15/21/2016','180','82938943','hermano claudio',27),(25,'Samuel','Reyes','001-1394389','Masculino',21,'828934983','moca municipio los yuceros','samuelreyes','15/12/1998','250','82938493','hermano de samuel',31);
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER set_id_P BEFORE INSERT
ON paciente
FOR EACH ROW
BEGIN
    IF(SELECT MAX(id_imagen) FROM imagen) IS NULL THEN
      SET NEW.id_imagen = 1;
    ELSE
      SET NEW.id_imagen = (SELECT MAX(id_imagen) FROM imagen) + 1;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `receta`
--

DROP TABLE IF EXISTS `receta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receta` (
  `id_receta` int(11) NOT NULL AUTO_INCREMENT,
  `receta` varchar(50) DEFAULT NULL,
  `indicacion` varchar(90) DEFAULT NULL,
  PRIMARY KEY (`id_receta`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receta`
--

LOCK TABLES `receta` WRITE;
/*!40000 ALTER TABLE `receta` DISABLE KEYS */;
INSERT INTO `receta` VALUES (2,'Aspirina','tomar cada 3 hora despues de beber alcohol'),(3,'Alka Selk Ser','Tomar una vez a la semana'),(4,'Calmante','tomar 3 veces al dia');
/*!40000 ALTER TABLE `receta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala_medica`
--

DROP TABLE IF EXISTS `sala_medica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sala_medica` (
  `id_sala` int(11) NOT NULL AUTO_INCREMENT,
  `sala` varchar(45) DEFAULT NULL,
  `ubicacion` varchar(40) DEFAULT NULL,
  `descripcion` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`id_sala`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala_medica`
--

LOCK TABLES `sala_medica` WRITE;
/*!40000 ALTER TABLE `sala_medica` DISABLE KEYS */;
INSERT INTO `sala_medica` VALUES (1,'P55','Sexto Piso','esta sala es para sirugias plasticas'),(2,'sala m22','cuarto piso','esta sala se utiliza para operaciones'),(3,'m23','cuarto piso','esta sala se utiliza para internal pacie'),(4,'k22','primer piso','esta sala es para sirugias plasticas'),(5,'k11','segundo piso','esta sala es para sirugias plasticas');
/*!40000 ALTER TABLE `sala_medica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turno`
--

DROP TABLE IF EXISTS `turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `turno` (
  `id_turno` int(11) NOT NULL AUTO_INCREMENT,
  `turno` varchar(45) DEFAULT NULL,
  `hora` time(6) DEFAULT NULL,
  `id_cita` int(11) DEFAULT NULL,
  `id_medico` int(11) DEFAULT NULL,
  `id_sala_medica` int(11) DEFAULT NULL,
  `fecha` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_turno`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turno`
--

LOCK TABLES `turno` WRITE;
/*!40000 ALTER TABLE `turno` DISABLE KEYS */;
INSERT INTO `turno` VALUES (1,'a21','08:23:12.000000',1,23,2,'01/12/16'),(2,'1','08:23:12.000000',12,14,2,'01/12/15'),(3,'a21','08:23:12.000000',1,23,2,'01/12/16'),(6,'A12','08:00:00.000000',12,7,3,'16/10/2016'),(23,'A14','08:23:00.000000',2,7,3,'15/00/2001'),(24,'A15','08:15:00.000000',11,9,3,'12/00/2016'),(25,'A13','08:00:00.000000',10,8,2,'10/00/2016'),(26,'A16','06:00:00.000000',12,10,2,'02/00/2016'),(27,'A20','08:00:00.000000',16,10,2,'15/00/2016'),(28,'A21','06:00:00.000000',12,9,3,'02/00/2016');
/*!40000 ALTER TABLE `turno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `permiso` varchar(45) DEFAULT NULL,
  `clave` varchar(45) DEFAULT NULL,
  `Registro_inicio_sesion` time(6) DEFAULT NULL,
  `Registro_cierre_sesion` time(6) DEFAULT NULL,
  `area` varchar(30) DEFAULT NULL,
  `id_imagen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,'Fatima Genao','Administrador','123456','06:00:23.000000','08:40:23.000000','Informatica',36),(8,'Luis Santana','Administrador','123456','08:00:00.000000','06:00:00.000000','Informatica',42),(9,'Jhoany Suero','Estandar','123456','08:00:00.000000','06:00:00.000000','Informatica',43),(10,'Canal Strong','Visitante','12345','08:00:00.000000','04:00:00.000000','Programador',44),(11,'Claudio Arias','Administrador','123456','08:00:00.000000','06:00:00.000000','Seguridad',52),(12,'Ramon Morillo','Administrador','123456','08:00:00.000000','06:00:00.000000','Informatica',10),(14,'Luis Santana','Administrador','123456','08:00:00.000000','06:00:00.000000','Redes y Comunicaciones',12),(15,'Perez Abreu','Estandar','123456','08:00:00.000000','06:00:00.000000','Soporte Tecnico',13);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER set_id_u BEFORE INSERT
ON usuario
FOR EACH ROW
BEGIN
    IF(SELECT MAX(id_imagen) FROM imagen) IS NULL THEN
      SET NEW.id_imagen = 1;
    ELSE
      SET NEW.id_imagen = (SELECT MAX(id_imagen) FROM imagen) + 1;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-13 10:19:58
