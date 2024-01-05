-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Час створення: Лис 22 2023 р., 19:31
-- Версія сервера: 10.4.28-MariaDB
-- Версія PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `cashierstation`
--

-- --------------------------------------------------------

--
-- Структура таблиці `client`
--

CREATE TABLE `client` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(255) NOT NULL,
  `TicketId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `client`
--

INSERT INTO `client` (`id`, `Name`, `Surname`, `TicketId`) VALUES
(11, 'Тарас', 'Стецюк', 2311);

-- --------------------------------------------------------

--
-- Структура таблиці `intermediateroute`
--

CREATE TABLE `intermediateroute` (
  `id` int(11) NOT NULL,
  `RouteId` int(11) NOT NULL,
  `NameStation` varchar(255) NOT NULL,
  `DistanceFromStart` int(11) NOT NULL,
  `DistanceToEnd` int(11) NOT NULL,
  `ArrivalTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `intermediateroute`
--

INSERT INTO `intermediateroute` (`id`, `RouteId`, `NameStation`, `DistanceFromStart`, `DistanceToEnd`, `ArrivalTime`) VALUES
(2, 123, 'qwe', 123, 312, '2023-11-09 18:47:04');

-- --------------------------------------------------------

--
-- Структура таблиці `keyword`
--

CREATE TABLE `keyword` (
  `id` int(11) NOT NULL,
  `word` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `keyword`
--

INSERT INTO `keyword` (`id`, `word`) VALUES
(1, 'шифр');

-- --------------------------------------------------------

--
-- Структура таблиці `route`
--

CREATE TABLE `route` (
  `id` int(11) NOT NULL,
  `StartPoint` varchar(255) NOT NULL,
  `EndPoint` varchar(255) NOT NULL,
  `DateofStart` datetime NOT NULL,
  `DateofEnd` datetime NOT NULL,
  `SeatsNumber` int(11) NOT NULL,
  `TransportId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `route`
--

INSERT INTO `route` (`id`, `StartPoint`, `EndPoint`, `DateofStart`, `DateofEnd`, `SeatsNumber`, `TransportId`) VALUES
(123, 'йцу', 'asdas', '2023-11-06 18:47:04', '2023-11-06 18:47:04', 22, 1),
(222, 'йцу', '222', '2023-11-08 18:47:04', '2023-11-08 18:47:04', 222, 123),
(1111, 'йцу', '222', '2023-11-06 18:47:04', '2023-11-06 18:47:04', 22, 2);

-- --------------------------------------------------------

--
-- Структура таблиці `ticket`
--

CREATE TABLE `ticket` (
  `id` int(11) NOT NULL,
  `RouteId` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `DateBuy` datetime DEFAULT NULL,
  `IsActive` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `ticket`
--

INSERT INTO `ticket` (`id`, `RouteId`, `Price`, `DateBuy`, `IsActive`) VALUES
(1, 123, 122, '2023-11-22 16:25:38', 0),
(2311, 1111, 3223, '2023-11-22 16:49:55', 1);

-- --------------------------------------------------------

--
-- Структура таблиці `transport`
--

CREATE TABLE `transport` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `transport`
--

INSERT INTO `transport` (`id`, `Name`) VALUES
(1, 'we'),
(2, 'qweqwqweqwe'),
(123, 'qweqwqweqwe');

-- --------------------------------------------------------

--
-- Структура таблиці `workers`
--

CREATE TABLE `workers` (
  `id` int(11) NOT NULL,
  `login` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп даних таблиці `workers`
--

INSERT INTO `workers` (`id`, `login`, `password`) VALUES
(1, '111', '111'),
(2, 'qweqwe', '123123'),
(3, 'qweqwe', '123123');

--
-- Індекси збережених таблиць
--

--
-- Індекси таблиці `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`),
  ADD KEY `client_ibfk_1` (`TicketId`);

--
-- Індекси таблиці `intermediateroute`
--
ALTER TABLE `intermediateroute`
  ADD PRIMARY KEY (`id`),
  ADD KEY `intermediateroute_ibfk_1` (`RouteId`);

--
-- Індекси таблиці `keyword`
--
ALTER TABLE `keyword`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `route`
--
ALTER TABLE `route`
  ADD PRIMARY KEY (`id`),
  ADD KEY `route_ibfk_1` (`TransportId`);

--
-- Індекси таблиці `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ticket_ibfk_1` (`RouteId`);

--
-- Індекси таблиці `transport`
--
ALTER TABLE `transport`
  ADD PRIMARY KEY (`id`);

--
-- Індекси таблиці `workers`
--
ALTER TABLE `workers`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для збережених таблиць
--

--
-- AUTO_INCREMENT для таблиці `client`
--
ALTER TABLE `client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблиці `intermediateroute`
--
ALTER TABLE `intermediateroute`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблиці `keyword`
--
ALTER TABLE `keyword`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблиці `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2312;

--
-- AUTO_INCREMENT для таблиці `workers`
--
ALTER TABLE `workers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Обмеження зовнішнього ключа збережених таблиць
--

--
-- Обмеження зовнішнього ключа таблиці `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`TicketId`) REFERENCES `ticket` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Обмеження зовнішнього ключа таблиці `intermediateroute`
--
ALTER TABLE `intermediateroute`
  ADD CONSTRAINT `intermediateroute_ibfk_1` FOREIGN KEY (`RouteId`) REFERENCES `route` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Обмеження зовнішнього ключа таблиці `route`
--
ALTER TABLE `route`
  ADD CONSTRAINT `route_ibfk_1` FOREIGN KEY (`TransportId`) REFERENCES `transport` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Обмеження зовнішнього ключа таблиці `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`RouteId`) REFERENCES `route` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
