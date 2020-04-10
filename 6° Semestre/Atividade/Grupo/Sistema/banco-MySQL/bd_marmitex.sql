-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 11-Set-2016 às 20:21
-- Versão do servidor: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bd_marmitex`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` int(50) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `end_cliente` varchar(100) NOT NULL,
  `ponto_ref` varchar(100) NOT NULL,
  `dt_nasc` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `empres_terc`
--

CREATE TABLE IF NOT EXISTS `empres_terc` (
  `id_empres` int(100) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cnpj` int(20) NOT NULL,
  `end_empres` varchar(100) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `e-mail` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `entrega`
--

CREATE TABLE IF NOT EXISTS `entrega` (
  `id_entrega` int(100) NOT NULL,
  `id_pedido` int(100) NOT NULL,
  `id_entregador` int(100) NOT NULL,
  `data` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `entregadores`
--

CREATE TABLE IF NOT EXISTS `entregadores` (
  `id_entregador` int(100) NOT NULL,
  `id_empresa` int(100) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `celular` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_pedidos`
--

CREATE TABLE IF NOT EXISTS `itens_pedidos` (
  `id_item` int(100) NOT NULL,
  `id_pedido` int(100) NOT NULL,
  `id_produto` int(100) NOT NULL,
  `quant` int(10) NOT NULL,
  `valor` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

CREATE TABLE IF NOT EXISTS `pedido` (
  `id_pedido` int(100) NOT NULL,
  `nome_cliente` varchar(50) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `data` varchar(100) NOT NULL,
  `itens_pedido` int(100) NOT NULL,
  `valor_total` varchar(10) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `id_produto` int(100) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `descricao` longtext NOT NULL,
  `tamanho` varchar(10) NOT NULL,
  `valor` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indexes for table `empres_terc`
--
ALTER TABLE `empres_terc`
  ADD PRIMARY KEY (`id_empres`);

--
-- Indexes for table `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`id_entrega`);

--
-- Indexes for table `entregadores`
--
ALTER TABLE `entregadores`
  ADD PRIMARY KEY (`id_entregador`);

--
-- Indexes for table `itens_pedidos`
--
ALTER TABLE `itens_pedidos`
  ADD PRIMARY KEY (`id_item`);

--
-- Indexes for table `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_cliente` int(50) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `empres_terc`
--
ALTER TABLE `empres_terc`
  MODIFY `id_empres` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `entrega`
--
ALTER TABLE `entrega`
  MODIFY `id_entrega` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `entregadores`
--
ALTER TABLE `entregadores`
  MODIFY `id_entregador` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `itens_pedidos`
--
ALTER TABLE `itens_pedidos`
  MODIFY `id_item` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(100) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
