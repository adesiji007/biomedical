-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 04, 2016 at 01:53 PM
-- Server version: 5.5.20
-- PHP Version: 5.3.9

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_user`
--

-- --------------------------------------------------------

--
-- Table structure for table `activity_record`
--

CREATE TABLE IF NOT EXISTS `activity_record` (
  `ActivityRecird_ID` int(11) NOT NULL AUTO_INCREMENT,
  `TrainingCode` varchar(125) NOT NULL,
  `Firstname` varchar(225) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `DatOfActivity` varchar(50) NOT NULL,
  `TypeOfActivity` varchar(150) NOT NULL,
  `PreviousActivity` varchar(225) NOT NULL,
  `DateOfNextActivity` varchar(20) NOT NULL,
  PRIMARY KEY (`ActivityRecird_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `activity_record`
--

INSERT INTO `activity_record` (`ActivityRecird_ID`, `TrainingCode`, `Firstname`, `Lastname`, `DatOfActivity`, `TypeOfActivity`, `PreviousActivity`, `DateOfNextActivity`) VALUES
(1, '231', 'Makinwa Floody', '', '0000-00-00 00:00:00', 'Walking Tread', 'None', '12-11-2016'),
(2, '123', 'Laugh Loud', '', '0000-00-00 00:00:00', 'Walking Lobby', 'Back Trainning', '12-07-2016'),
(3, '4675', 'King Richard', '', '0000-00-00 00:00:00', 'Running', 'Jumping', '12/11/2016'),
(4, '4675', 'King Richard', '', '0000-00-00 00:00:00', 'Running', 'Jumping', '12/11/2016'),
(5, '4675', 'King Richard', '', '0000-00-00 00:00:00', 'Running', 'Jumping', '12/11/2016'),
(6, '3244', 'Lord Lugard', '', '0000-00-00 00:00:00', 'Front race exercise', 'Movement of hand', '19-07-2016'),
(7, '327', 'King Richard', '', '13 April 2016', 'Leg Adjustment', 'None', '16-09-2017'),
(8, '1', '231', '', 'Makinwa Floody', '12-01-2011', 'Walking Tread', 'None'),
(9, '324', 'McArthur Smithweed', '', '23-02-1987', 'Body Pain', 'Walking Tread', 'None'),
(10, '823', 'Makinwa Floody', '', '12-01-2011', 'Makinwa Floody', 'Walking Tread', ' 23-01-2011'),
(11, '4675', 'King ', 'Richard', '12 april 2014', 'Running', 'Jumping', '12/11/2016');

-- --------------------------------------------------------

--
-- Table structure for table `clientdetail`
--

CREATE TABLE IF NOT EXISTS `clientdetail` (
  `clientdetail_ID` int(125) NOT NULL AUTO_INCREMENT,
  `ClientType` varchar(50) NOT NULL,
  `Title` varchar(25) NOT NULL,
  `Firstname` varchar(225) NOT NULL,
  `Lastname` varchar(125) NOT NULL,
  `Address` varchar(125) NOT NULL,
  `DOB` varchar(125) NOT NULL,
  `Phone_Number` varchar(125) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Occupation` varchar(50) NOT NULL,
  `Reference_No` varchar(10) NOT NULL,
  PRIMARY KEY (`clientdetail_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `clientdetail`
--

INSERT INTO `clientdetail` (`clientdetail_ID`, `ClientType`, `Title`, `Firstname`, `Lastname`, `Address`, `DOB`, `Phone_Number`, `Gender`, `Occupation`, `Reference_No`) VALUES
(1, '', 'Mr', 'Solomon', 'Writhey', '20 sunderland university road', '12-12-1987', '07675645342', 'male', '', '0'),
(2, '', 'Mr', 'Solomon', 'Writhey', '20 sunderland university road', '12-12-1987', '07675645342', 'male', 'student', '231432'),
(3, 'Doctor', 'mr', 'olu', 'mark', '12 weee', '12-08-1988', '07476372273', 'Male', 'nurse', '78654');

-- --------------------------------------------------------

--
-- Table structure for table `client_registration`
--

CREATE TABLE IF NOT EXISTS `client_registration` (
  `clientdetails_ID` int(10) NOT NULL AUTO_INCREMENT,
  `ClientType` varchar(125) NOT NULL,
  `Firstname` varchar(125) NOT NULL,
  `Lastname` varchar(125) NOT NULL,
  `Registration_Date` varchar(125) NOT NULL,
  `Registartion_No` int(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  PRIMARY KEY (`clientdetails_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `diagnosis_informatin`
--

CREATE TABLE IF NOT EXISTS `diagnosis_informatin` (
  `DiagInfo_ID` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(10) NOT NULL,
  `Reference_No` varchar(20) NOT NULL,
  `Firstname` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Date` varchar(125) NOT NULL,
  `Last_Clinic_date` varchar(125) NOT NULL,
  `NatureOfTraining` varchar(125) NOT NULL,
  `PreviousAppointment` varchar(225) NOT NULL,
  `RescheduleOfAppointment` varchar(225) NOT NULL,
  PRIMARY KEY (`DiagInfo_ID`),
  KEY `user_id` (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Dumping data for table `diagnosis_informatin`
--

INSERT INTO `diagnosis_informatin` (`DiagInfo_ID`, `user_id`, `Reference_No`, `Firstname`, `Lastname`, `Date`, `Last_Clinic_date`, `NatureOfTraining`, `PreviousAppointment`, `RescheduleOfAppointment`) VALUES
(1, 12, '345', 'osmas', 'Wright', '23/05/2016', '12/012/2015', 'Back Injury', 'None', '14/08/2016'),
(2, 365, '243', 'welsmith', 'Maxxim', '12/08/15', '12/06/14', 'Dr, Jude', 'Back Injury Serious', '14/02/2016'),
(3, 456, '756', 'Smith ', 'Martin', '12-09-2016', '02-12-2015', 'Head Pain', 'Severe Headic', '10-10-2016'),
(4, 2, '746', 'John', 'Mahh', '12/01/15', '23/12/2014', 'Left Hand Injury', 'General Trainning with Swing', '10/07/2015'),
(5, 3, '182', 'Tunde', 'Solomon', '21-12-13', '01-12-12', 'Head and Shoulder problem', 'Attack', '02-11-16'),
(6, 0, '', 'Akins Smith', '', 'we', '12/08/15', '12/06/14', 'Dr, Jude', 'Back Injury Serious'),
(7, 0, '', 'adesiji', '', 'osmas', '23/05/2016', '12/012/2015', 'Back Injury', 'None'),
(8, 0, '', 'tunde', '', 'osmas', '23/05/2016', '12/012/2015', 'Back Injury', 'None'),
(9, 0, '', 'Liz Ghandy', '', 'we', '12/08/15', '12/06/14', 'Dr, Jude', 'Back Injury Serious'),
(17, 12, '987', 'richard', 'tommy', '09-12-2014', '11-12-13', 'back pain', '12/08/15', '12/06/14'),
(18, 0, 'System.Windows.Forms', '3', '0', '', 'Smith Martin', '', '12-09-2016', '02-12-2015'),
(19, 0, 'System.Windows.Forms', 'select Firstname from clientdetail', '', '', '', '', '', ''),
(20, 0, 'System.Windows.Forms', 'select Firstname from user', 'computer', '02/04/2016', '14/02/2016', 'back treatment', 'yes', 'QMC Hospital'),
(21, 0, 'System.Windows.Forms', 'select Firstname, Lastname from user', 'select Lastname from user', 'ddd', '', '', '', ''),
(22, 0, 'System.Windows.Forms', 'select Firstname, Lastname from user', '', '04 April 2016', '15 October 2015', 'Head and Neck exercise', 'None', 'Sunderland Hospital'),
(23, 0, 'System.Windows.Forms', 'select Firstname, Lastname from user', '', '04 April 2016', '15 October 2015', 'Head and Neck exercise', 'None', 'Sunderland Hospital');

-- --------------------------------------------------------

--
-- Table structure for table `dynamic_movement`
--

CREATE TABLE IF NOT EXISTS `dynamic_movement` (
  `DynaMove_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `ReferenceNo` int(125) NOT NULL,
  `AssessmentDate` varchar(125) NOT NULL,
  `DeepSquatHeelOnFloor` int(10) NOT NULL,
  `DeepSquatHipBelowKnees` int(10) NOT NULL,
  `DeepSquatDowelOverHead` int(10) NOT NULL,
  `DeepSquatPain` int(10) NOT NULL,
  `LungeHipKneesAnkleFwd` int(10) NOT NULL,
  `LungeKneeToFloor` int(10) NOT NULL,
  `LungeMinUppBodyMov` int(10) NOT NULL,
  `LungeMaintBalan90` int(10) NOT NULL,
  `ActiveSlTaiseFootFlexed` int(10) NOT NULL,
  `ActiveSlTaiseAnkleBone` int(10) NOT NULL,
  `ActiveSlTaisePain` int(10) NOT NULL,
  `StandingHipExtHigHams` int(10) NOT NULL,
  `StandingHipExtPain` int(10) NOT NULL,
  `SeatedTotPelv_Level` int(10) NOT NULL,
  `SeatedTotPelv_DowelInChest` int(10) NOT NULL,
  `SeatedTotPelv_Pain` int(10) NOT NULL,
  PRIMARY KEY (`DynaMove_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `dynamic_movement`
--

INSERT INTO `dynamic_movement` (`DynaMove_ID`, `Name`, `Lastname`, `ReferenceNo`, `AssessmentDate`, `DeepSquatHeelOnFloor`, `DeepSquatHipBelowKnees`, `DeepSquatDowelOverHead`, `DeepSquatPain`, `LungeHipKneesAnkleFwd`, `LungeKneeToFloor`, `LungeMinUppBodyMov`, `LungeMaintBalan90`, `ActiveSlTaiseFootFlexed`, `ActiveSlTaiseAnkleBone`, `ActiveSlTaisePain`, `StandingHipExtHigHams`, `StandingHipExtPain`, `SeatedTotPelv_Level`, `SeatedTotPelv_DowelInChest`, `SeatedTotPelv_Pain`) VALUES
(1, 'Craig Davids', '', 3645, '12-10-2016', 1, 1, 3, 1, 1, 2, 2, 4, 2, 2, 3, 2, 3, 1, 2, 3),
(2, 'Craig Davids', '', 3645, '12-10-2016', 1, 1, 3, 1, 1, 2, 2, 4, 2, 2, 3, 2, 3, 1, 2, 3),
(3, 'God is Good', '', 678, '10-09-2015', 3, 3, 1, 4, 1, 0, 2, 4, 1, 3, 4, 4, 2, 3, 1, 0),
(4, 'tunde', '', 455, '09-03-16', 4, 2, 3, 2, 3, 2, 3, 0, 2, 2, 3, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `forget_password`
--

CREATE TABLE IF NOT EXISTS `forget_password` (
  `Username` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `injury_history`
--

CREATE TABLE IF NOT EXISTS `injury_history` (
  `InjuryHis_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Training_Name` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Reference_Code` varchar(50) NOT NULL,
  `Date` varchar(10) NOT NULL,
  `Note` varchar(225) NOT NULL,
  `Additional_Note` varchar(250) NOT NULL,
  PRIMARY KEY (`InjuryHis_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `injury_history`
--

INSERT INTO `injury_history` (`InjuryHis_ID`, `Training_Name`, `Lastname`, `Reference_Code`, `Date`, `Note`, `Additional_Note`) VALUES
(1, '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `email`) VALUES
('root', 'root', 'sonnbeam@yahoo.com'),
('root', 'root', 'adesiji@yaoo.com');

-- --------------------------------------------------------

--
-- Table structure for table `messanger`
--

CREATE TABLE IF NOT EXISTS `messanger` (
  `Messanger_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Email` varchar(125) NOT NULL,
  `Composed_Messages` varchar(500) NOT NULL,
  PRIMARY KEY (`Messanger_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `newuser`
--

CREATE TABLE IF NOT EXISTS `newuser` (
  `Newcomer_ID` int(10) NOT NULL AUTO_INCREMENT,
  `ClientType` varchar(50) NOT NULL,
  `Firstname` varchar(50) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Registration_Date` varchar(20) NOT NULL,
  `Registration_Number` int(50) NOT NULL,
  `Email` varchar(70) NOT NULL,
  `Password` varchar(125) NOT NULL,
  PRIMARY KEY (`Newcomer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `reffered_form`
--

CREATE TABLE IF NOT EXISTS `reffered_form` (
  `RefferForm_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Training_Code` varchar(50) NOT NULL,
  `Training_Name` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Date_of_Reffered` varchar(125) NOT NULL,
  `Hospital_Location` varchar(125) NOT NULL,
  `NatureOfReffered` varchar(125) NOT NULL,
  `General_Note` varchar(500) NOT NULL,
  PRIMARY KEY (`RefferForm_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `reffered_form`
--

INSERT INTO `reffered_form` (`RefferForm_ID`, `Training_Code`, `Training_Name`, `Lastname`, `Date_of_Reffered`, `Hospital_Location`, `NatureOfReffered`, `General_Note`) VALUES
(1, '', '', '', '', '', '', ''),
(2, '', '', '', '', '', '', ''),
(3, '', '', '', '10 March 2016', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `self_mobility_screen`
--

CREATE TABLE IF NOT EXISTS `self_mobility_screen` (
  `sefM_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Reference_No` varchar(50) NOT NULL,
  `Assessment_Date` varchar(125) NOT NULL,
  `Deep_Squat_Alignment` varchar(10) NOT NULL,
  `Hurdle_Step_Alignment` varchar(10) NOT NULL,
  `Inline_Step_Alignment` varchar(10) NOT NULL,
  `Active_straight_Leg_Raise_Flexed` varchar(10) NOT NULL,
  `Seated_Rotation_45Degree` varchar(10) NOT NULL,
  PRIMARY KEY (`sefM_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `self_mobility_screen`
--

INSERT INTO `self_mobility_screen` (`sefM_ID`, `Name`, `Lastname`, `Reference_No`, `Assessment_Date`, `Deep_Squat_Alignment`, `Hurdle_Step_Alignment`, `Inline_Step_Alignment`, `Active_straight_Leg_Raise_Flexed`, `Seated_Rotation_45Degree`) VALUES
(2, 'Adesiji', 'Olutunde', '345', 'pass', 'pass', 'fail', 'fail', 'pass', 'pass'),
(3, '', '', '', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `staffdetails`
--

CREATE TABLE IF NOT EXISTS `staffdetails` (
  `StaffDet_ID` int(10) NOT NULL AUTO_INCREMENT,
  `WeeklyAttendance` varchar(50) NOT NULL,
  PRIMARY KEY (`StaffDet_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `static_postural_assessment`
--

CREATE TABLE IF NOT EXISTS `static_postural_assessment` (
  `SelfPost_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Reference_No` int(50) NOT NULL,
  `Assessment_Date` varchar(125) NOT NULL,
  `Front_Feet` varchar(10) NOT NULL,
  `Front_Hips` varchar(10) NOT NULL,
  `Front_Shoulders` varchar(10) NOT NULL,
  `Side_Knees` varchar(50) NOT NULL,
  `Side_Hips` varchar(50) NOT NULL,
  `Side_Shoulders` varchar(50) NOT NULL,
  PRIMARY KEY (`SelfPost_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `static_postural_assessment`
--

INSERT INTO `static_postural_assessment` (`SelfPost_ID`, `Name`, `Lastname`, `Reference_No`, `Assessment_Date`, `Front_Feet`, `Front_Hips`, `Front_Shoulders`, `Side_Knees`, `Side_Hips`, `Side_Shoulders`) VALUES
(1, 'liz', 'ghandy', 9998, '01-03-2015', 'Int Rotati', 'Left - Low', 'Right - Lo', 'Pick one or Select all:', 'Anterior', 'Posture');

-- --------------------------------------------------------

--
-- Table structure for table `training_history`
--

CREATE TABLE IF NOT EXISTS `training_history` (
  `TrainHist_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(50) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `Training_Reference_Code` varchar(10) NOT NULL,
  `TN_Sport` varchar(50) NOT NULL,
  `TN_Note` varchar(125) NOT NULL,
  `TN_Stenght` varchar(125) NOT NULL,
  `TN_Weakness` varchar(125) NOT NULL,
  `PHP_Note` varchar(125) NOT NULL,
  `PHP_Strenght` varchar(125) NOT NULL,
  `PHP_Weakness` varchar(125) NOT NULL,
  PRIMARY KEY (`TrainHist_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `training_history`
--

INSERT INTO `training_history` (`TrainHist_ID`, `Firstname`, `Lastname`, `Training_Reference_Code`, `TN_Sport`, `TN_Note`, `TN_Stenght`, `TN_Weakness`, `PHP_Note`, `PHP_Strenght`, `PHP_Weakness`) VALUES
(1, '', '', '51', 'Richard Gree', '5% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(2, '', '', '76', 'Almond Salmon', '5% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(3, '', '', '76', 'Badman Silvermenship', '60% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(4, '', '', '76', 'David Aruns', '43% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(5, 'adesiji', 'solomon', '51', 'Richard Gree', '5% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(6, 'Richard', ' Gree', '51', 'wendy', '5% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(7, ' Gree', ' master P', '657', 'long walk on track', '5% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(8, '', '', '76', 'Badman Silvermenship', '60% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild'),
(9, 'David', 'Aruuns', '76', 'David Aruns', '43% improvement', 'more improvement need', 'None', 'He meed to do more exercise to reduce the back pain', '35% improvement', 'mild');

-- --------------------------------------------------------

--
-- Table structure for table `training_week`
--

CREATE TABLE IF NOT EXISTS `training_week` (
  `TrainWeek_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Training_Reference_Code` int(125) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Name` varchar(125) NOT NULL,
  `Lastname` varchar(50) NOT NULL,
  `DateOfTheWeek` varchar(30) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Session` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  PRIMARY KEY (`TrainWeek_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `training_week`
--

INSERT INTO `training_week` (`TrainWeek_ID`, `Training_Reference_Code`, `Date`, `Name`, `Lastname`, `DateOfTheWeek`, `Time`, `Session`, `Duration`) VALUES
(1, 22, 'ddd', 'ddd', '', '09 March 2016', 'AM', 'Completed', '30 minutes'),
(2, 22, '19-09-1978', 'Alan Smith', '', '29 February 2016', 'PM', 'Not Attended', '60 minutes'),
(3, 45, '23-12-1976', 'liz Ghandy', '', '04 March 2016', 'AM', 'Not Completed', '45 minutes'),
(4, 45, 'l12-09-2016', 'atommy', '', '07 April 2016', 'PM', 'Not Attended', '45 minutes'),
(5, 22, 'Alan Smith', '19-09-1978', '', '10 March 2016', 'AM', 'Attended', '120 minutes');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `user_ID` int(10) NOT NULL AUTO_INCREMENT,
  `ClientType` varchar(50) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Firstname` varchar(50) NOT NULL,
  `Lastname` varchar(20) NOT NULL,
  `Address` varchar(225) NOT NULL,
  `DOB` varchar(50) NOT NULL,
  `Phone_Number` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Occupation` varchar(50) NOT NULL,
  `Reference_No` varchar(50) NOT NULL,
  PRIMARY KEY (`user_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=37 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_ID`, `ClientType`, `Title`, `Firstname`, `Lastname`, `Address`, `DOB`, `Phone_Number`, `Gender`, `Occupation`, `Reference_No`) VALUES
(1, '', 'mr', 'Yabby', 'Gee', '12 London road', '12-12-2011', '07576172276', 'Female', 'Nurse', '7645'),
(2, '', 'Mr', 'solomon', 'Samm', '20 sunderland university road', '12-12-1987', '07867564534', 'male', 'student', '182343'),
(3, '', 'Miss', 'Carren', 'Maxxim', '234 London Road', '98-02-1928', '087820987878', 'female', 'Nurse', '849567'),
(4, '', 'Mr', 'olutunde', 'Maxxim', '234 London Road', '30-12-1987', '07867564534', 'male', 'Lecturar', '98673'),
(5, '', 'Mr', 'Solomon', 'Maxxim', '20 sunderland university road', '98-02-1928', '07867564534', 'male', 'Capenter', '89767'),
(6, '', 'Miss', 'newcastle', '32', '20 Lowroy Close, Sunderland', '98-02-1928', '08675672283', 'female', 'House wife', '986376'),
(7, '', 'Miss', 'jesus', 'lawsredsky', '109 Westminster London', '17-02-1970', '07586757729', 'female', 'Teacher', '23716'),
(8, '', 'Miss', 'Mary', 'Lawson', '20 Lowroy Close, Sunderland', '17-10-1978', '08675672283', 'Female', 'Doctor', '2453'),
(9, '', 'Mrs', 'Reaceal', 'Macdonnald', '123 London Street Newcastle', '10-21-1987', '07574679982', 'Female', 'Student', '67563'),
(10, '', 'Miss', 'Mary', 'Lawson', '20 Lowroy Close, Sunderland', '17-10-1978', '08675672283', 'Female', 'Doctor', '2453'),
(11, '', 'Mrs', 'Reaceal', 'Macdonnald', '123 London Street Newcastle', '10-21-1987', '07574679982', 'Female', 'Student', '67563'),
(12, '', 'mr', 'sol', 'man', '123 House', '07/07/2016', '0765635421', 'Male', 'student', '53645'),
(13, '', 'Miss', 'Sheman', 'Blabla', '15 Lowry Close, London', '17/09/78', '07576476638', 'Female', 'Doctor', '13423'),
(14, '', 'mr', 'tunde', 'Lord', '13 london', '37/09/2015', '2317654565', 'male', 'manager', '564'),
(15, '', 'Mrs', 'Efong', 'Nigermax', '100 Sunderland', '21-11-1980', '07856573381', 'Female', 'Engineer', '6354'),
(16, '', 'master', 'solo', 'green', '23 sandgate close', '12-01-2016', '07576453423', 'male', 'Teacher', '243'),
(17, '', 'Ms', 'liz', 'Ghandy', '20 sunderland university road', '12-12-1987', '07867564534', 'female', 'student', '182343'),
(18, '', 'Miss', 'Yabmansd', 'Vonnash', '20 sunderland university road', '12-12-1987', '07867564534', 'male', 'student', '182343'),
(19, '', 'Mrs', 'Reaceal', 'Macdonnald', '123 London Street Newcastle', '10-21-1987', '07574679982', 'Female', 'Student', '67563'),
(20, '', 'Mr', 'solom', 'Samm', '20 sunderland university road', '12-12-1987', '07867564534', 'male', 'student', '182343'),
(21, '', 'Miss', 'Thomson', 'Landscape', '19 Landkfill Close', '10-20-1978', '07867576271', 'Male', 'Senior Manager', '9836'),
(22, 'Physiotheraphy', '', 'Miss', 'Carren', 'Maxxim', '234 London Road', '98-02-1928', '087820987878', 'female', 'Nurse'),
(23, 'Physiotheraphy', '', '', 'Miss', 'Carren', 'Maxxim', '234 London Road', '98-02-1928', '087820987878', 'female'),
(24, 'Doctor', 'Mr', 'Queen', 'Railar', '123 Kingdom square Lodon', '19-09-1978', '07678671167', 'Male', 'student', '6753'),
(25, 'Manager', 'miss', 'love', 'jesus', '12 dan way', '12-01-1999', '0798675643', 'Female', 'teacher', '657'),
(26, 'Career', 'mr', 'Yabby', 'Gee', '12 London road', '12-12-2011', '07576172276', 'Female', 'Nurse', '7645'),
(27, 'Career', 'mr', 'Yabby', 'Gee', '12 London road', '12-12-2011', '07576172276', 'Female', 'Nurse', '7645'),
(28, 'Career', 'Mr', 'olutunde', 'Maxxim', '234 London Road', '30-12-1987', '07867564534', 'male', 'Lecturar', '98673'),
(29, 'Manager', 'mr', 'john', 'frances', '23 sandgate close sunderland', '12-01-2012', '07576476654', 'Female', 'student', '4565'),
(30, 'Career', 'mr', 'john', 'frances', '23 sandgate close sunderland', '12-01-2012', '07576476654', 'Female', 'student', '4565'),
(31, 'Doctor', 'mr', 'Beb', 'mark', '564 sand street', '23-12-2016', '07576375564', 'Male', 'student', '564'),
(32, 'Physiotherapy & Personal Training', 'hhh', 'hhhh', 'hhh', '344566677', '09-05-12', '0786654343', 'Male', 'stufedse', '8766'),
(33, '', 'Mr', 'solomon', 'Samm', '20 sunderland university road', '12-12-1987', '07867564534', 'male', 'student', '182343'),
(34, 'Manager', 'Mr ', 'Solomon', 'Goerge', '17 Sandwell Road\r\nSunderland', '12-02-2016', '07673572286', 'Male', 'student', '987'),
(35, 'Doctor', 'Mrs', 'Denis', 'Markness', '35 Dammy Avenue\r\nNewcastle', '12-04-2013', '076735723645', 'Female', 'carpenter', '7563'),
(36, 'Nurse', 'Mrs', 'Dan', 'Maxxim', '234 London Road', '98-02-1928', '087820987878', 'male', 'Engineer', '849567');

-- --------------------------------------------------------

--
-- Table structure for table `user_info`
--

CREATE TABLE IF NOT EXISTS `user_info` (
  `user_info_id` int(10) NOT NULL AUTO_INCREMENT,
  `user_id` int(10) NOT NULL,
  `ActivityRecird_ID` int(10) NOT NULL,
  `clientdetail_ID` int(10) NOT NULL,
  `clientdetails_ID` int(10) NOT NULL,
  `DiagInfo_ID` int(10) NOT NULL,
  `DynaMove_ID` int(10) NOT NULL,
  `InjuryHis_ID` int(10) NOT NULL,
  `Messenger_ID` int(10) NOT NULL,
  `Newcomer_ID` int(10) NOT NULL,
  `RefferForm_ID` int(10) NOT NULL,
  `sefM_ID` int(10) NOT NULL,
  `StaffDet_ID` int(10) NOT NULL,
  `SelfPost_ID` int(10) NOT NULL,
  `TrainHist_ID` int(10) NOT NULL,
  `TrainWeek_ID` int(10) NOT NULL,
  `user_Firstname` varchar(50) NOT NULL,
  `user_Lastname` varchar(50) NOT NULL,
  PRIMARY KEY (`user_info_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `user_info`
--

INSERT INTO `user_info` (`user_info_id`, `user_id`, `ActivityRecird_ID`, `clientdetail_ID`, `clientdetails_ID`, `DiagInfo_ID`, `DynaMove_ID`, `InjuryHis_ID`, `Messenger_ID`, `Newcomer_ID`, `RefferForm_ID`, `sefM_ID`, `StaffDet_ID`, `SelfPost_ID`, `TrainHist_ID`, `TrainWeek_ID`, `user_Firstname`, `user_Lastname`) VALUES
(1, 23, 423, 42, 65, 24, 82, 76, 12, 5, 6, 6, 52, 21, 12, 12, '0', '0'),
(2, 22, 22, 42, 65, 24, 82, 76, 12, 5, 6, 2, 52, 21, 12, 12, 'Adesiji', 'King'),
(3, 23, 42, 52, 45, 34, 12, 36, 32, 15, 46, 52, 92, 11, 42, 32, 'Richard', 'Riches'),
(4, 23, 42, 52, 45, 34, 12, 36, 32, 15, 46, 52, 92, 11, 42, 32, 'Richard', 'Riches');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
