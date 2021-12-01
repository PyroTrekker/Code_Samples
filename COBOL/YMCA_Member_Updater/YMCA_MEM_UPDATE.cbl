      ******************************************************************
      * Author: Graham Wenz
      * Date: 11/02/2016
      * Purpose: This program prepares and prints a report file on YMCA Members
      * Tectonics: cobc
      *
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. YMCA-MEMBERS-REPORT.

       ENVIRONMENT DIVISION.

       CONFIGURATION SECTION.

       INPUT-OUTPUT SECTION.

       FILE-CONTROL.
           SELECT YMCAMEM ASSIGN TO "E:\YMCAMEM.txt"
               ORGANIZATION IS LINE SEQUENTIAL.
           SELECT MEMBERRPT ASSIGN TO "E:\MEMBERRPT.txt"
               ORGANIZATION IS LINE SEQUENTIAL.

       DATA DIVISION.

       FILE SECTION.

       FD  YMCAMEM.
       01  MEMBER-LINE PIC X(85).


       WORKING-STORAGE SECTION.

       01  SWITCHES.
           05  EOF-SWITCH                  PIC X          VALUE "N".
               88  EOF                                    VALUE "Y".
           05  FIRST-RECORD-SWITCH         PIC X          VALUE "Y".
               88  FIRST-RECORD                           VALUE "Y".

        01  STATUS-TRACKERS.
           05  OLD-STATUS              PIC X(8).
           05  OLD-TRAINER             PIC X(8).

       01  NEW-MEMBER.
           05  MBR-STATUS              PIC X(8).
           05  MBR-PERSONAL-TRAINER    PIC X(8).
           05  MBR-CARD-NUMBER         PIC 9(6).
           05  MBR-NAME                PIC X(20).
           05  MBR-FAV-ACTIVITY        PIC X(10).
           05  MBR-MEMBERSHIP-FEES     PIC 9(3)V9(2).
           05  MBR-CLASS-FEES          PIC 9(3)V9(2).
           05  MBR-MASSAGE-FEES        PIC 9(3)V9(2).
           05  MBR-FITNESS-SCORE       PIC 9(3)V9(2).
           05  MBR-ZIPCODE             PIC 9(5).

       PROCEDURE DIVISION.

       000-UPDATE-MEMBER-LIST.
           OPEN EXTEND YMCAMEM.
           PERFORM 100-INPUT-NEW-MEMBER-DATA.
           CLOSE YMCAMEM.
           STOP RUN.

       100-INPUT-NEW-MEMBER-DATA.
