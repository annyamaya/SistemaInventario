-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-08-2024 a las 06:16:24
-- Versión del servidor: 10.4.27-MariaDB
-- Versión de PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inventario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `ID` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` varchar(30) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblautonumber`
--

INSERT INTO `tblautonumber` (`ID`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', '20', 1, 'Customer'),
(3, '20122', '15', 1, 'Suplier'),
(4, '32302', '22', 1, 'StockIn'),
(5, '102201', '23', 1, 'StockOut'),
(6, '53132', '25', 1, 'StockReturn'),
(18, 'H0000', '1', 1, 'Hose'),
(19, 'P0000', '5', 1, 'PIPE'),
(20, 'M0000', '11', 1, 'MOTORS MACHINE'),
(21, 'B0000', '4', 1, 'BELT'),
(23, 'B0000', '1', 1, 'BOLT'),
(24, 'A0000', '2', 1, 'Abarrotes'),
(26, 'L0000', '4', 1, 'Lacteos'),
(27, 'F0000', '1', 1, 'Frutas y Verduras'),
(28, 'L0000', '3', 1, 'Lacteos'),
(29, 'n0000', '1', 1, 'njvzdhsjdnv'),
(30, 'm0000', '1', 1, 'mantequilla'),
(31, 'm0000', '1', 1, 'manzana'),
(32, 'C0000', '1', 1, 'Cuajada'),
(33, 'm0000', '1', 1, 'melon');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblitems`
--

CREATE TABLE `tblitems` (
  `ITEMID` varchar(30) NOT NULL,
  `NAME` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `PRICE` double NOT NULL,
  `QTY` int(11) NOT NULL,
  `UNIT` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblitems`
--

INSERT INTO `tblitems` (`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`, `UNIT`) VALUES
('L00002', 'Queso', 'hola', 'Lacteos', 155, 9, 'Libra'),
('L00003', 'anny', 'hbsjvkjslks', 'Lacteos', 15, 10, 'kilo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblperson`
--

CREATE TABLE `tblperson` (
  `ID` int(11) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblperson`
--

INSERT INTO `tblperson` (`ID`, `SUPLIERCUSTOMERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(22, '2012212', 'anny', 'munguia', 'villanueva', '5220320', '15003200400', 'SUPLIER'),
(24, '', 'Cristian', 'baca', 'aaaa', '21111', '22222', 'Customer'),
(25, '2012213', 'Fredy', 'MOntoya', 'El Plan San Manuel', '133455454', '9855255', 'SUPLIER');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `PARA` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `PARA`) VALUES
(14, 'kilo', 'Unit'),
(18, 'Frutas y Verduras', 'Category'),
(19, 'caja', 'Unit'),
(21, 'Lacteos', 'Category'),
(24, 'mantequilla', 'Category'),
(27, 'Cuajada', 'Category'),
(28, 'melon', 'Category');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblstock_in_out`
--

CREATE TABLE `tblstock_in_out` (
  `STOCKOUTID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL,
  `REMARKS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblstock_in_out`
--

INSERT INTO `tblstock_in_out` (`STOCKOUTID`, `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`, `REMARKS`) VALUES
(68, '10220119', 'A000010', '2024-08-13', 2, 700, '000019', 'StockOut'),
(69, '10220119', 'P00003', '2024-08-13', 5, 500, '000019', 'StockOut'),
(70, '', 'A00001', '2024-08-13', 100, 16, '', 'StockIn'),
(71, '', 'L00001', '2024-08-13', 350, 35, '', 'StockIn'),
(72, '3230215', 'L00001', '2024-08-13', 2, 70, '201228', 'StockIn'),
(73, '10220120', 'L00001', '2024-08-13', 0, 0, '000011', 'StockOut'),
(74, '3230216', 'L00001', '2024-08-15', 50, 1750, '201229', 'StockIn'),
(75, '10220121', 'L00001', '2024-08-15', 0, 0, '000011', 'StockOut'),
(76, '', 'L00002', '2024-08-20', 12, 155, '', 'StockIn'),
(77, '3230217', 'L00002', '2024-08-22', 2, 310, '2012212', 'StockIn'),
(78, '10220122', 'L00002', '2024-08-22', 5, 775, '000011', 'StockOut'),
(79, '', 'L00003', '2024-08-23', 10, 15, '', 'StockIn');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblstock_return`
--

CREATE TABLE `tblstock_return` (
  `STOCKRETURNID` int(11) NOT NULL,
  `STOCKRETURNNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `RETURNDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `OWNER_CUS_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblstock_return`
--

INSERT INTO `tblstock_return` (`STOCKRETURNID`, `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`) VALUES
(7, '5313223', 'L00001', '2024-08-13', 1, 35, 11),
(8, '5313224', 'L00001', '2024-08-15', 2, 70, 11);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblsuplier`
--

CREATE TABLE `tblsuplier` (
  `ID` int(11) NOT NULL,
  `SUPLIERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tblsuplier`
--

INSERT INTO `tblsuplier` (`ID`, `SUPLIERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(5, '20201223', 'Proveedor', 'Alias', 'San Pedro Sula', '12345678', '12345678', 'SUPLIER');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `STOCKINID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) DEFAULT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `tbltransaction`
--

INSERT INTO `tbltransaction` (`STOCKINID`, `TRANSACTIONNUMBER`, `TRANSACTIONDATE`, `TYPE`, `SUPLIERCUSTOMERID`) VALUES
(30, '10220119', '2024-08-13', 'StockOut', '000019'),
(31, '3230215', '2024-08-13', 'StockIn', '201228'),
(32, '10220120', '2024-08-13', 'StockOut', '000011'),
(33, '10220120', '2024-08-13', 'Returned', '11'),
(34, '3230216', '2024-08-15', 'StockIn', '201229'),
(35, '10220121', '2024-08-15', 'StockOut', '000011'),
(36, '10220121', '2024-08-15', 'Returned', '11'),
(37, '3230217', '2024-08-22', 'StockIn', '2012212'),
(38, '10220122', '2024-08-22', 'StockOut', '000011'),
(39, '3230218', '2024-08-23', 'StockIn', '2012213'),
(40, '3230219', '2024-08-23', 'StockIn', '2012213'),
(41, '3230220', '2024-08-23', 'StockIn', '2012213'),
(42, '3230221', '2024-08-23', 'StockIn', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblvendor`
--

CREATE TABLE `tblvendor` (
  `VENDORID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `name` varchar(90) DEFAULT NULL,
  `user_name` varchar(90) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`user_id`, `name`, `user_name`, `pass`, `type`) VALUES
(19, 'admin', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(21, 'marisol', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`ITEMID`);

--
-- Indices de la tabla `tblperson`
--
ALTER TABLE `tblperson`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`SUPLIERCUSTOMERID`);

--
-- Indices de la tabla `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  ADD PRIMARY KEY (`STOCKOUTID`);

--
-- Indices de la tabla `tblstock_return`
--
ALTER TABLE `tblstock_return`
  ADD PRIMARY KEY (`STOCKRETURNID`);

--
-- Indices de la tabla `tblsuplier`
--
ALTER TABLE `tblsuplier`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SUPID` (`SUPLIERID`);

--
-- Indices de la tabla `tbltransaction`
--
ALTER TABLE `tbltransaction`
  ADD PRIMARY KEY (`STOCKINID`);

--
-- Indices de la tabla `tblvendor`
--
ALTER TABLE `tblvendor`
  ADD PRIMARY KEY (`VENDORID`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de la tabla `tblperson`
--
ALTER TABLE `tblperson`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de la tabla `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de la tabla `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  MODIFY `STOCKOUTID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=80;

--
-- AUTO_INCREMENT de la tabla `tblstock_return`
--
ALTER TABLE `tblstock_return`
  MODIFY `STOCKRETURNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `tblsuplier`
--
ALTER TABLE `tblsuplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tbltransaction`
--
ALTER TABLE `tbltransaction`
  MODIFY `STOCKINID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT de la tabla `tblvendor`
--
ALTER TABLE `tblvendor`
  MODIFY `VENDORID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
