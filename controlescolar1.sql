-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-05-2025 a las 06:25:37
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `controlescolar1`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarAlumno` (IN `id_alumno` INT)   BEGIN
    DECLARE id_usuario_alumno INT;
    
    -- Obtener el ID del usuario asociado al profesor
    SELECT id_usuario INTO id_usuario_alumno FROM alumnos WHERE idalumno = id_alumno;
    
    -- Eliminar al profesor
    DELETE FROM Alumnos WHERE idalumno = id_alumno;
    
    -- Eliminar al usuario asociado
    DELETE FROM usuarios WHERE id = id_usuario_alumno;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarProfesor` (IN `id_profesor` INT)   BEGIN
    DECLARE id_usuario_profesor INT;
    
    -- Obtener el ID del usuario asociado al profesor
    SELECT id_usuario INTO id_usuario_profesor FROM profesores WHERE idProfesor = id_profesor;
    
    -- Eliminar al profesor
    DELETE FROM profesores WHERE idProfesor = id_profesor;
    
    -- Eliminar al usuario asociado
    DELETE FROM usuarios WHERE id = id_usuario_profesor;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UsuarioAlumno` (IN `Nombre` VARCHAR(255), IN `Apellido` VARCHAR(255), IN `phone` VARCHAR(225), IN `acceso` INT)   BEGIN
	DECLARE nombre1 varchar(45);
    DECLARE apellido1 varchar(45);
    DECLARE phone1 varchar(45);
    DECLARE acceso1 varchar(45);
	
	DECLARE generated_username varchar(45);
    DECLARE generated_pass varchar(45);
    DECLARE generated_password VARCHAR(255);
    DECLARE generated_email VARCHAR(255);
    DECLARE idvalue int;
    
    SET nombre1= CONCAT(Nombre);
    SET apellido1= CONCAT(Apellido);
    SET phone1= CONCAT(phone);
    SET acceso1= CONCAT(acceso);
    
    -- Generar contraseña y correo electrónico
    INSERT INTO Usuarios() VALUES ();
        SET idvalue=last_insert_id();
        
    INSERT INTO alumnos() VALUES();
    SET generated_username = CONCAT(LAST_INSERT_ID());
	SET generated_pass = CONCAT(LAST_INSERT_ID());
	
    -- Insertar en la tabla Usuarios
    
    SET @last_id = LAST_INSERT_ID();
    UPDATE alumnos SET id_usuario=idvalue, Nombre=nombre1, Apellido=apellido1, Telefono=phone1 where idAlumno=generated_pass;
    SET generated_password = CONCAT(upper(substring(Nombre,1,1)),upper(substring(Apellido,1,2)),generated_pass);
    SET generated_email = CONCAT(generated_username, '@uadeo.mx');
    
    UPDATE alumnos SET correo= generated_email where idAlumno=generated_pass;
    UPDATE usuarios SET Usuario=generated_pass, contraseña=generated_password, nivelAcceso=acceso1 where id=idvalue;
    
    SET @last_id= LAST_INSERT_ID();
    UPDATE usuarios SET Usuario=@last_id where id=idvalue;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UsuarioConProfesor` (IN `Nombre` VARCHAR(255), IN `Apellido` VARCHAR(255), IN `phone` VARCHAR(225), IN `acceso` INT)   BEGIN
	DECLARE nombre1 varchar(45);
    DECLARE apellido1 varchar(45);
    DECLARE phone1 varchar(45);
    DECLARE acceso1 varchar(45);
	
	DECLARE generated_username varchar(45);
    DECLARE generated_pass varchar(45);
    DECLARE generated_password VARCHAR(255);
    DECLARE generated_email VARCHAR(255);
    DECLARE idvalue int;
    
    SET nombre1= CONCAT(Nombre);
    SET apellido1= CONCAT(Apellido);
    SET phone1= CONCAT(phone);
    SET acceso1= CONCAT(acceso);
    
    -- Generar contraseña y correo electrónico
    INSERT INTO Usuarios () VALUES ();
        SET idvalue=last_insert_id();
        
    INSERT INTO profesores() VALUES();
    SET generated_username = CONCAT(LAST_INSERT_ID());
	SET generated_pass = CONCAT(LAST_INSERT_ID());
	
    -- Insertar en la tabla Usuarios
    
    SET @last_id = LAST_INSERT_ID();
    UPDATE profesores SET id_usuario=idvalue, Nombre=nombre1, Apellido=apellido1, Telefono=phone1 where idProfesor=generated_pass;
    SET generated_password = CONCAT(upper(substring(Nombre,1,1)),upper(substring(Apellido,1,2)),generated_pass);
    SET generated_email = CONCAT(generated_username, '@uadeo.mx');
    
    UPDATE profesores SET correo= generated_email where idProfesor=generated_pass;
    UPDATE usuarios SET Usuario=generated_pass, contraseña=generated_password, nivelAcceso=acceso1 where id=idvalue;
    
    SET @last_id= LAST_INSERT_ID();
    UPDATE usuarios SET Usuario=@last_id where id=idvalue;
    
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administradores`
--

CREATE TABLE `administradores` (
  `idAdmin` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `nombre` varchar(50) NOT NULL,
  `correo` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `idAlumno` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido` varchar(45) NOT NULL,
  `Telefono` int(11) NOT NULL,
  `correo` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`idAlumno`, `id_usuario`, `Nombre`, `Apellido`, `Telefono`, `correo`) VALUES
(32040001, 10000007, 'Yaset Alejandro', 'Meza Valenzuela', 2147483647, '32040001@uadeo.mx');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_escolar`
--

CREATE TABLE `control_escolar` (
  `idControlEscolar` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido` varchar(45) NOT NULL,
  `Cargo` varchar(45) NOT NULL,
  `correo` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materias`
--

CREATE TABLE `materias` (
  `idMateria` int(11) NOT NULL,
  `id_profesor` int(11) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `materias`
--

INSERT INTO `materias` (`idMateria`, `id_profesor`, `Nombre`) VALUES
(1, 22040002, 'ISOF01');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesores`
--

CREATE TABLE `profesores` (
  `idProfesor` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido` varchar(45) NOT NULL,
  `Telefono` int(11) NOT NULL,
  `Correo` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `profesores`
--

INSERT INTO `profesores` (`idProfesor`, `id_usuario`, `Nombre`, `Apellido`, `Telefono`, `Correo`) VALUES
(22040002, 10000004, 'Adal', 'Gastelum', 2147483647, '22040002@uadeo.mx');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `nivelAcceso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `Usuario`, `contraseña`, `nivelAcceso`) VALUES
(10000004, '22040002', 'AGA22040002', 2),
(10000007, '32040001', 'YME32040001', 3);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `administradores`
--
ALTER TABLE `administradores`
  ADD PRIMARY KEY (`idAdmin`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`idAlumno`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `control_escolar`
--
ALTER TABLE `control_escolar`
  ADD PRIMARY KEY (`idControlEscolar`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `materias`
--
ALTER TABLE `materias`
  ADD PRIMARY KEY (`idMateria`),
  ADD KEY `id_profesor` (`id_profesor`);

--
-- Indices de la tabla `profesores`
--
ALTER TABLE `profesores`
  ADD PRIMARY KEY (`idProfesor`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Usuario` (`Usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `administradores`
--
ALTER TABLE `administradores`
  MODIFY `idAdmin` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  MODIFY `idAlumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32040002;

--
-- AUTO_INCREMENT de la tabla `control_escolar`
--
ALTER TABLE `control_escolar`
  MODIFY `idControlEscolar` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `materias`
--
ALTER TABLE `materias`
  MODIFY `idMateria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `profesores`
--
ALTER TABLE `profesores`
  MODIFY `idProfesor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22040003;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10000008;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `administradores`
--
ALTER TABLE `administradores`
  ADD CONSTRAINT `administradores_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);

--
-- Filtros para la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD CONSTRAINT `alumnos_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);

--
-- Filtros para la tabla `control_escolar`
--
ALTER TABLE `control_escolar`
  ADD CONSTRAINT `control_escolar_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);

--
-- Filtros para la tabla `materias`
--
ALTER TABLE `materias`
  ADD CONSTRAINT `materias_ibfk_1` FOREIGN KEY (`id_profesor`) REFERENCES `profesores` (`idProfesor`);

--
-- Filtros para la tabla `profesores`
--
ALTER TABLE `profesores`
  ADD CONSTRAINT `profesores_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
