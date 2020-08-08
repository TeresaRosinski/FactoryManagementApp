# _Factory Management App_

#### _8.7.20_

#### By _**Teresa Rosinski**_


# Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program

# Importing and Updating the Database

* MySql must be isntalled on your device
* to connect the database type in the command line: dotnet ef migrations add Initial 
* to update the database type in the command line: dotnet ef database update    


# SQL Schema Query #

```
DROP TABLE IF EXISTS `__EFMigrationsHistory`;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) 

Table structure for table `Engineers`

DROP TABLE IF EXISTS `Engineers`;
CREATE TABLE `Engineers` (
  `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Email` longtext,
  `Phone` longtext,
  `Department` longtext,
  `DateHired` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  PRIMARY KEY (`EngineerId`)
) 
Table structure for table `MachineEngineer`

DROP TABLE IF EXISTS `MachineEngineer`;
CREATE TABLE `MachineEngineer` (
  `MachineEngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerId` int(11) NOT NULL,
  `MachineId` int(11) NOT NULL,
  PRIMARY KEY (`MachineEngineerId`),
  KEY `IX_MachineEngineer_EngineerId` (`EngineerId`),
  KEY `IX_MachineEngineer_MachineId` (`MachineId`),
  CONSTRAINT `FK_MachineEngineer_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_MachineEngineer_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
) 

-- Table structure for table `Machines`

DROP TABLE IF EXISTS `Machines`;
CREATE TABLE `Machines` (
  `MachineId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Description` longtext,
  `DatePurchased` datetime(6) NOT NULL,
  PRIMARY KEY (`MachineId`)
) 

```


# Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program creates instance of the Machine class** | N/A | N/A |
| **Program creates instance of the Engineer class** | N/A | N/A |
| **Program only allows the user to delete specific instances of engineers** | "N/A" | "N/A"  |
| **Program only allows the user to delete specific instances of machines** | "N/A" | "N/A"  |
| **Program allows the user to connect an infinite number of machines with different engineers** | "N/A" | "N/A"  |
| **Program only allows user to connect an infinite number of engineers with different machines** | "N/A" | "N/A"  |

# Support and contact details

_For question, concerns, or if you would like to make contributions to this work, please contact Teresa Rosinski at trosinski89@gmail.com_

# Technologies Used

* VSCode
* C#
* MySqL
* Entity Framework
* .NET Core
* BootStrap

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Teresa Rosinski_**