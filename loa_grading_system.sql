-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2025 at 03:49 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loa_grading_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` varchar(50) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
('01-2025', 'kia', 'admin123');

-- --------------------------------------------------------

--
-- Table structure for table `audit_trail`
--

CREATE TABLE `audit_trail` (
  `username` varchar(255) NOT NULL,
  `date_time` datetime NOT NULL,
  `action` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `audit_trail`
--

INSERT INTO `audit_trail` (`username`, `date_time`, `action`) VALUES
('kia', '2025-04-28 07:46:18', 'LOGIN'),
('', '2025-04-28 07:46:24', 'LOGOUT'),
('kia', '2025-04-28 07:51:51', 'LOGIN'),
('kia', '2025-04-28 07:52:36', 'LOGIN'),
('', '2025-04-28 07:52:40', 'LOGOUT'),
('kia', '2025-04-28 07:53:41', 'LOGIN'),
('', '2025-04-28 07:53:50', 'LOGOUT'),
('kia', '2025-04-28 09:38:53', 'LOGIN'),
('', '2025-04-28 09:38:57', 'LOGOUT'),
('kia', '2025-04-28 09:40:43', 'LOGIN'),
('kia', '2025-04-28 09:40:47', 'LOGOUT'),
('kia', '2025-04-28 19:43:00', 'LOGIN'),
('kia', '2025-04-28 19:43:27', 'LOGOUT'),
('kia', '2025-04-28 19:48:19', 'LOGIN'),
('kia', '2025-04-28 19:48:40', 'LOGIN'),
('kia', '2025-04-28 19:48:52', 'LOGOUT'),
('kia', '2025-04-28 19:51:35', 'LOGIN'),
('kia', '2025-04-28 19:51:44', 'LOGOUT'),
('kia', '2025-04-28 19:53:24', 'LOGIN'),
('kia', '2025-04-28 19:53:55', 'LOGOUT'),
('kia', '2025-04-28 19:54:25', 'LOGIN'),
('kia', '2025-04-28 19:54:52', 'LOGOUT'),
('kia', '2025-04-28 19:55:09', 'LOGIN'),
('kia', '2025-04-28 19:55:15', 'LOGOUT'),
('kia', '2025-04-28 19:56:37', 'LOGIN'),
('kia', '2025-04-28 19:56:52', 'LOGOUT'),
('kia', '2025-04-28 20:10:08', 'LOGIN'),
('kia', '2025-04-28 20:10:18', 'LOGOUT'),
('kia', '2025-04-28 20:20:48', 'LOGIN'),
('kia', '2025-04-28 20:21:01', 'LOGOUT'),
('kia', '2025-04-28 20:34:58', 'LOGIN'),
('kia', '2025-04-28 20:35:04', 'LOGOUT'),
('kia', '2025-04-28 20:51:32', 'LOGIN'),
('kia', '2025-04-28 20:51:40', 'LOGOUT'),
('kia', '2025-04-28 20:52:12', 'LOGIN'),
('kia', '2025-04-28 20:52:21', 'LOGOUT'),
('kia', '2025-04-28 20:53:34', 'LOGIN'),
('kia', '2025-04-28 20:53:46', 'LOGOUT'),
('kia', '2025-04-28 21:12:08', 'LOGIN'),
('kia', '2025-04-28 21:13:08', 'LOGOUT'),
('kia', '2025-04-28 21:17:24', 'LOGIN'),
('kia', '2025-04-28 21:17:44', 'LOGOUT'),
('kia', '2025-04-28 21:21:56', 'LOGIN'),
('kia', '2025-04-28 21:24:38', 'LOGOUT'),
('kia', '2025-05-09 22:44:09', 'CREATED NEW'),
('kia', '2025-05-09 22:44:48', 'Edited last_name of Student ID 1245-25\''),
('kia', '2025-05-09 22:46:12', 'CREATED NEW'),
('01-2025', '2025-05-13 20:14:14', 'Edited course_code of Student ID 1244-25\''),
('01-2025', '2025-05-13 20:14:15', 'Edited course_code of Student ID 1245-25\''),
('01-2025', '2025-05-14 21:01:34', 'UPDATED SUBJECT'),
('01-2025', '2025-05-25 19:58:24', 'CREATED NEW'),
('01-2025', '2025-05-25 19:59:38', 'CREATED NEW'),
('REG-2025-001', '2025-05-25 22:01:23', 'CREATED NEW'),
('REG-2025-001', '2025-05-26 19:31:08', 'Edited year_level of Student ID 1022-27\''),
('REG-2025-001', '2025-05-26 19:54:05', 'CREATED NEW'),
('REG-2025-001', '2025-05-26 21:47:39', 'CREATED NEW'),
('REG-2025-001', '2025-05-27 11:06:13', 'CREATED NEW'),
('REG-2025-001', '2025-05-27 20:01:07', 'CREATED NEW'),
('01-2025', '2025-05-27 22:33:37', 'CREATED NEW'),
('01-2025', '2025-05-27 22:52:23', 'CREATED NEW'),
('01-2025', '2025-06-09 22:36:18', 'CREATED NEW'),
('01-2025', '2025-06-09 22:41:00', 'CREATED NEW SUBJECT'),
('01-2025', '2025-06-09 22:58:30', 'CREATED NEW'),
('REG-2025-001', '2025-06-10 19:11:28', 'CREATED NEW'),
('01-2025', '2025-06-11 21:30:49', 'CREATED NEW');

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_id` varchar(255) NOT NULL,
  `course_code` varchar(255) NOT NULL,
  `course_name` varchar(255) NOT NULL,
  `major` varchar(50) NOT NULL,
  `department_id` varchar(255) NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_id`, `course_code`, `course_name`, `major`, `department_id`, `status`) VALUES
('course01', 'BSREM', 'Bachelor of Science in Real Estate Management', '', 'REM', 'Active'),
('course02', 'BSCS', 'Bachelor of Science in Computer Science', '', 'CCS', 'Active'),
('course03', 'BSIT', 'Bachelor of Science in Information Technology', '', 'CCS', 'Active'),
('course04', 'BSC', 'Bachelor of Science in Criminology', '', 'CCJ', 'Active'),
('course05', 'BPEA', 'Bachelor of Performing Arts', '', 'EDUC', 'Active'),
('course06', 'BSPsych', 'Bachelor of Science in Psychology', '', 'RRR', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `department_id` varchar(225) NOT NULL,
  `department_name` varchar(225) NOT NULL,
  `dean_id` varchar(50) DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`department_id`, `department_name`, `dean_id`, `status`) VALUES
('CAS', 'College of Arts and Sciences', NULL, 'Active'),
('CCJ', 'College of Criminal Justice', NULL, 'Active'),
('CCS', 'College of Computer Studies', 'TR0005', 'Active'),
('CTHM', 'College of Tourism and Hotel Management', NULL, 'Active'),
('EDUC', 'College of Education', NULL, 'Active'),
('REM', 'College of Real Estate Management', NULL, 'Active'),
('RRR', 'RAMBUTAN', NULL, 'Inactive'),
('JAJA', 'du', NULL, 'Inactive'),
('DUM', 'DUM', NULL, 'Inactive');

-- --------------------------------------------------------

--
-- Table structure for table `enrollment`
--

CREATE TABLE `enrollment` (
  `enrollment_id` int(11) NOT NULL,
  `stud_id` varchar(225) NOT NULL,
  `section_id` int(11) DEFAULT NULL,
  `academic_year` varchar(225) NOT NULL,
  `semester` varchar(225) NOT NULL,
  `enrolled_date` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `enrollment`
--

INSERT INTO `enrollment` (`enrollment_id`, `stud_id`, `section_id`, `academic_year`, `semester`, `enrolled_date`) VALUES
(1, '1094-25', NULL, '2025-2026', '1st Sem', '2025-05-25'),
(2, '1094-24', NULL, '2024-2025', '2nd Sem', '2025-05-25'),
(3, '1094-24', NULL, '2024-2025', '1st Sem', '2024-08-01'),
(4, '1240-25', NULL, '2024-2025', '2nd Sem', '2025-01-15'),
(5, '1241-25', NULL, '2024-2025', '2nd Sem', '2025-01-15'),
(6, '1242-25', NULL, '2024-2025', '2nd Sem', '2025-01-15'),
(7, '1243-25', NULL, '2024-2025', '2nd Sem', '2025-01-15'),
(11, '1094-25', NULL, '2025-2026', '1st Sem', '2025-08-01'),
(12, '1244-25', NULL, '2025-2026', '1st Sem', '2025-08-01'),
(13, '1245-25', NULL, '2025-2026', '1st Sem', '2025-08-01'),
(14, '2001-25', NULL, '2025-2026', '1st Sem', '2025-08-01'),
(15, '2002-25', NULL, '2025-2026', '1st Sem', '2025-08-01'),
(16, '2003-25', NULL, '2025-2026', '1st Sem', '2025-08-01'),
(17, '1022-27', NULL, '2027-2028', '1st Sem', '2025-05-25'),
(18, '1094-27', NULL, '2027-2028', '1st Sem', '2025-05-26'),
(19, '1095-25', NULL, '2025-2026', '1st Sem', '2025-05-26'),
(20, '1096-25', NULL, '2025-2026', '1st Sem', '2025-05-27'),
(21, '2004-25', NULL, '2025-2026', '1st Sem', '2025-05-27'),
(22, '2005-25', NULL, '2025-2026', '1st Sem', '2025-05-27'),
(23, '2006-25', NULL, '2025-2026', '1st Sem', '2025-05-27'),
(24, '2007-25', 1, '2025-2026', '1st Sem', '2025-06-09'),
(25, '2008-25', 1, '2025-2026', '1st Sem', '2025-06-09'),
(26, '2009-25', 1, '2025-2026', '1st Sem', '2025-06-10'),
(27, '2010-25', 1, '2025-2026', '1st Sem', '2025-06-11');

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `grade_id` int(11) NOT NULL,
  `stud_id` varchar(225) NOT NULL,
  `sub_code` varchar(50) NOT NULL,
  `prelim` int(3) DEFAULT NULL,
  `midterm` int(3) DEFAULT NULL,
  `prefinal` int(3) DEFAULT NULL,
  `final` int(3) DEFAULT NULL,
  `final_grade` decimal(3,2) DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `grades`
--

INSERT INTO `grades` (`grade_id`, `stud_id`, `sub_code`, `prelim`, `midterm`, `prefinal`, `final`, `final_grade`, `remarks`) VALUES
(1, '2005-25', 'CS101', 80, 90, 80, 80, 2.50, 'PASSED'),
(2, '1095-25', 'BP113', 95, 95, 95, 95, 2.00, 'PASSED'),
(3, '2004-25', 'BP113', 95, 60, 60, 60, 5.00, 'FAILED'),
(4, '1096-25', 'BP113', NULL, NULL, NULL, NULL, NULL, NULL),
(5, '2006-25', 'CS101', NULL, NULL, NULL, NULL, NULL, NULL),
(6, '1095-25', 'CC133-2', NULL, NULL, NULL, NULL, NULL, 'INC'),
(7, '2007-25', 'CC133-2', 80, NULL, NULL, NULL, NULL, 'OD'),
(8, '2008-25', 'CC133-2', NULL, NULL, NULL, NULL, NULL, 'UOD'),
(9, '1096-25', 'CC133-2', 90, 80, 99, 99, 1.75, 'PASSED'),
(10, '2009-25', 'CC133-2', 80, 60, 60, 60, 5.00, 'FAILED');

-- --------------------------------------------------------

--
-- Table structure for table `registrar`
--

CREATE TABLE `registrar` (
  `registrar_id` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registrar`
--

INSERT INTO `registrar` (`registrar_id`, `password`, `last_name`, `first_name`, `middle_name`, `status`) VALUES
('REG-2025-001', '123', 'Santos', 'Maria', 'Cruz', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `school_year_table`
--

CREATE TABLE `school_year_table` (
  `school_year` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'open'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `school_year_table`
--

INSERT INTO `school_year_table` (`school_year`, `status`) VALUES
('2013-2014', 'Closed'),
('2014-2015', 'Closed'),
('2016-2017', 'Closed'),
('2024-2025', 'Closed'),
('2025-2026', 'Open'),
('2026-2027', 'Closed'),
('2027-2028', 'Closed');

-- --------------------------------------------------------

--
-- Table structure for table `semester_table`
--

CREATE TABLE `semester_table` (
  `semester` varchar(225) NOT NULL,
  `status` varchar(225) NOT NULL DEFAULT 'open'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `semester_table`
--

INSERT INTO `semester_table` (`semester`, `status`) VALUES
('1st Sem', 'Open'),
('2nd Sem', 'Closed');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `stud_id` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) NOT NULL,
  `year_level` varchar(10) NOT NULL,
  `department` varchar(255) NOT NULL,
  `course_code` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `isActive` varchar(225) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`stud_id`, `last_name`, `first_name`, `middle_name`, `year_level`, `department`, `course_code`, `password`, `status`, `isActive`) VALUES
('1022-27', 'usman', 'mahamad', 'rol', '1st Year', 'CTHM', 'courses', '123', 'REGULAR', 'Active'),
('1094-24', 'isa', 'jeremaya', 'Romero', '4th Year', 'CTHM', 'courses', '123', 'REGULAR', 'Active'),
('1094-25', 'Jhad', 'Usman', 'Rosmar', '2nd Year', 'CCS', 'BSIT', '123', 'REGULAR', 'Active'),
('1095-25', 'Rol', 'Eman', 'Te', '1st Year', 'CCS', 'BSIT', '123', 'REGULAR', 'Active'),
('1096-25', 'mo', 'ja', 'rant', '1st Year', 'CCS', 'BSIT', '123', 'REGULAR', 'Active'),
('1234-25', 'Bernardo', 'Kia', 'Casantusan', '3rd Year', 'CCS', 'BSIT', '12345', 'REGULAR', 'Active'),
('1235-25', 'Delos Santos', 'Rakko Raj', 'Habig', '2nd Year', 'CSS', 'BSIT', 'stud1235-25', 'IRREGULAR', 'Active'),
('1236-25', 'Balon', 'Laurence', 'Sapero', '2nd Year', 'CCS', 'BSIT', 'stud1236-25', 'IRREGULAR', 'Active'),
('1238-25', 'Cruz', 'Veejay', 'Roxas', '3rd Year', 'CCS', 'BSIT', 'stud1238-25', 'IRREGULAR', 'Active'),
('1239-25', 'Fernandez', 'Philip Jose', 'Quemano', '3rd Year', 'CCS', 'BSIT', 'stud1239-25', 'REGULAR', 'Active'),
('1240-25', 'Sahagun', 'Bernard', 'Gonzaga', '4th Year', 'CCS', 'BSIT', 'stud1240-25', 'REGULAR', 'Active'),
('1241-25', 'Bernardo', 'Aicelle', 'Casantusan', '1st Year', 'CAS', 'BSREM', 'stud1241-25', 'REGULAR', 'Active'),
('1242-25', 'Noche', 'Ysmael', 'Bautista', '2nd Year', 'CCS', 'BSCS', 'noche123', 'Regular', 'Active'),
('1243-25', 'Dolor', 'Justine', 'Romero', '2nd Year', 'CCS', 'BSCS', 'stud1243-25', 'REGULAR', 'Active'),
('1244-25', 'Marinay', 'Precious', 'Costales', '1st Year', 'CCS', 'BSCS', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'REGULAR', 'Active'),
('1245-25', 'Marinay', 'Reinald', 'Deiru', '1st Year', 'CCS', 'BSIT', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 'REGULAR', 'Active'),
('2001-25', 'Garcia', 'Maria', 'Lopez', '3rd Year', 'CCS', 'BSCS', 'pass123', 'REGULAR', 'Active'),
('2002-25', 'Reyes', 'Juan', 'Santos', '4th Year', 'CCS', 'BSIT', 'pass456', 'REGULAR', 'Active'),
('2003-25', 'Dela Cruz', 'Ana', 'Torres', '2nd Year', 'CAS', 'BSREM', 'pass789', 'IRREGULAR', 'Active'),
('2004-25', 'nald', 'rei', 'ma', '1st Year', 'CCS', 'BSIT', '123', 'IRREGULAR', 'Active'),
('2005-25', 'jil', 'jor', 'nig', '1st Year', 'CCS', 'BSCS', '123', 'IRREGULAR', 'Active'),
('2006-25', 'bi', 'les', 'yan', '1st Year', 'CCS', 'BSCS', '123', 'REGULAR', 'Active'),
('2007-25', 'ni', 'bor', 'kol', '1st Year', 'CCS', 'BSIT', '123', 'IRREGULAR', 'Active'),
('2008-25', 'at', 'bor', 'ni', '1st Year', 'CCS', 'BSIT', '123', 'REGULAR', 'Active'),
('2009-25', 'sha', 'nata', 'rol', '1st Year', 'CCS', 'BSIT', '123', 'REGULAR', 'Active'),
('2010-25', 'lakay', 'apo', 'saka', '1st Year', 'CCS', 'BSIT', '123', 'REGULAR', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `student_section`
--

CREATE TABLE `student_section` (
  `id` int(11) NOT NULL,
  `course_code` varchar(225) NOT NULL,
  `section` varchar(225) NOT NULL,
  `yearlevel` varchar(225) NOT NULL,
  `semester` varchar(225) NOT NULL,
  `schedule` text NOT NULL,
  `class` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_section`
--

INSERT INTO `student_section` (`id`, `course_code`, `section`, `yearlevel`, `semester`, `schedule`, `class`) VALUES
(33, 'BSIT', '11M1', '1st Year', '1st Sem', 'MORNING', 1),
(34, 'BSIT', '11M2', '1st Year', '1st Sem', 'MORNING', 2),
(35, 'BSIT', '11M3', '1st Year', '1st Sem', 'MORNING', 3),
(38, 'BSCS', '11M1', '1st Year', '1st Sem', 'MORNING', 1),
(39, 'BSCS', '11M2', '1st Year', '1st Sem', 'MORNING', 2),
(40, 'BSCS', '11M3', '1st Year', '1st Sem', 'MORNING', 3),
(41, 'BSIT', '21A1', '2nd Year', '1st Sem', 'AFTERNOON', 1),
(42, 'BSCS', '22A1', '2nd Year', '2nd Sem', 'AFTERNOON', 1),
(43, 'BSIT', '22A1', '2nd Year', '2nd Sem', 'AFTERNOON', 1),
(44, 'BSIT', '31E1', '3rd Year', '1st Sem', 'EVENING', 1),
(45, 'BSCS', '31E1', '3rd Year', '1st Sem', 'EVENING', 1),
(46, 'BSCS', '32E1', '3rd Year', '2nd Sem', 'EVENING', 1),
(47, 'BSIT', '32E1', '3rd Year', '2nd Sem', 'EVENING', 1),
(48, 'BSCS', '41E1', '4th Year', '1st Sem', 'EVENING', 1),
(49, 'BSCS', '42E1', '4th Year', '2nd Sem', 'EVENING', 1),
(50, 'BSIT', '41E1', '4th Year', '1st Sem', 'EVENING', 1),
(51, 'BSIT', '42E1', '4th Year', '2nd Sem', 'EVENING', 1),
(52, 'BSCS', '21M1', '2nd Year', '1st Sem', 'MORNING', 1);

-- --------------------------------------------------------

--
-- Table structure for table `student_subjects`
--

CREATE TABLE `student_subjects` (
  `id` int(11) NOT NULL,
  `stud_id` varchar(225) NOT NULL,
  `sub_id` varchar(50) NOT NULL,
  `sub_code` varchar(225) NOT NULL,
  `subject_name` varchar(225) NOT NULL,
  `school_year` varchar(50) NOT NULL,
  `semester` varchar(50) NOT NULL,
  `section` varchar(50) NOT NULL,
  `enrollment_date` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_subjects`
--

INSERT INTO `student_subjects` (`id`, `stud_id`, `sub_id`, `sub_code`, `subject_name`, `school_year`, `semester`, `section`, `enrollment_date`) VALUES
(22, '1095-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(23, '1095-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(24, '1095-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(25, '1095-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(26, '1095-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(27, '1095-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(28, '1095-25', 'sub13', 'BP113', 'Basic Photography', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(29, '1095-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(31, '2004-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M2', '2025-06-05'),
(32, '2004-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(33, '2004-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(34, '2004-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(35, '2004-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(36, '2004-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(37, '2004-25', 'sub13', 'BP113', 'Basic Photography', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(39, '2004-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(40, '1096-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(41, '1096-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(42, '1096-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(43, '1096-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(44, '1096-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(45, '1096-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(46, '1096-25', 'sub13', 'BP113', 'Basic Photography', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(47, '1096-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(48, '2005-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(49, '2005-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M2', '2025-06-05'),
(50, '2005-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(51, '2005-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M2', '2025-06-05'),
(52, '2005-25', 'sub25', 'CS101', 'Introduction to Computer Science', '2025-2026', '1st Sem', '11M1', '2025-06-05'),
(53, '2006-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-09'),
(54, '2006-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-09'),
(55, '2006-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-09'),
(56, '2006-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-09'),
(57, '2006-25', 'sub25', 'CS101', 'Introduction to Computer Science', '2025-2026', '1st Sem', '11M1', '2025-06-09'),
(58, '1094-25', 'sub14', 'CC213', 'Data Structures and Algorithms', '2025-2026', '1st Sem', '21A1', '2025-06-10'),
(59, '1094-25', 'sub17', 'GEC107', 'Art Appreciation', '2025-2026', '1st Sem', '21A1', '2025-06-10'),
(60, '1094-25', 'sub18', 'GAD213', '2D Game Art Development', '2025-2026', '1st Sem', '21A1', '2025-06-10'),
(61, '1094-25', 'sub20', 'CC223', 'Information Management 1', '2025-2026', '1st Sem', '21A1', '2025-06-10'),
(62, '1094-25', 'sub22', 'NET213', 'Networking 1', '2025-2026', '1st Sem', '21A1', '2025-06-10'),
(63, '1094-25', 'sub23', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '21A1', '2025-06-10'),
(64, '2007-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(65, '2007-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M2', '2025-06-10'),
(66, '2007-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M3', '2025-06-10'),
(67, '2007-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(68, '2007-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(69, '2007-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M2', '2025-06-10'),
(70, '2007-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M3', '2025-06-10'),
(71, '2008-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(72, '2008-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(73, '2008-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(74, '2008-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(75, '2008-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(76, '2008-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(77, '2008-25', 'sub13', 'BP113', 'Basic Photography', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(78, '2008-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(79, '2009-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(80, '2009-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(81, '2009-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(82, '2009-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(83, '2009-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(84, '2009-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(85, '2009-25', 'sub13', 'BP113', 'Basic Photography', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(86, '2009-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M1', '2025-06-10'),
(87, '2010-25', 'sub06', 'CC133-2', 'Computer Programming 1', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(88, '2010-25', 'sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(89, '2010-25', 'sub09', 'GEC101', 'Understanding the Self', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(90, '2010-25', 'sub10', 'PE101', 'Physical Fitness 1', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(91, '2010-25', 'sub11', 'GEC102', 'Mathematics in the Modern World', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(92, '2010-25', 'sub12', 'NSTP1', 'National Service Training Program 1', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(93, '2010-25', 'sub13', 'BP113', 'Basic Photography', '2025-2026', '1st Sem', '11M1', '2025-06-11'),
(94, '2010-25', 'sub21', 'CSS113', 'Advanced PC Troubleshooting', '2025-2026', '1st Sem', '11M1', '2025-06-11');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `sub_id` varchar(50) NOT NULL,
  `sub_code` varchar(255) NOT NULL,
  `subject_name` varchar(255) NOT NULL,
  `unit` varchar(255) NOT NULL,
  `year_level` varchar(255) NOT NULL,
  `semester` varchar(10) NOT NULL,
  `course` varchar(255) NOT NULL,
  `prerequisite_sub_id` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`sub_id`, `sub_code`, `subject_name`, `unit`, `year_level`, `semester`, `course`, `prerequisite_sub_id`) VALUES
('sub01', 'FIL101', 'Kontekstwalisadong Komunikasyon sa Filipino ', '3', '3rd Year', '1st Sem', 'General Education', NULL),
('sub02', 'ELEC313', 'IT Elective 2', '6', '3rd Year', '1st Sem', 'BSIT', '3rd Year Standing'),
('sub03', 'PIT313', 'Integrative Programming & Technologies 1', '3', '3rd Year', '1st Sem', 'BSIT', NULL),
('sub04', 'MS313', 'Quantitative Methods', '3', '3rd Year', '2nd Sem', 'BSIT', NULL),
('sub05', 'CAP323', 'Capstone Project and Research 1', '3', '3rd Year', '2nd Sem', 'BSIT', '3rd Year 2nd Sem'),
('sub06', 'CC133-2', 'Computer Programming 1', '3', '1st Year', '1st Sem', 'BSIT', NULL),
('sub07', 'VDG113', 'Visual Design Graphics', '3', '1st Year', '2nd Sem', 'BSIT', NULL),
('sub08', 'CC113-1', 'Introduction to Computing with Produtivity tools', '3', '1st Year', '1st Sem', 'BSIT', NULL),
('sub09', 'GEC101', 'Understanding the Self', '3', '1st Year', '1st Sem', 'General Education', NULL),
('sub10', 'PE101', 'Physical Fitness 1', '2', '1st Year', '1st Sem', 'General Education', NULL),
('sub11', 'GEC102', 'Mathematics in the Modern World', '3', '1st Year', '1st Sem', 'General Education', NULL),
('sub12', 'NSTP1', 'National Service Training Program 1', '3', '1st Year', '1st Sem', 'General Education', NULL),
('sub13', 'BP113', 'Basic Photography', '3', '1st Year', '1st Sem', 'BSIT', NULL),
('sub14', 'CC213', 'Data Structures and Algorithms', '3', '2nd Year', '1st Sem', 'BSIT', 'CC123'),
('sub15', 'CS213', 'Discrete Structures 2', '3', '2nd Year', '2nd Sem', 'BSIT', NULL),
('sub16', 'PE103', 'Physical Fitness 3', '3', '2nd Year', '1st Sem', 'General Eduction', 'PE102'),
('sub17', 'GEC107', 'Art Appreciation', '3', '2nd Year', '1st Sem', 'BSIT', NULL),
('sub18', 'GAD213', '2D Game Art Development', '3', '2nd Year', '1st Sem', 'BSIT', NULL),
('sub19', 'SDF213', 'Object-Oriented Programming', '3', '2nd Year', '2nd Sem', 'BSIT', NULL),
('sub20', 'CC223', 'Information Management 1', '3', '2nd Year', '1st Sem', 'BSIT', NULL),
('sub21', 'CSS113', 'Advanced PC Troubleshooting', '3', '1st Year', '1st Sem', 'BSIT', NULL),
('sub22', 'NET213', 'Networking 1', '3', '2nd Year', '1st Sem', 'BSIT', 'CC113-2'),
('sub23', 'GEC101', 'Purposive Communication', '3', '2nd Year', '1st Sem', 'General Education', NULL),
('sub24', 'SAD313', 'System Analysis and Development', '3', '3rd Year', '1st Sem', 'BSIT', NULL),
('sub25', 'CS101', 'Introduction to Computer Science', '3', '1st Year', '1st Sem', 'BSCS', NULL),
('sub26', 'IT201', 'Database Systems', '3', '2nd Year', '', 'BSIT', NULL),
('sub27', 'REM301', 'Property Management', '3', '3rd Year', '', 'BSREM', NULL),
('sub28', 'NSTP2', 'National Service Training Program', '3', '1st Year', '', 'General Education', 'NSTP1'),
('sub29', 'PE102', 'Physical Fitness 2', '2', '1st Year', '', 'General Education', 'PE101'),
('sub30', 'PE104', 'Physical Fitness 4', '2', '2nt Year', '', 'General Education', 'PE103'),
('sub31', 'dummy', 'asd', '3', '3rd Year', '', 'BSIT', '');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_subjects`
--

CREATE TABLE `teacher_subjects` (
  `id` int(11) NOT NULL,
  `teacher_id` varchar(225) NOT NULL,
  `sub_code` varchar(225) NOT NULL,
  `course_code` varchar(225) NOT NULL,
  `section` varchar(225) NOT NULL,
  `yearlevel` varchar(225) NOT NULL,
  `semester` varchar(225) NOT NULL,
  `school_year` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `teacher_subjects`
--

INSERT INTO `teacher_subjects` (`id`, `teacher_id`, `sub_code`, `course_code`, `section`, `yearlevel`, `semester`, `school_year`) VALUES
(1, 'TR0001', 'CS101', 'BSCS', '11M1', '1st Year', '1st Sem', '2025-2026'),
(3, 'TR0001', 'CS101', 'BSCS', '11M2', '1st Year', '1st Sem', '2025-2026'),
(4, 'TR0001', 'CC133-2', 'BSIT', '11M1', '1st Year', '1st Sem', '2025-2026'),
(6, 'TR0005', 'CC213', 'BSIT', '21A1', '2nd Year', '1st Sem', '2025-2026'),
(7, 'TR0002', 'ELEC313', 'BSIT', '31E1', '3rd Year', '1st Sem', '2025-2026'),
(8, 'TR0003', 'SAD313', 'BSIT', '31E1', '3rd Year', '1st Sem', '2025-2026'),
(9, 'TR0005', 'CC223', 'BSIT', '21A1', '2nd Year', '1st Sem', '2025-2026'),
(10, 'TR0005', 'GEC107', 'BSIT', '21A1', '2nd Year', '1st Sem', '2025-2026'),
(11, 'TR0005', 'PIT313', 'BSIT', '31E1', '3rd Year', '1st Sem', '2025-2026'),
(12, 'TR0005', 'BP113', 'BSIT', '11M1', '1st Year', '1st Sem', '2025-2026');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_table`
--

CREATE TABLE `teacher_table` (
  `teacher_id` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `department_id` varchar(225) NOT NULL,
  `password` varchar(225) NOT NULL,
  `is_Dean` text NOT NULL DEFAULT 'not_dean'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `teacher_table`
--

INSERT INTO `teacher_table` (`teacher_id`, `last_name`, `first_name`, `department_id`, `password`, `is_Dean`) VALUES
('TR0001', 'Samar', 'Usman', 'CCS', '123', 'not_dean'),
('TR0002', 'Rodriguez', 'Ernesto', 'CCS', '123', 'not_dean'),
('TR0003', 'Santos', 'Carlos', 'CCS', '123', 'not_dean'),
('TR0004', 'Lim', 'Grace', 'CAS', '123', 'not_dean'),
('TR0005', 'Martinez', 'Juan', 'CCS', '123', 'dean');

-- --------------------------------------------------------

--
-- Table structure for table `term_table`
--

CREATE TABLE `term_table` (
  `term` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Open'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `term_table`
--

INSERT INTO `term_table` (`term`, `status`) VALUES
('final', 'Closed'),
('midterm', 'Closed'),
('prefinal', 'Closed'),
('prelim', 'Open');

-- --------------------------------------------------------

--
-- Table structure for table `user_register`
--

CREATE TABLE `user_register` (
  `username` varchar(255) NOT NULL,
  `student_id` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `middleName` varchar(255) NOT NULL,
  `birthday` date NOT NULL,
  `address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_register`
--

INSERT INTO `user_register` (`username`, `student_id`, `password`, `lastName`, `firstName`, `middleName`, `birthday`, `address`) VALUES
('Sung Jinwoo', '1111-22', '$2y$10$RWfxGWcn2DtQuhx2QxNfzOwYNh.qiuXNfE2xKe1yM4j', 'Sung', 'Jinwo', 'S.', '2004-12-13', 'brgy. magsaysay, san pedro laguna'),
('Thomas Andre', '1120-22', '$2y$10$40u/nsGedn/BLU67RQ5y4.tw4tWEYJDqtk9XrU9l81s', 'Andre', 'Thomas', 'F.', '2000-06-06', 'baranggay san antonio, san pedro laguna ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`course_id`),
  ADD UNIQUE KEY `course_code` (`course_code`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `enrollment`
--
ALTER TABLE `enrollment`
  ADD PRIMARY KEY (`enrollment_id`);

--
-- Indexes for table `grades`
--
ALTER TABLE `grades`
  ADD PRIMARY KEY (`grade_id`);

--
-- Indexes for table `registrar`
--
ALTER TABLE `registrar`
  ADD PRIMARY KEY (`registrar_id`);

--
-- Indexes for table `school_year_table`
--
ALTER TABLE `school_year_table`
  ADD PRIMARY KEY (`school_year`);

--
-- Indexes for table `semester_table`
--
ALTER TABLE `semester_table`
  ADD PRIMARY KEY (`semester`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`stud_id`);

--
-- Indexes for table `student_section`
--
ALTER TABLE `student_section`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_subjects`
--
ALTER TABLE `student_subjects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`sub_id`);

--
-- Indexes for table `teacher_subjects`
--
ALTER TABLE `teacher_subjects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teacher_table`
--
ALTER TABLE `teacher_table`
  ADD PRIMARY KEY (`teacher_id`);

--
-- Indexes for table `term_table`
--
ALTER TABLE `term_table`
  ADD PRIMARY KEY (`term`);

--
-- Indexes for table `user_register`
--
ALTER TABLE `user_register`
  ADD PRIMARY KEY (`student_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `enrollment`
--
ALTER TABLE `enrollment`
  MODIFY `enrollment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `grades`
--
ALTER TABLE `grades`
  MODIFY `grade_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `student_section`
--
ALTER TABLE `student_section`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT for table `student_subjects`
--
ALTER TABLE `student_subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95;

--
-- AUTO_INCREMENT for table `teacher_subjects`
--
ALTER TABLE `teacher_subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
