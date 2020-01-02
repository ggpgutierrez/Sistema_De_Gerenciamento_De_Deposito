-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 02-Jan-2020 às 17:23
-- Versão do servidor: 5.7.26
-- versão do PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `deposito_bd`
--

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `CadastroCategoria`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CadastroCategoria` (IN `NomeCategoria` TEXT)  BEGIN
INSERT INTO `tb_categoria`(`NomeCategoria`) VALUES (`NomeCategoria`);	
END$$

DROP PROCEDURE IF EXISTS `CadastroProduto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CadastroProduto` (IN `NomeProduto` TEXT, IN `ValorUnit` DOUBLE, IN `TipoProdutoFK` INT, `UnidadeMedida` TEXT, `DescricaoProduto` TEXT, `Quantidade` DOUBLE)  BEGIN
	INSERT INTO `tb_produto`(`NomeProduto`, `ValorUnit`, `TipoProdutoFK`, `UnidadeMedida`, `DescricaoProduto`, `Quantidade`) VALUES (`NomeProduto`,`ValorUnit`,`TipoProdutoFK`,`UnidadeMedida`,`DescricaoProduto`,`Quantidade`);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_categoria`
--

DROP TABLE IF EXISTS `tb_categoria`;
CREATE TABLE IF NOT EXISTS `tb_categoria` (
  `idCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `NomeCategoria` varchar(100) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_categoria`
--

INSERT INTO `tb_categoria` (`idCategoria`, `NomeCategoria`) VALUES
(2, 'Tintas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_itenspedido`
--

DROP TABLE IF EXISTS `tb_itenspedido`;
CREATE TABLE IF NOT EXISTS `tb_itenspedido` (
  `idItemPedido` int(11) NOT NULL AUTO_INCREMENT,
  `Id_PedidoFK` int(11) NOT NULL,
  `Id_ProdutoFK` int(11) NOT NULL,
  `Quantidade` double NOT NULL,
  PRIMARY KEY (`idItemPedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pedido`
--

DROP TABLE IF EXISTS `tb_pedido`;
CREATE TABLE IF NOT EXISTS `tb_pedido` (
  `id_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `Data_Pedido` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` varchar(20) NOT NULL DEFAULT 'Faturado',
  `Total` double NOT NULL,
  PRIMARY KEY (`id_pedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produto`
--

DROP TABLE IF EXISTS `tb_produto`;
CREATE TABLE IF NOT EXISTS `tb_produto` (
  `id_Produto` int(11) NOT NULL AUTO_INCREMENT,
  `NomeProduto` varchar(100) NOT NULL,
  `ValorUnit` double NOT NULL,
  `TipoProdutoFK` int(11) NOT NULL,
  `UnidadeMedida` varchar(30) NOT NULL,
  `DescricaoProduto` text NOT NULL,
  `Quantidade` double NOT NULL,
  PRIMARY KEY (`id_Produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_user`
--

DROP TABLE IF EXISTS `tb_user`;
CREATE TABLE IF NOT EXISTS `tb_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_user`
--

INSERT INTO `tb_user` (`id`, `Username`, `Password`) VALUES
(1, 'adm', 'adm');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
