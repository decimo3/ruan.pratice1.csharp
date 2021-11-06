-- ------------------------------------------------------------------------- --
-- Author: Ruan Faustino Camello Da Silva                                    --
-- Data: sex 05 nov 2021 21:27:23 -03 UTM                                    --
-- URL: https://github.com/decimo3/ruan.console.csharp                       --
-- Description: Scrips para geração das tabelas necessárias para aplicação.  --
-- Note: As tabelas ainda sofrerão processo de optmização e especialização.  --  
-- ------------------------------------------------------------------------- --


-- Tabela para guardar todas as informações globais da conta do usuário.
CREATE TABLE `usuario` (
  `idUsuario` SERIAL PRIMARY KEY,
  `apelido` VARCHAR(16) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `segredo` VARCHAR(32) NOT NULL,
  `criado_em` TIMESTAMP NOT NULL,
  `genero` ENUM('M', 'F') NOT NULL
);

-- Tabela para guardar todas as informações dos personagens do usuário. 
CREATE TABLE `personagem` (
  `idPersonagem` SERIAL PRIMARY KEY,
  `apelido` VARCHAR(16) NOT NULL, -- Adicionar a constraint CHECK.
  `localizacao` DECIMAL(5,3) NOT NULL DEFAULT '1.250' -- Localização no mapa
  `idInventario` INT NOT NULL REFERENCES inventario(`idIUnventario`),
  `idTarefas` INT NOT NULL REFERENCES tarefas(`idTarefas`),
  `idAlinhamento` INT NOT NULL REFERENCES alinhamento(`idAlinhamento`),
  `idUsuario` INT NOT NULL REFERENCES usuario(`idUsuario`),
  `idExperiencia` INT NOT NULL REFERENCES experiencias(`idExperiencias`),
);

CREATE TABLE `inventario` (
  `idInventario` SERIAL PRIMARY KEY,
  `idObjeto` INT NOT NULL REFERENCES objetos(`idObjetos`),
  `qntItem` INT DEFAULT '0'
);

-- Tabela para guardar informações dos itens utilizáveis do jogo.
-- Futuramente essa tabela sofrerá processo de *especialização*.
CREATE TABLE `objetos` (
  `idObjeto` SERIAL PRIMARY KEY,
  `tipoItem` ENUM('arma', 'escudo'),
  `atributos` VARCHAR(8) NOT NULL, -- Será um cod alfanumérico de 8 dígitos para descrever atributos afetados e valores
  `descricao` TEXT NOT NULL,
  `qntLimite` TYNYINT(2)
);