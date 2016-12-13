CREATE DATABASE  IF NOT EXISTS `mantenimiento` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mantenimiento`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: mantenimiento
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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `id_persona` int(11) DEFAULT NULL,
  `comentarios` varchar(255) DEFAULT NULL,
  `rnc` varchar(25) DEFAULT NULL,
  `nfc` varchar(25) DEFAULT NULL,
  `tipo_cliente` varchar(30) DEFAULT NULL,
  `id_imagen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (2,2,'nada mas que decir','232222','1010101','preferencial',2),(3,0,'no hay nada que decir','3489','4323','Llenar requisito',0);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_labormecanica`
--

DROP TABLE IF EXISTS `detalle_labormecanica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_labormecanica` (
  `id_detalle_labmecanica` int(11) NOT NULL AUTO_INCREMENT,
  `id_mecanico` int(11) DEFAULT NULL,
  `id_orden` int(11) DEFAULT NULL,
  `id_servicio` int(11) DEFAULT NULL,
  `importe` double(4,2) DEFAULT NULL,
  `pago` double(4,2) DEFAULT NULL,
  `fecha_pago` date DEFAULT NULL,
  PRIMARY KEY (`id_detalle_labmecanica`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_labormecanica`
--

LOCK TABLES `detalle_labormecanica` WRITE;
/*!40000 ALTER TABLE `detalle_labormecanica` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_labormecanica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_orden`
--

DROP TABLE IF EXISTS `detalle_orden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_orden` (
  `id_detalle_orden` int(11) NOT NULL AUTO_INCREMENT,
  `id_servicio` int(11) DEFAULT NULL,
  `tipo` varchar(5) DEFAULT NULL,
  `cantidad` int(15) DEFAULT NULL,
  `costo` double(4,2) DEFAULT NULL,
  `precio` double(4,2) DEFAULT NULL,
  `importe` double(4,2) DEFAULT NULL,
  `itbis` double(4,2) DEFAULT NULL,
  `neto` double(4,2) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `descuentos` double(4,2) DEFAULT NULL,
  `id_mecanico` int(11) DEFAULT NULL,
  `totales` double(4,2) DEFAULT NULL,
  PRIMARY KEY (`id_detalle_orden`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_orden`
--

LOCK TABLES `detalle_orden` WRITE;
/*!40000 ALTER TABLE `detalle_orden` DISABLE KEYS */;
INSERT INTO `detalle_orden` VALUES (1,1,'pieza',10,99.99,99.99,99.99,0.18,99.99,'que se yo',0.34,1,99.99);
/*!40000 ALTER TABLE `detalle_orden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `id_factura` int(11) NOT NULL AUTO_INCREMENT,
  `id_servicio` int(11) DEFAULT NULL,
  `id_orden` int(11) DEFAULT NULL,
  `servicio_realizado` varchar(15) DEFAULT NULL,
  `Id_cliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imagen`
--

DROP TABLE IF EXISTS `imagen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `imagen` (
  `id_imagen` int(11) NOT NULL AUTO_INCREMENT,
  `imagen` text,
  `tipo_imagen` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_imagen`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imagen`
--

LOCK TABLES `imagen` WRITE;
/*!40000 ALTER TABLE `imagen` DISABLE KEYS */;
INSERT INTO `imagen` VALUES (1,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_151147.JPG','cliente'),(2,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_151147.JPG','cliente'),(3,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_151147.JPG','cliente'),(4,'P:\\proyecto manuel\\descarga (1).jpg',NULL),(5,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_150947.JPG','0'),(6,'WIN_20160919_150947.JPG','0'),(7,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_150947.JPG','cliente'),(8,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_151147.JPG','0'),(9,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_150947.JPG','0'),(10,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20160919_150947.JPG','cliente'),(11,'C:\\Users\\JOSE\\Pictures\\Camera Roll\\WIN_20161021_202527.JPG','0'),(12,'WIN_20161021_202527.JPG','0'),(13,'WIN_20161021_202527.JPG','0'),(14,'WIN_20161021_202527.JPG','0'),(15,'WIN_20161021_202527.JPG','0');
/*!40000 ALTER TABLE `imagen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mecanico`
--

DROP TABLE IF EXISTS `mecanico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mecanico` (
  `id_mecanico` int(11) NOT NULL AUTO_INCREMENT,
  `id_persona` int(11) DEFAULT NULL,
  `fecha_contraracion` date DEFAULT '2016-09-05',
  `taller` varchar(50) DEFAULT NULL,
  `sueldo_base` double(6,2) DEFAULT '0.00',
  `precio_hora` double(6,2) DEFAULT '0.00',
  `id_imagen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_mecanico`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mecanico`
--

LOCK TABLES `mecanico` WRITE;
/*!40000 ALTER TABLE `mecanico` DISABLE KEYS */;
INSERT INTO `mecanico` VALUES (3,2,'2016-02-13','otra cosa',1010.30,233.34,9);
/*!40000 ALTER TABLE `mecanico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden`
--

DROP TABLE IF EXISTS `orden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orden` (
  `num_orden` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `situacion` varchar(15) DEFAULT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_vehiculo` int(11) DEFAULT NULL,
  `kilometraje` varchar(15) DEFAULT NULL,
  `combustible` varchar(15) DEFAULT NULL,
  `llave` tinyint(1) DEFAULT NULL,
  `llave_rueda` varchar(15) DEFAULT NULL,
  `gato` tinyint(1) DEFAULT NULL,
  `tapabocina` tinyint(1) DEFAULT NULL,
  `radio` tinyint(1) DEFAULT NULL,
  `triangulo` tinyint(1) DEFAULT NULL,
  `evaluacio_previa` tinyint(1) DEFAULT NULL,
  `repuesta` tinyint(1) DEFAULT NULL,
  `estado_ingreso` varchar(255) DEFAULT NULL,
  `fecha_salida` date DEFAULT NULL,
  PRIMARY KEY (`num_orden`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden`
--

LOCK TABLES `orden` WRITE;
/*!40000 ALTER TABLE `orden` DISABLE KEYS */;
/*!40000 ALTER TABLE `orden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido` (
  `id_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `producto` varchar(30) DEFAULT NULL,
  `total` double(12,4) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_pedido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personas`
--

DROP TABLE IF EXISTS `personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personas` (
  `id_persona` int(11) NOT NULL AUTO_INCREMENT,
  `trato` varchar(25) DEFAULT 'normal',
  `tipo_documento` varchar(20) NOT NULL,
  `num_documento` varchar(20) NOT NULL,
  `nombre` varchar(25) DEFAULT 'sin nombre',
  `apellido` varchar(25) DEFAULT 'sin apellido',
  `sexo` varchar(20) DEFAULT 'que soy yo?',
  `nacimiento` date DEFAULT '2016-09-05',
  `telefono` varchar(15) DEFAULT 'sin numero',
  `correo` varchar(30) DEFAULT 'sin correo ',
  `direccion` varchar(100) NOT NULL,
  `nacionalidad` varchar(30) NOT NULL,
  PRIMARY KEY (`id_persona`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personas`
--

LOCK TABLES `personas` WRITE;
/*!40000 ALTER TABLE `personas` DISABLE KEYS */;
INSERT INTO `personas` VALUES (2,'licenciado','cedula','1839438','Ricardo','Fernandez','Masculino','0000-00-00','829383838','ricardofernandezgmail.com','los guaricano','Dominicano');
/*!40000 ALTER TABLE `personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recibo`
--

DROP TABLE IF EXISTS `recibo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `recibo` (
  `fecha` date DEFAULT NULL,
  `documento` int(11) DEFAULT NULL,
  `documento_fuente` int(11) DEFAULT NULL,
  `detalle` varchar(50) DEFAULT NULL,
  `debito` double(4,2) DEFAULT NULL,
  `credito` double(4,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recibo`
--

LOCK TABLES `recibo` WRITE;
/*!40000 ALTER TABLE `recibo` DISABLE KEYS */;
/*!40000 ALTER TABLE `recibo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicio` (
  `id_servicio` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_servicio` varchar(5) DEFAULT NULL,
  `descripcion` text,
  `costo` double(6,2) DEFAULT '0.00',
  `horas_servicio` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `porcentaje1` double(6,2) DEFAULT NULL,
  `porcentaje2` double(6,2) DEFAULT NULL,
  `porcentaje3` double(6,2) DEFAULT NULL,
  PRIMARY KEY (`id_servicio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `talleres`
--

DROP TABLE IF EXISTS `talleres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `talleres` (
  `Id_taller` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  `encargado` varchar(25) DEFAULT NULL,
  `ubicacion` varchar(25) DEFAULT NULL,
  `descripcion` text,
  PRIMARY KEY (`Id_taller`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `talleres`
--

LOCK TABLES `talleres` WRITE;
/*!40000 ALTER TABLE `talleres` DISABLE KEYS */;
/*!40000 ALTER TABLE `talleres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `total_venta`
--

DROP TABLE IF EXISTS `total_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `total_venta` (
  `id_totalvetna` int(11) NOT NULL AUTO_INCREMENT,
  `total` double(12,4) DEFAULT NULL,
  `id_clietne` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_totalvetna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `total_venta`
--

LOCK TABLES `total_venta` WRITE;
/*!40000 ALTER TABLE `total_venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `total_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(25) DEFAULT NULL,
  `permiso` varchar(25) DEFAULT NULL,
  `clave` varchar(25) DEFAULT NULL,
  `departamento` varchar(50) DEFAULT NULL,
  `fecha_ingreso` date DEFAULT '2016-09-05',
  `id_imagen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Ramon ','Administrador','123456','Informatica','0005-04-16',0),(2,'Pedro','Estandar','rodriguez','Limpieza','0005-05-16',0),(3,'fdsjfjlk','adsajflks','lkfdjsdlsjf','fhdskjhfkja','0007-10-16',0),(4,'juanito','administrador','123456','informaitca','2012-12-16',0),(5,'juanito','administrador','123456','informaitca','2012-12-16',0),(6,'juanito','administrador','123456','informaitca','2012-12-16',0),(7,'juanito','administrador','123456','informaitca','2012-12-16',0),(8,'juanito','administrador','123456','informaitca','2012-12-16',0);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculo`
--

DROP TABLE IF EXISTS `vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehiculo` (
  `matricula` varchar(25) NOT NULL,
  `chasis` varchar(25) DEFAULT NULL,
  `placa` varchar(25) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `marca` varchar(25) DEFAULT NULL,
  `modelo` varchar(25) DEFAULT NULL,
  `version` varchar(25) DEFAULT NULL,
  `anio` date DEFAULT NULL,
  `color` varchar(25) DEFAULT NULL,
  `traccion` varchar(25) DEFAULT NULL,
  `transimision` varchar(25) DEFAULT NULL,
  `tipo_combustible` varchar(25) DEFAULT NULL,
  `fecha_registro` date DEFAULT NULL,
  `observaciones` varchar(255) DEFAULT NULL,
  `id_imagen` int(11) DEFAULT NULL,
  PRIMARY KEY (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiculo`
--

LOCK TABLES `vehiculo` WRITE;
/*!40000 ALTER TABLE `vehiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-13 10:21:35
