-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-01-2019 a las 02:53:07
-- Versión del servidor: 5.6.21
-- Versión de PHP: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bancapp`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `banco`
--

CREATE TABLE IF NOT EXISTS `banco` (
  `idBanco` int(11) NOT NULL,
  `nombre` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `direccion` varchar(145) COLLATE utf8_spanish_ci NOT NULL,
  `fechaRegistro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `banco`
--

INSERT INTO `banco` (`idBanco`, `nombre`, `direccion`, `fechaRegistro`) VALUES
(1, 'Interbank', 'Av. Larco 132', '2019-01-03 00:00:00'),
(2, 'BBVA Continetal', 'Av. Mansiche 949201568', '2019-01-05 00:00:00'),
(3, 'ScotiaBank', 'Av. America 324', '2018-06-01 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ordenpago`
--

CREATE TABLE IF NOT EXISTS `ordenpago` (
  `idOrdenPago` int(11) NOT NULL,
  `monto` decimal(10,0) NOT NULL,
  `moneda` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `estado` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `fechaPago` datetime NOT NULL,
  `Sucursal_idSucursal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE IF NOT EXISTS `sucursal` (
  `idSucursal` int(11) NOT NULL,
  `nombre` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `direccion` varchar(145) COLLATE utf8_spanish_ci NOT NULL,
  `fechaRegistro` datetime NOT NULL,
  `Banco_idBanco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `sucursal`
--

INSERT INTO `sucursal` (`idSucursal`, `nombre`, `direccion`, `fechaRegistro`, `Banco_idBanco`) VALUES
(1, 'Banquito One', 'Ddadad', '0001-01-01 00:00:00', 1),
(2, 'Banquito dos', 'Dadad', '0001-01-01 00:00:00', 1),
(3, 'Banquito One one', 'adasda', '0001-01-01 00:00:00', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `idUsers` int(11) NOT NULL,
  `userName` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `password` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `role` varchar(255) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`idUsers`, `userName`, `password`, `role`) VALUES
(1, 'Operador1', '123', 'Banco, Sucursal'),
(2, 'Operador2', '123', 'OrdenPago'),
(3, 'Administrador', '123', 'Todo');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `banco`
--
ALTER TABLE `banco`
 ADD PRIMARY KEY (`idBanco`);

--
-- Indices de la tabla `ordenpago`
--
ALTER TABLE `ordenpago`
 ADD PRIMARY KEY (`idOrdenPago`), ADD KEY `fk_OrdenPago_Sucursal1_idx` (`Sucursal_idSucursal`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
 ADD PRIMARY KEY (`idSucursal`), ADD KEY `fk_Sucursal_Banco_idx` (`Banco_idBanco`);

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
 ADD PRIMARY KEY (`idUsers`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ordenpago`
--
ALTER TABLE `ordenpago`
ADD CONSTRAINT `fk_OrdenPago_Sucursal1` FOREIGN KEY (`Sucursal_idSucursal`) REFERENCES `sucursal` (`idSucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `sucursal`
--
ALTER TABLE `sucursal`
ADD CONSTRAINT `fk_Sucursal_Banco` FOREIGN KEY (`Banco_idBanco`) REFERENCES `banco` (`idBanco`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
