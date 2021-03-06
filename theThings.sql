-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema tupperviny
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema tupperviny
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `tupperviny` DEFAULT CHARACTER SET utf8 ;
USE `tupperviny` ;

-- -----------------------------------------------------
-- Table `tupperviny`.`balanco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tupperviny`.`balanco` (
  `idBalanco` INT(11) NOT NULL AUTO_INCREMENT,
  `blc_Gasto` DECIMAL(10,2) NULL DEFAULT NULL,
  `blc_Income` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`idBalanco`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `tupperviny`.`clients`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tupperviny`.`clients` (
  `idClients` INT(11) NOT NULL AUTO_INCREMENT,
  `Client_name` VARCHAR(255) NULL DEFAULT NULL,
  `deve` TINYINT(1) NULL DEFAULT NULL,
  `qntDeve` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`idClients`))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `tupperviny`.`products`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tupperviny`.`products` (
  `CodProd` VARCHAR(255) NOT NULL,
  `Prod_name` VARCHAR(255) NULL DEFAULT NULL,
  `Prod_Detail` VARCHAR(255) NULL DEFAULT NULL,
  `Prod_val` DECIMAL(10,2) NULL DEFAULT NULL,
  `Prod_qtd` INT(11) NULL DEFAULT NULL,
  `clients_idClients` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`CodProd`),
  INDEX `fk_products_clients_idx` (`clients_idClients` ASC),
  CONSTRAINT `fk_products_clients`
    FOREIGN KEY (`clients_idClients`)
    REFERENCES `tupperviny`.`clients` (`idClients`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
