-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 23-Abr-2016 às 00:43
-- Versão do servidor: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bdctrol_invent`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `administradores`
--

CREATE TABLE IF NOT EXISTS `administradores` (
  `id` int(11) NOT NULL,
  `Nome` varchar(125) CHARACTER SET utf8 NOT NULL,
  `imgPerfil` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `Email` varchar(125) CHARACTER SET utf8 NOT NULL,
  `Usuario` varchar(10) CHARACTER SET utf8 NOT NULL,
  `Senha` varchar(128) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `administradores`
--

INSERT INTO `administradores` (`id`, `Nome`, `imgPerfil`, `Email`, `Usuario`, `Senha`) VALUES
(4, 'Douglas GonÃ§alves', 'default.png', 'goncalves.douglas@outlook.com.br', 'Admin', '91ae10cfaf7ac3179836b19010b1dd78c0d6f378a5a35e9bff048e1992a0d6aae53cb5c719462316c2ff0b3759a1a65254b3584601905ad434ca814b835bb3e8');

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `id_categoria` int(11) NOT NULL,
  `nome_categoria` varchar(30) NOT NULL,
  `tipo_categoria` int(2) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `categoria`
--

INSERT INTO `categoria` (`id_categoria`, `nome_categoria`, `tipo_categoria`) VALUES
(11, 'PC', 2),
(12, ' Notebook', 2),
(13, ' Impressora', 2),
(14, 'Pessoa FÃ­sica', 1),
(15, ' Empresa', 1),
(16, ' Pessoa JurÃ­dica ', 1),
(23, 'Desktop', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente` int(50) NOT NULL,
  `nome_cliente` varchar(100) NOT NULL,
  `CNPJ/CPF` varchar(20) NOT NULL,
  `end_cliente` varchar(50) NOT NULL,
  `fone_cliente` varchar(50) NOT NULL,
  `email_cliente` varchar(50) NOT NULL,
  `categoria` int(50) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome_cliente`, `CNPJ/CPF`, `end_cliente`, `fone_cliente`, `email_cliente`, `categoria`, `status`) VALUES
(21, 'CIA das Maquinas LTDA', '00000000000', 'Caxias do Sul RS', '(54)9999-9999', 'ciadasmaquinas@gmail.com', 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `maquina`
--

CREATE TABLE IF NOT EXISTS `maquina` (
  `id_maquina` int(50) NOT NULL,
  `id_cliente` int(50) NOT NULL,
  `id_setor` int(50) NOT NULL,
  `nome_maquina` varchar(100) NOT NULL,
  `detalhes` longtext NOT NULL,
  `patrimonio` varchar(50) NOT NULL,
  `categoria` int(5) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `maquina`
--

INSERT INTO `maquina` (`id_maquina`, `id_cliente`, `id_setor`, `nome_maquina`, `detalhes`, `patrimonio`, `categoria`, `status`) VALUES
(4, 21, 10, 'PC-Contabilidade01', '<p>Desktop all-in-one Inspiron 20 S&eacute;rie 3000</p>\r\n\r\n<p>Monitor</p>\r\n\r\n<p>Tela LED HD+ de 19.5 polegadas (1600 x 900) com antirreflexo</p>\r\n\r\n<p>Processador Intel&reg; Celeron&reg; N3150 (1.6 GHz expans&iacute;vel at&eacute; 2.08 GHz, Cache de 2MB)</p>\r\n\r\n<p>Mem&oacute;ria RAM</p>\r\n\r\n<p>Mem&oacute;ria 4GB, Single Channel DDR3, 1600MHz (1 X 4GB)</p>\r\n\r\n<p>Disco R&iacute;gido (HD)</p>\r\n\r\n<p>Disco r&iacute;gido de 500GB (5400 RPM)</p>\r\n\r\n<p>Placa de v&iacute;deo</p>\r\n\r\n<p>Placa de v&iacute;deo integrada Intel&reg; HD Graphics</p>\r\n\r\n<p>Mouse e Teclado Dell</p>\r\n', '01010101', 23, 1),
(5, 21, 9, 'PC-RH03', '<p>Desktop all-in-one Inspiron 20 S&eacute;rie 3000</p>\r\n\r\n<p>Monitor</p>\r\n\r\n<p>Tela LED HD+ de 19.5 polegadas (1600 x 900) com antirreflexo</p>\r\n\r\n<p>Processador Intel&reg; Celeron&reg; N3150 (1.6 GHz expans&iacute;vel at&eacute; 2.08 GHz, Cache de 2MB)</p>\r\n\r\n<p>Mem&oacute;ria RAM</p>\r\n\r\n<p>Mem&oacute;ria 4GB, Single Channel DDR3, 1600MHz (1 X 4GB)</p>\r\n\r\n<p>Disco R&iacute;gido (HD)</p>\r\n\r\n<p>Disco r&iacute;gido de 500GB (5400 RPM)</p>\r\n\r\n<p>Placa de v&iacute;deo</p>\r\n\r\n<p>Placa de v&iacute;deo integrada Intel&reg; HD Graphics</p>\r\n\r\n<p>Mouse e Teclado Dell</p>\r\n', '1818181818', 23, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `rede`
--

CREATE TABLE IF NOT EXISTS `rede` (
  `id_rede` int(50) NOT NULL,
  `id_maquina` int(50) NOT NULL,
  `tcp_ip` int(50) NOT NULL,
  `mac` int(50) NOT NULL,
  `grupo` varchar(100) NOT NULL,
  `detalhes` longtext NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `rede`
--

INSERT INTO `rede` (`id_rede`, `id_maquina`, `tcp_ip`, `mac`, `grupo`, `detalhes`) VALUES
(4, 4, 2323123, 1232323, 'Contabilidade', 'Asseco em 18/04'),
(5, 5, 0, 0, 'RH', 'Esta Rede bsdbsdhhbsdbsdhbsdhbshdbhsbdhbsdbsdbhsbdhbsd');

-- --------------------------------------------------------

--
-- Estrutura da tabela `setor`
--

CREATE TABLE IF NOT EXISTS `setor` (
  `id_setor` int(50) NOT NULL,
  `id_cliente` int(50) NOT NULL,
  `nome_setor` varchar(100) NOT NULL,
  `localidade` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `setor`
--

INSERT INTO `setor` (`id_setor`, `id_cliente`, `nome_setor`, `localidade`) VALUES
(8, 21, 'Diretoria', 'Caxias do Sul'),
(9, 21, ' RH', 'Caxias do Sul'),
(10, 21, ' Contabilidade', 'Caxias do Sul'),
(11, 21, ' Vendas', 'Caxias do Sul'),
(12, 21, '', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `software`
--

CREATE TABLE IF NOT EXISTS `software` (
  `id_software` int(50) NOT NULL,
  `nome_software` varchar(100) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `descricao` longtext NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `software`
--

INSERT INTO `software` (`id_software`, `nome_software`, `tipo`, `descricao`) VALUES
(1, 'Windows 7', 'S.O', 'Sistema Operacional da Microsoft.'),
(2, 'Unbuto', 'S.O', 'Sistema Livre'),
(3, 'Office 07 ', 'APP', '<p>Pacote Office 2007 Microsoftware</p>\r\n'),
(4, 'Office 11', 'APP', '<p>Pacote Office 2011&nbsp;Microsoft</p>\r\n'),
(6, 'Office 10', 'APP', '<p>Pacote Office 2010&nbsp;Microsoftware</p>\r\n'),
(7, 'Avast Antivirus', 'SeguranÃ§a', '<p>Antivirus Avast 2016</p>\r\n');

-- --------------------------------------------------------

--
-- Estrutura da tabela `soft_maquina`
--

CREATE TABLE IF NOT EXISTS `soft_maquina` (
  `id_softmaquina` int(100) NOT NULL,
  `id_software` int(100) NOT NULL,
  `id_maquina` int(100) NOT NULL,
  `registro` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `soft_maquina`
--

INSERT INTO `soft_maquina` (`id_softmaquina`, `id_software`, `id_maquina`, `registro`) VALUES
(10, 2, 4, 'Free'),
(11, 3, 4, '0000-0000-0000-0000-0000'),
(12, 7, 4, '0000-0000-0000-0000-0000'),
(13, 2, 5, 'Free'),
(14, 3, 5, '0000-0000-0000-0000-0000'),
(15, 7, 5, '0000-0000-0000-0000-0000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `administradores`
--
ALTER TABLE `administradores`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`,`nome_categoria`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indexes for table `maquina`
--
ALTER TABLE `maquina`
  ADD PRIMARY KEY (`id_maquina`);

--
-- Indexes for table `rede`
--
ALTER TABLE `rede`
  ADD PRIMARY KEY (`id_rede`);

--
-- Indexes for table `setor`
--
ALTER TABLE `setor`
  ADD PRIMARY KEY (`id_setor`);

--
-- Indexes for table `software`
--
ALTER TABLE `software`
  ADD PRIMARY KEY (`id_software`);

--
-- Indexes for table `soft_maquina`
--
ALTER TABLE `soft_maquina`
  ADD PRIMARY KEY (`id_softmaquina`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `administradores`
--
ALTER TABLE `administradores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(50) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `maquina`
--
ALTER TABLE `maquina`
  MODIFY `id_maquina` int(50) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `rede`
--
ALTER TABLE `rede`
  MODIFY `id_rede` int(50) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `setor`
--
ALTER TABLE `setor`
  MODIFY `id_setor` int(50) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `software`
--
ALTER TABLE `software`
  MODIFY `id_software` int(50) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `soft_maquina`
--
ALTER TABLE `soft_maquina`
  MODIFY `id_softmaquina` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=16;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
