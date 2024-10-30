-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-10-2024 a las 15:07:21
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pruebatecnica`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `accesos`
--

CREATE TABLE `accesos` (
  `seg_usuario` varchar(20) CHARACTER SET latin1 COLLATE latin1_spanish_ci NOT NULL DEFAULT '',
  `seg_programa` int(11) NOT NULL DEFAULT 0,
  `seg_insertar` char(2) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT NULL,
  `seg_editar` char(2) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT NULL,
  `seg_borrar` char(2) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT NULL,
  `seg_buscar` char(2) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `per_codigo` int(11) NOT NULL DEFAULT 0,
  `per_usuario` varchar(20) CHARACTER SET latin1 COLLATE latin1_spanish_ci NOT NULL DEFAULT '',
  `per_apellido1` varchar(25) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT '',
  `per_apellido2` varchar(35) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT '',
  `per_nombre1` varchar(35) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT '',
  `per_nombre2` varchar(35) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT '',
  `per_estado` int(10) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`per_codigo`, `per_usuario`, `per_apellido1`, `per_apellido2`, `per_nombre1`, `per_nombre2`, `per_estado`) VALUES
(3, 'sergio.deleon', 'De León', '', 'Sergio', '', 0),
(9, 'smazariegos', 'mazariegos', '', 'Susana', '', 0),
(12, 'evela', 'Vela', '', 'Emilio', '', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programas`
--

CREATE TABLE `programas` (
  `pro_codigo` int(11) NOT NULL,
  `pro_descripcion` varchar(100) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `programas`
--

INSERT INTO `programas` (`pro_codigo`, `pro_descripcion`) VALUES
(1, 'Nomenclatura'),
(2, 'Tipos de Polizas'),
(3, 'Proveedores'),
(4, 'Clientes'),
(5, 'Activos Fijos'),
(6, 'Transferencia'),
(7, 'Depreciación'),
(8, 'Confirmación de Embarque'),
(9, 'Facturación'),
(10, 'Departamentos'),
(11, 'Usuarios'),
(12, 'Puestos'),
(13, 'Ayuda en Linea'),
(14, 'Accesos y Privilegios'),
(15, 'Pedidos de Clientes'),
(16, 'Libro de Exportaciones'),
(17, 'Pedido de Cliente (Proforma)'),
(18, 'Parámetros'),
(19, 'Póliza de Importación');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `accesos`
--
ALTER TABLE `accesos`
  ADD UNIQUE KEY `seg_programa` (`seg_programa`,`seg_usuario`);

--
-- Indices de la tabla `programas`
--
ALTER TABLE `programas`
  ADD PRIMARY KEY (`pro_codigo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `programas`
--
ALTER TABLE `programas`
  MODIFY `pro_codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
