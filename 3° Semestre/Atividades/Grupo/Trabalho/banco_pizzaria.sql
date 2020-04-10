-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 08-Maio-2015 às 22:04
-- Versão do servidor: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `banco_pizzaria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `cod_cliente` int(4) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `data_nascimento` varchar(15) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `referencia` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`cod_cliente`, `nome`, `data_nascimento`, `telefone`, `endereco`, `referencia`) VALUES
(2, 'Daniela Costa', '16/07/1988', '(51)9951-0724', 'Gaspar Martins', 'Ap01'),
(4, 'João', '0000-00-00 00:0', '5122224444', 'Garibaldi', 'test'),
(5, 'Doug', '0000-00-00 00:0', '11112222', 'garibaldi', 'ap01'),
(6, 'Jose', '12/06/1988', '(51)9951-0724', 'Gaspar Martins', 'Ap01'),
(8, 'João', '12/05/1989', '(54)2222-2222', 'Caxias', 'casa 2015'),
(9, 'Maria', '14/12/1985', '(54)3333-3333', 'Caxias', 'casa 154'),
(10, 'Maria', '14/12/1985', '(54)3333-4444', 'Caxias', 'casa 154'),
(11, 'Douglas', '12/05/1989', '(51)9648-4747', 'Garibaldi', 'Ap01'),
(12, 'Maria', '14/12/1985', '(54)1212-1212', 'Garibaldi', 'casa 154'),
(13, 'Jose', '12/06/1988', '(51)9951-0895', 'Gaspar Martins', 'Ap01'),
(14, 'Eduardo', '26/05/1989', '(51)9685-7412', 'Garibaldi', 'Ap206');

-- --------------------------------------------------------

--
-- Estrutura da tabela `entregadores`
--

CREATE TABLE IF NOT EXISTS `entregadores` (
  `cod_entregador` int(4) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `cpf` int(10) NOT NULL,
  `rg` int(10) NOT NULL,
  `celular` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

CREATE TABLE IF NOT EXISTS `pedido` (
  `cod_pedido` int(4) NOT NULL,
  `cod_cliente` int(4) NOT NULL,
  `cod_produto` int(4) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `tamanho` int(10) NOT NULL,
  `nome_cliente` varchar(50) NOT NULL,
  `nome_entregador` varchar(50) NOT NULL,
  `quantidade` int(10) NOT NULL,
  `total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `cod_pizza` int(4) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `tamanho` varchar(50) NOT NULL,
  `valor` int(10) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`cod_pizza`, `nome`, `descricao`, `tamanho`, `valor`) VALUES
(5, 'Pizza Filé', 'jasjansjansjnasj;\r\nkmaskmaskmak;\r\nkaskmaksma;\r\nkmaskamsk;', 'Medio', 35),
(7, 'pizza 10', 'kasjansjansja;\r\nkmskamsk;\r\n\r\nkamskmask;', 'Medio', 35),
(8, 'Pizza Catupiry', 'Molho de Tomate;\r\nQueijo Musarela;\r\nCatupiry;\r\nOregano;', 'Medio', 35),
(9, 'Pizza Filé', 'jasjansjansjnasj;\r\nkmaskmaskmak;\r\nkaskmaksma;\r\nkmaskamsk;', 'Medio', 35),
(11, 'Pizza 4 Queijos', 'Molho de Tomate;\r\n4 tipos de queijos;\r\norégano;\r\n', 'Medio', 35),
(12, 'Pizza 30', 'jsnjasjasnjasnjansjas;\r\nnsanajsnjansja;\r\njansjnasjsajnasj;\r\nkasasn', 'Tamanho', 45),
(14, 'Pizza de Calabresa', 'jasnjasnjas;\r\nkamskmasasmas;\r\nkasmka;\r\nlas,las,las,las', 'Familia', 35),
(15, 'Pizza Filé', 'jasjansjansjnasj;\r\nkmaskmaskmak;\r\nkaskmaksma;\r\nkmaskamsk;', 'Medio', 35),
(16, 'Pizza de Milho', 'Molho de Tomate;\r\nMussarela;\r\nMilho;\r\nCatupiry;\r\nOregano;', 'Familia', 55),
(17, 'Pizza 4 Queijos', 'jasjnasjnajsnjasnjas;\r\naksansjnasjnasjnas;\r\nkamskmaskmaskas;', 'Grande', 35),
(18, 'Pizza de Mussarela', 'Molho de Tomate;\r\nQueijo Musarela;\r\nOregano;', 'Grande', 45),
(19, 'pizza 10', 'kasjansjansja;\r\nkmskamsk;\r\n\r\nkamskmask;', 'Medio', 35),
(20, 'calabresa', 'calabresa', 'Medio', 45);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`cod_cliente`);

--
-- Indexes for table `entregadores`
--
ALTER TABLE `entregadores`
  ADD PRIMARY KEY (`cod_entregador`);

--
-- Indexes for table `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`cod_pedido`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`cod_pizza`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `cod_cliente` int(4) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `entregadores`
--
ALTER TABLE `entregadores`
  MODIFY `cod_entregador` int(4) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pedido`
--
ALTER TABLE `pedido`
  MODIFY `cod_pedido` int(4) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `cod_pizza` int(4) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=21;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
